#include <Wire.h>
#include <AltSoftSerial.h>
#include <TinyGPS.h>
#include "I2Cdev.h"

#include "MPU6050_6Axis_MotionApps20.h"




// Config

constexpr byte roll_port = 0b00000100;
constexpr byte pitch_port = 0b00001000;
constexpr byte throttle_port = 0b00010000;
constexpr byte yaw_port = 0b00100000;


// Macros

//#define DEBUG_DATA
#define DEBUG_ESC
// Macros for reading port of channel
#define CHANNEL_PIN_READ(data) \
  if (data##_flag == false && (PINB & data##_port)) { \
    data##_flag = true; \
    data##_timer = current_micros; \
  } else if (data##_flag == true && !(PINB & data##_port)) { \
    data##_flag = false; \
    data = current_micros - data##_timer; \
  }


// Global variable

MPU6050 mpu(0x68);
volatile int roll, pitch, throttle, yaw;
volatile bool roll_flag, pitch_flag, throttle_flag, yaw_flag;
volatile unsigned long roll_timer, pitch_timer, throttle_timer, yaw_timer;
uint8_t fifoBuffer[64];
Quaternion q;
VectorFloat gravity;
float ypr[3];


void setup() {
  PCICR |= (1 << PCIE0);
  PCMSK0 |= (1 << PCINT2) | (1 << PCINT3) | (1 << PCINT4) | (1 << PCINT5);

  DDRD |= B11111111;

#if defined(DEBUG_DATA) || defined(DEBUG_ESC)
  Serial.begin(9600);
#endif

#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
  Wire.begin();
  Wire.setClock(400000); // 400kHz I2C clock. Comment this line if having compilation difficulties
#elif I2CDEV_IMPLEMENTATION == I2CDEV_BUILTIN_FASTWIRE
  Fastwire::setup(400, true);
#endif

  mpu.initialize();
  int a = mpu.dmpInitialize();
  mpu.setXGyroOffset(220);
  mpu.setYGyroOffset(76);
  mpu.setZGyroOffset(-85);
  mpu.setZAccelOffset(1788);
  if (a == 0)
  {
    mpu.CalibrateAccel(6);
    mpu.CalibrateGyro(6);
#ifdef DEBUG_DATA
    mpu.PrintActiveOffsets();
#endif
    mpu.setDMPEnabled(true);

  }
}


void loop() {
#ifdef DEBUG_DATA
  Serial.print(roll); Serial.print(" ");
  Serial.print(pitch); Serial.print(" ");
  Serial.print(throttle); Serial.print(" ");
  Serial.print(yaw); Serial.print(" ");
  Serial.print(ypr[0]); Serial.print(" ");
  Serial.print(ypr[1]); Serial.print(" ");
  Serial.print(ypr[2]); Serial.println(" ");
#endif
  if (mpu.dmpGetCurrentFIFOPacket(fifoBuffer)) {
    mpu.dmpGetQuaternion(&q,  fifoBuffer);
    mpu.dmpGetGravity(&gravity, &q);
    mpu.dmpGetYawPitchRoll(ypr, &q, &gravity);
    ypr[0] *= 180 / M_PI;
    ypr[1] *= 180 / M_PI;
    ypr[2] *= 180 / M_PI;
  }
  run_motors(constrain(roll,1000,2000), constrain(pitch,1000,2000), constrain(throttle,1000,2000), constrain(yaw,1000,2000));
}


ISR(PCINT0_vect) {
  const unsigned long current_micros = micros();
  CHANNEL_PIN_READ(roll);
  CHANNEL_PIN_READ(pitch);
  CHANNEL_PIN_READ(throttle);
  CHANNEL_PIN_READ(yaw);
}

unsigned long esc_loop_timer, loop_timer;

inline void run_motors(int current_roll, int current_pitch, int current_throttle, int current_yaw)
{

  int
  esc1 = current_throttle + (current_yaw - 1500) + (current_pitch - 1500) + (current_roll - 1500), // CW
  esc2 = current_throttle - (current_yaw - 1500) + (current_pitch - 1500) + (current_roll - 1500), // CCW
  esc3 = current_throttle + (current_yaw - 1500) + (current_roll - 1500), // CW
  esc4 = current_throttle - (current_yaw - 1500) - (current_pitch - 1500) - (current_roll - 1500), // CCW
  esc5 = current_throttle + (current_yaw - 1500) - (current_pitch - 1500) - (current_roll - 1500), // CW
  esc6 = current_throttle - (current_yaw - 1500) - (current_roll - 1500); // CCW
  if (current_throttle < 1050)
  {
    esc1 = esc2 = esc3 = esc4 = esc5 = esc6 = 1000;
  } else {
    if (esc1 < 1100) esc1 = 1100;
    if (esc2 < 1100) esc2 = 1100;
    if (esc3 < 1100) esc3 = 1100;
    if (esc4 < 1100) esc4 = 1100;
    if (esc5 < 1100) esc5 = 1100;
    if (esc6 < 1100) esc6 = 1100;

    if (esc1 > 2000) esc1 = 2000;
    if (esc2 > 2000) esc2 = 2000;
    if (esc3 > 2000) esc3 = 2000;
    if (esc4 > 2000) esc4 = 2000;
    if (esc5 > 2000) esc5 = 2000;
    if (esc6 > 2000) esc6 = 2000;
  }


#ifdef DEBUG_ESC
  Serial.print(esc1); Serial.print(" ");
  Serial.print(esc2); Serial.print(" ");
  Serial.print(esc3); Serial.print(" ");
  Serial.print(esc4); Serial.print(" ");
  Serial.print(esc5); Serial.print(" ");
  Serial.print(esc6); Serial.println(" ");

#endif
  while (micros() - loop_timer < 4000);
  loop_timer = micros();
  const unsigned long
  timer_esc1 = loop_timer + esc1,
  timer_esc2 = loop_timer + esc2,
  timer_esc3 = loop_timer + esc3,
  timer_esc4 = loop_timer + esc4,
  timer_esc5 = loop_timer + esc5,
  timer_esc6 = loop_timer + esc6;

  PORTD |= 0b11111100;
  while (PORTD >= 4) {
    esc_loop_timer = micros();
    if (timer_esc1 <= esc_loop_timer)PORTD &= 0b11111011;
    if (timer_esc2 <= esc_loop_timer)PORTD &= 0b11110111;
    if (timer_esc3 <= esc_loop_timer)PORTD &= 0b11101111;
    if (timer_esc4 <= esc_loop_timer)PORTD &= 0b11011111;
    if (timer_esc5 <= esc_loop_timer)PORTD &= 0b10111111;
    if (timer_esc6 <= esc_loop_timer)PORTD &= 0b01111111;
  }
}

