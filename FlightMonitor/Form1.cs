// made by Spulber George, all rights reserved
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FlightMonitor
{
    public partial class Form1 : Form
    {
        sbyte indexOf_firstCharacter, indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ; // these variables are helping us to get the data from serial
        string str_roll, str_pitch, str_throttle, str_yaw, str_X, str_Y, str_Z, str_lat, str_lon, str_sat; // string data from serial

        int roll, pitch, throttle, yaw; // int data from serial
        int calibrate_counter = 0; // this variable is used to know the number of times the calibrateBtn was pressed

        double lat, lon;
        int sat;

        private void calibrateBtn_Click(object sender, EventArgs e)
        {
            calibrate_counter++; // every time the calibrateBtn is pressed, we add 1 to our variable

            if (calibrate_counter == 1) // when the calibrateBtn it's for the first time, we are showing some instructions
            {
                calibrateLabel.ForeColor = Color.Red;
                calibrateLabel2.ForeColor = Color.Red;
                rollCal.ForeColor = Color.Red;
                pitchCal.ForeColor = Color.Red;
                throttleCal.ForeColor = Color.Red;
                yawCal.ForeColor = Color.Red;

                calibrateLabel.Text = "Center and keep all your radio sticks";
                calibrateLabel2.Text = "at 50%.";
                calibrateBtn.Text = "Next";
            }
            
            if (calibrate_counter == 2) // when the calibrateBtn it's for the second time, we are showing some instructions
            {
                calibrateLabel.Text = "When calibrated, you should see";
                calibrateLabel2.Text = "all directions turning green.";
            }

            if(calibrate_counter == 3) // when the calibrateBtn it's for the third time, we are showing some instructions
            {
                calibrateLabel.Text = "To calibrate, use your trims to set";
                calibrateLabel2.Text = " all directions values at 1500 ms.";

                calibrateBtn.Text = "Done";
                
            }

            if(calibrate_counter == 4) // when the calibrateBtn it's for the fourth time, we checking some info to see if the calibration is complete
            {
                // if all the parameters have color green set as ForeColor, it means that all the directions were calibrated (check the Show_Data function)
                if(rollCal.ForeColor == Color.Green && pitchCal.ForeColor == Color.Green && throttleCal.ForeColor == Color.Green && yawCal.ForeColor == Color.Green)
                {
                    calibrateBtn.Text = "Recalibrate";
                    calibrateLabel.ForeColor = Color.Green;
                    calibrateLabel2.ForeColor = Color.Green;
                    calibrateLabel.Text = "Calibrated succesfully!";
                    calibrateLabel2.Text = " ";
                    calibrate_counter = 0;
                }
                else // if not, it means that the calibration isn't comlete (check the Show_Data function)
                {
                    calibrateBtn.Text = "Recalibrate";
                    calibrateLabel.Text = "Not all directions calibrated!";
                    calibrateLabel2.Text = "Please recalibrate!";
                    rollCal.ForeColor = Color.Red;
                    pitchCal.ForeColor = Color.Red;
                    throttleCal.ForeColor = Color.Red;
                    yawCal.ForeColor = Color.Red;
                    calibrate_counter = 0;
                }
            }
        }

        bool radioData = false; // we use this variable to check if we are recieving data from the radio via serial
        bool gyroData = false;
        bool gpsData = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // actions to set when the form is loaded
        {
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
            calibrateBtn.Enabled = false;
        }

        private void com_cBox_DropDown(object sender, EventArgs e) // when the combo box is open, we are showing all the avalabile serial ports  
        {
            string[] portsList = SerialPort.GetPortNames();
            com_cBox.Items.Clear();
            com_cBox.Items.AddRange(portsList);
        }

        // when the connectBtn is pressed, we try to make a connection with the serial port and baud rate that was selected
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = com_cBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(baud_cBox.Text);
                serialPort1.Open();

                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;

                serialStatusLabel.ForeColor = Color.Green;
                serialStatusLabel.Text = "Connected";

                MessageBox.Show("Connected to " + com_cBox.Text);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        // when the disconnectBtn is pressed we try to close the serial connection.
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
                calibrateBtn.Enabled = false;

                serialStatusLabel.ForeColor = Color.Red;
                serialStatusLabel.Text = "Disconnected";

                roll_progress.Value = 980;
                rollValueLabel.Text = " ";

                pitch_progress.Value = 980;
                pitchValueLabel.Text = " ";

                throttle_progress.Value = 980;
                throttleValueLabel.Text = " ";

                yaw_progress.Value = 980;
                yawValueLabel.Text = " ";

                calibrate_counter = 0;
                calibrateLabel.ForeColor = Color.Red;
                calibrateLabel2.ForeColor = Color.Red;
                calibrateBtn.Text = "Calibrate";
                calibrateLabel.Text = "Not calibrated...";
                calibrateLabel2.Text = " ";
                rollCal.ForeColor = Color.Red;
                pitchCal.ForeColor = Color.Red;
                throttleCal.ForeColor = Color.Red;
                yawCal.ForeColor = Color.Red;


                waitingLabel.ForeColor = Color.Red;
                waitingLabel.Text = "Waiting for port to connect...";

                gpsStatusLabel.ForeColor = Color.Red;
                gpsStatusLabel.Text = "NO GPS";
                latValueLabel.Text = " ";
                lonValueLabel.Text = " ";
                satellitesValueLabel.Text = "0";

                MessageBox.Show("Disconnected");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch(Exception error)
            { 
                MessageBox.Show(error.Message);
            }
        }

        // when we recieve serial data we make a new EventHandler
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = serialPort1.ReadTo("\n");
            Data_Parsing(dataIn);
            this.BeginInvoke(new EventHandler(Show_Data));
        }

        private void Show_Data(object sender, EventArgs e)
        {
            // if we receive data from the radio, we enable some actions and show the information that comes from the serial.
            if (radioData == true)
            {
                calibrateBtn.Enabled = true;

                waitingLabel.ForeColor = Color.Green;
                waitingLabel.Text = "Recieving data...";

                rollValueLabel.Text = str_roll + " ms";
                roll_progress.Value = roll;

                pitchValueLabel.Text = str_pitch + " ms";
                pitch_progress.Value = pitch;

                throttleValueLabel.Text = str_throttle + " ms";
                throttle_progress.Value = throttle;

                yawValueLabel.Text = str_yaw + " ms";
                yaw_progress.Value = yaw;

                // CALIBRATE STUFF
                // the correct calibrate value for one direction is 1500 ms at 50% of power
                if (calibrate_counter == 3)
                {
                    if(roll == 1500)
                    {
                        rollCal.ForeColor = Color.Green;
                    }

                    if(pitch == 1500)
                    {
                        pitchCal.ForeColor = Color.Green;
                    }

                    if (throttle == 1500)
                    {
                        throttleCal.ForeColor = Color.Green;
                    }

                    if (yaw == 1500)
                    {
                        yawCal.ForeColor = Color.Green;
                    }
                }

            }
            else if (radioData == false)
            {
                waitingLabel.ForeColor = Color.Red;
                waitingLabel.Text = "Waiting for data...";
                calibrateBtn.Enabled = false;
            }

            if(gyroData == true)
            {
                xValueLabel.Text = str_X;
                yValueLabel.Text = str_Y;
                zValueLabel.Text = str_Z;
                gyroValueLabel.ForeColor = Color.Green;
                gyroValueLabel.Text = "Gyro detected.";
            }
            else if(gyroData == false)
            {
                gyroValueLabel.ForeColor = Color.Red;
                gyroValueLabel.Text = "No gyro detected.";
            }

            if(gpsData == true)
            {
                gpsBrowser.Navigate("https://www.openstreetmap.org/?mlat=" + lat + "&mlon=" + lon + "#map=17/" + lat + "/" + lon); // gps position
                latValueLabel.Text = str_lat;
                lonValueLabel.Text = str_lon;
                satellitesValueLabel.Text = str_sat;

                gpsStatusLabel.ForeColor = Color.Green;
                gpsStatusLabel.Text = "GPS CONNECTED";
            }
            else if(gpsData == false)
            {
                gpsStatusLabel.ForeColor = Color.Red;
                gpsStatusLabel.Text = "NO GPS";
            }
        }

        // here we take the data that we need from the serial with the help of the pattern that we made for the flight controller
        private void Data_Parsing(string data)
        {
            indexOf_firstCharacter = (sbyte)data.IndexOf("@");
            indexOfA = (sbyte)data.IndexOf("A");
            indexOfB = (sbyte)data.IndexOf("B");
            indexOfC = (sbyte)data.IndexOf("C");
            indexOfD = (sbyte)data.IndexOf("D");
            indexOfE = (sbyte)data.IndexOf("E");
            indexOfF = (sbyte)data.IndexOf("F");
            indexOfG = (sbyte)data.IndexOf("G");
            indexOfH = (sbyte)data.IndexOf("H");
            indexOfI = (sbyte)data.IndexOf("I");
            indexOfJ = (sbyte)data.IndexOf("J");

            // radio data
            if(indexOfA!=-1 && indexOfB!=-1 && indexOfC!=-1 && indexOfD!=-1 && indexOf_firstCharacter != -1)
            {
                try
                {
                    str_roll = data.Substring(indexOf_firstCharacter + 1, (indexOfA - indexOf_firstCharacter) - 1);
                    str_pitch = data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                    str_throttle = data.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                    str_yaw = data.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);

                    roll = Convert.ToInt16(str_roll);
                    pitch = Convert.ToInt16(str_pitch);
                    throttle = Convert.ToInt16(str_throttle);
                    yaw = Convert.ToInt16(str_yaw);

                    radioData = true; // if we receive radio data from serial we set the radioData true (the pattern for radio exists)

                }
                catch(Exception)
                {

                }
                
            }
            else
            {
                radioData = false; // if we don't receive radio data from the serial, we set it false (the pattern for radio doesn't exists)
            }

            // gyro data
            if(indexOf_firstCharacter!= -1 && indexOfD!= -1 && indexOfE!= -1 && indexOfF!= -1 && indexOfG!= -1)
            {
                try
                {

                    str_X = data.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                    str_Y = data.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                    str_Z = data.Substring(indexOfF + 1, (indexOfG - indexOfF) - 1);

                    gyroData = true;

                }
                catch (Exception)
                {

                }
            }
            else
            {
                gyroData = false;
            }

            // GPS data
            if (indexOf_firstCharacter != -1 && indexOfG != -1 && indexOfH != -1 && indexOfI != -1 && indexOfJ != -1)
            {
                try
                {
                    str_lat = data.Substring(indexOfG + 1, (indexOfH - indexOfG) - 1);
                    str_lon = data.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);
                    str_sat = data.Substring(indexOfI + 1, (indexOfJ - indexOfI) - 1);

                    lat = Convert.ToDouble(str_lat);
                    lon = Convert.ToDouble(str_lat);
                    sat = Convert.ToInt16(str_sat);

                    gpsData = true;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                gpsData = false;
            }
        }
        
    }
}
