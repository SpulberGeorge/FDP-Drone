// made by Spulber George and Albert Maftei, all rights reserved

#include <Wire.h> // we are using i2c communication for gyro
#include <AltSoftSerial.h> // we are using AltSoftSerial to take data from the GPS module
#include  <TinyGPS.h> // we are using TinyGPS library to decode the data from the GPS module

byte canal_1, canal_2, canal_3, canal_4; //
int input_c1, input_c2, input_c3, input_c4; // the recieved input from radio
unsigned long t1, t2, t3, t4; // timers for radio
float flat, flon;
unsigned long age;
int X, Y, Z; // directions from gyro

AltSoftSerial GPSSerial; //
TinyGPS gps; // here we create a new TinyGPS object

void setup() {
  // Radio
  // setting the interrupts pins for the radio
  PCICR |= (1 << PCIE0);
  PCMSK0 |= (1 << PCINT2);
  PCMSK0 |= (1 << PCINT3);
  PCMSK0 |= (1 << PCINT4);
  PCMSK0 |= (1 << PCINT5);
  DDRD |= B11111111; // sets the ESC pins to OUTPUT mode
  // Radio
  //pinMode(7,OUTPUT);
  Serial.begin(9600);

  // Gyro
  Wire.setClock(400000); // set I2C clock speed to 4MHZ
  Wire.begin();
  delay(250);
  Wire.beginTransmission(0x68);
  Wire.write(0x6B);
  Wire.write(0x00);
  Wire.endTransmission();
  // Gyro

  //GPS
  GPSSerial.begin(9600);
  //GPS
}

void loop() {

  Serial.print("@");
  Serial.print(input_c1); Serial.print("A");
  Serial.print(input_c2); Serial.print("B");
  Serial.print(input_c3); Serial.print("C");
  Serial.print(input_c4); Serial.print("D");
  

  // Gyro
  Wire.beginTransmission(0x68);
  Wire.write(0x43);
  Wire.endTransmission();
  Wire.requestFrom(0x68, 6);
  X = Wire.read() << 8 | Wire.read();
  Y = Wire.read() << 8 | Wire.read();
  Z = Wire.read() << 8 | Wire.read();

  Serial.print(X); Serial.print("E");
  Serial.print(Y); Serial.print("F");
  Serial.print(Z); Serial.print("G");
  // Gyro
  while (GPSSerial.available())
  {
    if (gps.encode(GPSSerial.read())) // Did a new valid sentence come in?
    {
      gps.f_get_position(&flat, &flon, &age);
    }
    
  }

  
  Serial.print(flat == TinyGPS::GPS_INVALID_F_ANGLE ? 0.0 : flat, 6); Serial.print("H");
  Serial.print(flon == TinyGPS::GPS_INVALID_F_ANGLE ? 0.0 : flon, 6); Serial.print("I");
  Serial.print(gps.satellites() == TinyGPS::GPS_INVALID_SATELLITES ? 0 : gps.satellites()); Serial.println("J");
  simple_throttle(input_c3);
}


inline void simple_throttle(int value) //function which simply pulses all of the motors to the throttle value
{
  PORTD |= B11111100; // outputs HIGH on pins 7-2
  unsigned long loop_timer=micros();
  while(micros()-loop_timer<value);
  PORTD &= B00000011; // outputs LOW on pins 7-2
}

// interrupt for radio
ISR(PCINT0_vect) {

  // channel 1
  if (canal_1 == 0 && PINB & B00000100) { // checks if the pulse increases
    canal_1 = 1; // setting the state of the channel
    t1 = micros(); // the value of the timer
  }
  else if (canal_1 == 1 && !(PINB & B00000100)) { // checks if the pulse decreases
    canal_1 = 0; // setting the state of the channel
    input_c1 = micros() - t1; // the value of the channel input that we receive
  }

  // channel 2
  if (canal_2 == 0 && PINB & B00001000) { // checks if the pulse increases
    canal_2 = 1; // setting the state of the channel
    t2 = micros(); // the value of the timer
  }
  else if (canal_2 == 1 && !(PINB & B00001000)) { // checks if the pulse decreases
    canal_2 = 0; // setting the state of the channel
    input_c2 = micros() - t2; // the value of the channel input that we receive
  }

  // channel 3
  if (canal_3 == 0 && PINB & B00010000) { // checks if the pulse increases
    canal_3 = 1; // setting the state of the channel
    t3 = micros(); // the value of the timer
  }
  else if (canal_3 == 1 && !(PINB & B00010000)) { // checks if the pulse decreases
    canal_3 = 0; // setting the state of the channel
    input_c3 = micros() - t3; // the value of the channel input that we receive
  }

  // channel 4
  if (canal_4 == 0 && PINB & B00100000) { // checks if the pulse increases
    canal_4 = 1; // setting the state of the channel
    t4 = micros(); // the value of the timer
  }
  else if (canal_4 == 1 && !(PINB & B00100000)) { // checks if the pulse decreases
    canal_4 = 0; // setting the state of the channel
    input_c4 = micros() - t4; // the value of the channel input that we receive
  }
}