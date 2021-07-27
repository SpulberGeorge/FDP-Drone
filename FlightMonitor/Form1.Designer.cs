
namespace FlightMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serial_groupbox = new System.Windows.Forms.GroupBox();
            this.serialStatusLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.baud_cBox = new System.Windows.Forms.ComboBox();
            this.com_cBox = new System.Windows.Forms.ComboBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.comLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.radio_groupbox = new System.Windows.Forms.GroupBox();
            this.calibrateRadio_groupbox = new System.Windows.Forms.GroupBox();
            this.calibrateLabel2 = new System.Windows.Forms.Label();
            this.yawCal = new System.Windows.Forms.Label();
            this.calibrateBtn = new System.Windows.Forms.Button();
            this.calibrateLabel = new System.Windows.Forms.Label();
            this.throttleCal = new System.Windows.Forms.Label();
            this.pitchCal = new System.Windows.Forms.Label();
            this.rollCal = new System.Windows.Forms.Label();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.yawValueLabel = new System.Windows.Forms.Label();
            this.throttleValueLabel = new System.Windows.Forms.Label();
            this.pitchValueLabel = new System.Windows.Forms.Label();
            this.rollValueLabel = new System.Windows.Forms.Label();
            this.roll_progress = new System.Windows.Forms.ProgressBar();
            this.pitch_progress = new System.Windows.Forms.ProgressBar();
            this.throttle_progress = new System.Windows.Forms.ProgressBar();
            this.yaw_progress = new System.Windows.Forms.ProgressBar();
            this.yawLabel = new System.Windows.Forms.Label();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.rollLabel = new System.Windows.Forms.Label();
            this.gpsBrowser = new System.Windows.Forms.WebBrowser();
            this.gps_groupbox = new System.Windows.Forms.GroupBox();
            this.satellitesValueLabel = new System.Windows.Forms.Label();
            this.satellitePictureBox = new System.Windows.Forms.PictureBox();
            this.lonValueLabel = new System.Windows.Forms.Label();
            this.latValueLabel = new System.Windows.Forms.Label();
            this.lonLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.gpsStatusLabel = new System.Windows.Forms.Label();
            this.gyro_groupbox = new System.Windows.Forms.GroupBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.yValueLabel = new System.Windows.Forms.Label();
            this.zValueLabel = new System.Windows.Forms.Label();
            this.gyroValueLabel = new System.Windows.Forms.Label();
            this.serial_groupbox.SuspendLayout();
            this.radio_groupbox.SuspendLayout();
            this.calibrateRadio_groupbox.SuspendLayout();
            this.gps_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satellitePictureBox)).BeginInit();
            this.gyro_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_groupbox
            // 
            this.serial_groupbox.Controls.Add(this.serialStatusLabel);
            this.serial_groupbox.Controls.Add(this.connectBtn);
            this.serial_groupbox.Controls.Add(this.disconnectBtn);
            this.serial_groupbox.Controls.Add(this.baud_cBox);
            this.serial_groupbox.Controls.Add(this.com_cBox);
            this.serial_groupbox.Controls.Add(this.baudLabel);
            this.serial_groupbox.Controls.Add(this.comLabel);
            this.serial_groupbox.Location = new System.Drawing.Point(13, 13);
            this.serial_groupbox.Name = "serial_groupbox";
            this.serial_groupbox.Size = new System.Drawing.Size(259, 140);
            this.serial_groupbox.TabIndex = 0;
            this.serial_groupbox.TabStop = false;
            this.serial_groupbox.Text = "Serial";
            // 
            // serialStatusLabel
            // 
            this.serialStatusLabel.AutoSize = true;
            this.serialStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.serialStatusLabel.Location = new System.Drawing.Point(10, 113);
            this.serialStatusLabel.Name = "serialStatusLabel";
            this.serialStatusLabel.Size = new System.Drawing.Size(94, 17);
            this.serialStatusLabel.TabIndex = 6;
            this.serialStatusLabel.Text = "Disconnected";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(13, 82);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(84, 23);
            this.connectBtn.TabIndex = 5;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(109, 82);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(113, 23);
            this.disconnectBtn.TabIndex = 4;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // baud_cBox
            // 
            this.baud_cBox.FormattingEnabled = true;
            this.baud_cBox.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.baud_cBox.Location = new System.Drawing.Point(101, 52);
            this.baud_cBox.Name = "baud_cBox";
            this.baud_cBox.Size = new System.Drawing.Size(121, 24);
            this.baud_cBox.TabIndex = 3;
            // 
            // com_cBox
            // 
            this.com_cBox.FormattingEnabled = true;
            this.com_cBox.Location = new System.Drawing.Point(101, 21);
            this.com_cBox.Name = "com_cBox";
            this.com_cBox.Size = new System.Drawing.Size(121, 24);
            this.com_cBox.TabIndex = 2;
            this.com_cBox.DropDown += new System.EventHandler(this.com_cBox_DropDown);
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Location = new System.Drawing.Point(13, 55);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(87, 17);
            this.baudLabel.TabIndex = 1;
            this.baudLabel.Text = "BAUD RATE";
            // 
            // comLabel
            // 
            this.comLabel.AutoSize = true;
            this.comLabel.Location = new System.Drawing.Point(13, 24);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(82, 17);
            this.comLabel.TabIndex = 0;
            this.comLabel.Text = "COM PORT";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // radio_groupbox
            // 
            this.radio_groupbox.Controls.Add(this.calibrateRadio_groupbox);
            this.radio_groupbox.Controls.Add(this.waitingLabel);
            this.radio_groupbox.Controls.Add(this.yawValueLabel);
            this.radio_groupbox.Controls.Add(this.throttleValueLabel);
            this.radio_groupbox.Controls.Add(this.pitchValueLabel);
            this.radio_groupbox.Controls.Add(this.rollValueLabel);
            this.radio_groupbox.Controls.Add(this.roll_progress);
            this.radio_groupbox.Controls.Add(this.pitch_progress);
            this.radio_groupbox.Controls.Add(this.throttle_progress);
            this.radio_groupbox.Controls.Add(this.yaw_progress);
            this.radio_groupbox.Controls.Add(this.yawLabel);
            this.radio_groupbox.Controls.Add(this.throttleLabel);
            this.radio_groupbox.Controls.Add(this.pitchLabel);
            this.radio_groupbox.Controls.Add(this.rollLabel);
            this.radio_groupbox.Location = new System.Drawing.Point(13, 160);
            this.radio_groupbox.Name = "radio_groupbox";
            this.radio_groupbox.Size = new System.Drawing.Size(259, 248);
            this.radio_groupbox.TabIndex = 1;
            this.radio_groupbox.TabStop = false;
            this.radio_groupbox.Text = "Radio";
            // 
            // calibrateRadio_groupbox
            // 
            this.calibrateRadio_groupbox.Controls.Add(this.calibrateLabel2);
            this.calibrateRadio_groupbox.Controls.Add(this.yawCal);
            this.calibrateRadio_groupbox.Controls.Add(this.calibrateBtn);
            this.calibrateRadio_groupbox.Controls.Add(this.calibrateLabel);
            this.calibrateRadio_groupbox.Controls.Add(this.throttleCal);
            this.calibrateRadio_groupbox.Controls.Add(this.pitchCal);
            this.calibrateRadio_groupbox.Controls.Add(this.rollCal);
            this.calibrateRadio_groupbox.Location = new System.Drawing.Point(7, 134);
            this.calibrateRadio_groupbox.Name = "calibrateRadio_groupbox";
            this.calibrateRadio_groupbox.Size = new System.Drawing.Size(246, 108);
            this.calibrateRadio_groupbox.TabIndex = 13;
            this.calibrateRadio_groupbox.TabStop = false;
            this.calibrateRadio_groupbox.Text = "Calibrate Radio";
            // 
            // calibrateLabel2
            // 
            this.calibrateLabel2.AutoSize = true;
            this.calibrateLabel2.ForeColor = System.Drawing.Color.Red;
            this.calibrateLabel2.Location = new System.Drawing.Point(6, 77);
            this.calibrateLabel2.Name = "calibrateLabel2";
            this.calibrateLabel2.Size = new System.Drawing.Size(0, 17);
            this.calibrateLabel2.TabIndex = 19;
            // 
            // yawCal
            // 
            this.yawCal.AutoSize = true;
            this.yawCal.ForeColor = System.Drawing.Color.Red;
            this.yawCal.Location = new System.Drawing.Point(166, 38);
            this.yawCal.Name = "yawCal";
            this.yawCal.Size = new System.Drawing.Size(39, 17);
            this.yawCal.TabIndex = 18;
            this.yawCal.Text = "YAW";
            // 
            // calibrateBtn
            // 
            this.calibrateBtn.Location = new System.Drawing.Point(6, 21);
            this.calibrateBtn.Name = "calibrateBtn";
            this.calibrateBtn.Size = new System.Drawing.Size(103, 23);
            this.calibrateBtn.TabIndex = 13;
            this.calibrateBtn.Text = "Calibrate";
            this.calibrateBtn.UseVisualStyleBackColor = true;
            this.calibrateBtn.Click += new System.EventHandler(this.calibrateBtn_Click);
            // 
            // calibrateLabel
            // 
            this.calibrateLabel.AutoSize = true;
            this.calibrateLabel.ForeColor = System.Drawing.Color.Red;
            this.calibrateLabel.Location = new System.Drawing.Point(6, 60);
            this.calibrateLabel.Name = "calibrateLabel";
            this.calibrateLabel.Size = new System.Drawing.Size(108, 17);
            this.calibrateLabel.TabIndex = 14;
            this.calibrateLabel.Text = "Not calibrated...";
            // 
            // throttleCal
            // 
            this.throttleCal.AutoSize = true;
            this.throttleCal.ForeColor = System.Drawing.Color.Red;
            this.throttleCal.Location = new System.Drawing.Point(157, 21);
            this.throttleCal.Name = "throttleCal";
            this.throttleCal.Size = new System.Drawing.Size(83, 17);
            this.throttleCal.TabIndex = 17;
            this.throttleCal.Text = "THROTTLE";
            // 
            // pitchCal
            // 
            this.pitchCal.AutoSize = true;
            this.pitchCal.ForeColor = System.Drawing.Color.Red;
            this.pitchCal.Location = new System.Drawing.Point(115, 38);
            this.pitchCal.Name = "pitchCal";
            this.pitchCal.Size = new System.Drawing.Size(48, 17);
            this.pitchCal.TabIndex = 16;
            this.pitchCal.Text = "PITCH";
            // 
            // rollCal
            // 
            this.rollCal.AutoSize = true;
            this.rollCal.ForeColor = System.Drawing.Color.Red;
            this.rollCal.Location = new System.Drawing.Point(115, 21);
            this.rollCal.Name = "rollCal";
            this.rollCal.Size = new System.Drawing.Size(45, 17);
            this.rollCal.TabIndex = 15;
            this.rollCal.Text = "ROLL";
            // 
            // waitingLabel
            // 
            this.waitingLabel.AutoSize = true;
            this.waitingLabel.ForeColor = System.Drawing.Color.Red;
            this.waitingLabel.Location = new System.Drawing.Point(10, 113);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(187, 17);
            this.waitingLabel.TabIndex = 12;
            this.waitingLabel.Text = "Waiting for port to connect...";
            // 
            // yawValueLabel
            // 
            this.yawValueLabel.AutoSize = true;
            this.yawValueLabel.Location = new System.Drawing.Point(167, 83);
            this.yawValueLabel.Name = "yawValueLabel";
            this.yawValueLabel.Size = new System.Drawing.Size(0, 17);
            this.yawValueLabel.TabIndex = 11;
            // 
            // throttleValueLabel
            // 
            this.throttleValueLabel.AutoSize = true;
            this.throttleValueLabel.Location = new System.Drawing.Point(167, 62);
            this.throttleValueLabel.Name = "throttleValueLabel";
            this.throttleValueLabel.Size = new System.Drawing.Size(0, 17);
            this.throttleValueLabel.TabIndex = 10;
            // 
            // pitchValueLabel
            // 
            this.pitchValueLabel.AutoSize = true;
            this.pitchValueLabel.Location = new System.Drawing.Point(167, 42);
            this.pitchValueLabel.Name = "pitchValueLabel";
            this.pitchValueLabel.Size = new System.Drawing.Size(0, 17);
            this.pitchValueLabel.TabIndex = 9;
            // 
            // rollValueLabel
            // 
            this.rollValueLabel.AutoSize = true;
            this.rollValueLabel.Location = new System.Drawing.Point(167, 21);
            this.rollValueLabel.Name = "rollValueLabel";
            this.rollValueLabel.Size = new System.Drawing.Size(0, 17);
            this.rollValueLabel.TabIndex = 8;
            // 
            // roll_progress
            // 
            this.roll_progress.Location = new System.Drawing.Point(60, 21);
            this.roll_progress.Maximum = 2020;
            this.roll_progress.Minimum = 980;
            this.roll_progress.Name = "roll_progress";
            this.roll_progress.Size = new System.Drawing.Size(100, 16);
            this.roll_progress.TabIndex = 7;
            this.roll_progress.Value = 980;
            // 
            // pitch_progress
            // 
            this.pitch_progress.Location = new System.Drawing.Point(60, 43);
            this.pitch_progress.Maximum = 2020;
            this.pitch_progress.Minimum = 980;
            this.pitch_progress.Name = "pitch_progress";
            this.pitch_progress.Size = new System.Drawing.Size(100, 16);
            this.pitch_progress.TabIndex = 6;
            this.pitch_progress.Value = 980;
            // 
            // throttle_progress
            // 
            this.throttle_progress.Location = new System.Drawing.Point(60, 64);
            this.throttle_progress.Maximum = 2020;
            this.throttle_progress.Minimum = 980;
            this.throttle_progress.Name = "throttle_progress";
            this.throttle_progress.Size = new System.Drawing.Size(100, 16);
            this.throttle_progress.TabIndex = 5;
            this.throttle_progress.Value = 980;
            // 
            // yaw_progress
            // 
            this.yaw_progress.Location = new System.Drawing.Point(60, 85);
            this.yaw_progress.Maximum = 2020;
            this.yaw_progress.Minimum = 980;
            this.yaw_progress.Name = "yaw_progress";
            this.yaw_progress.Size = new System.Drawing.Size(100, 16);
            this.yaw_progress.TabIndex = 4;
            this.yaw_progress.Value = 980;
            // 
            // yawLabel
            // 
            this.yawLabel.AutoSize = true;
            this.yawLabel.Location = new System.Drawing.Point(7, 85);
            this.yawLabel.Name = "yawLabel";
            this.yawLabel.Size = new System.Drawing.Size(34, 17);
            this.yawLabel.TabIndex = 3;
            this.yawLabel.Text = "Yaw";
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.Location = new System.Drawing.Point(7, 64);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(57, 17);
            this.throttleLabel.TabIndex = 2;
            this.throttleLabel.Text = "Throttle";
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Location = new System.Drawing.Point(7, 43);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(39, 17);
            this.pitchLabel.TabIndex = 1;
            this.pitchLabel.Text = "Pitch";
            // 
            // rollLabel
            // 
            this.rollLabel.AutoSize = true;
            this.rollLabel.Location = new System.Drawing.Point(7, 22);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(32, 17);
            this.rollLabel.TabIndex = 0;
            this.rollLabel.Text = "Roll";
            // 
            // gpsBrowser
            // 
            this.gpsBrowser.Location = new System.Drawing.Point(278, 13);
            this.gpsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.gpsBrowser.Name = "gpsBrowser";
            this.gpsBrowser.Size = new System.Drawing.Size(549, 389);
            this.gpsBrowser.TabIndex = 2;
            this.gpsBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // gps_groupbox
            // 
            this.gps_groupbox.Controls.Add(this.satellitesValueLabel);
            this.gps_groupbox.Controls.Add(this.satellitePictureBox);
            this.gps_groupbox.Controls.Add(this.lonValueLabel);
            this.gps_groupbox.Controls.Add(this.latValueLabel);
            this.gps_groupbox.Controls.Add(this.lonLabel);
            this.gps_groupbox.Controls.Add(this.latLabel);
            this.gps_groupbox.Controls.Add(this.gpsStatusLabel);
            this.gps_groupbox.Location = new System.Drawing.Point(833, 13);
            this.gps_groupbox.Name = "gps_groupbox";
            this.gps_groupbox.Size = new System.Drawing.Size(200, 130);
            this.gps_groupbox.TabIndex = 0;
            this.gps_groupbox.TabStop = false;
            this.gps_groupbox.Text = "GPS";
            // 
            // satellitesValueLabel
            // 
            this.satellitesValueLabel.AutoSize = true;
            this.satellitesValueLabel.ForeColor = System.Drawing.Color.Red;
            this.satellitesValueLabel.Location = new System.Drawing.Point(45, 87);
            this.satellitesValueLabel.Name = "satellitesValueLabel";
            this.satellitesValueLabel.Size = new System.Drawing.Size(16, 17);
            this.satellitesValueLabel.TabIndex = 7;
            this.satellitesValueLabel.Text = "0";
            // 
            // satellitePictureBox
            // 
            this.satellitePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("satellitePictureBox.Image")));
            this.satellitePictureBox.Location = new System.Drawing.Point(6, 80);
            this.satellitePictureBox.Name = "satellitePictureBox";
            this.satellitePictureBox.Size = new System.Drawing.Size(32, 32);
            this.satellitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.satellitePictureBox.TabIndex = 6;
            this.satellitePictureBox.TabStop = false;
            // 
            // lonValueLabel
            // 
            this.lonValueLabel.AutoSize = true;
            this.lonValueLabel.Location = new System.Drawing.Point(45, 60);
            this.lonValueLabel.Name = "lonValueLabel";
            this.lonValueLabel.Size = new System.Drawing.Size(0, 17);
            this.lonValueLabel.TabIndex = 4;
            // 
            // latValueLabel
            // 
            this.latValueLabel.AutoSize = true;
            this.latValueLabel.Location = new System.Drawing.Point(45, 39);
            this.latValueLabel.Name = "latValueLabel";
            this.latValueLabel.Size = new System.Drawing.Size(0, 17);
            this.latValueLabel.TabIndex = 3;
            // 
            // lonLabel
            // 
            this.lonLabel.AutoSize = true;
            this.lonLabel.Location = new System.Drawing.Point(7, 60);
            this.lonLabel.Name = "lonLabel";
            this.lonLabel.Size = new System.Drawing.Size(36, 17);
            this.lonLabel.TabIndex = 2;
            this.lonLabel.Text = "Lon:";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(7, 39);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(32, 17);
            this.latLabel.TabIndex = 1;
            this.latLabel.Text = "Lat:";
            // 
            // gpsStatusLabel
            // 
            this.gpsStatusLabel.AutoSize = true;
            this.gpsStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.gpsStatusLabel.Location = new System.Drawing.Point(6, 18);
            this.gpsStatusLabel.Name = "gpsStatusLabel";
            this.gpsStatusLabel.Size = new System.Drawing.Size(62, 17);
            this.gpsStatusLabel.TabIndex = 0;
            this.gpsStatusLabel.Text = "NO GPS";
            // 
            // gyro_groupbox
            // 
            this.gyro_groupbox.Controls.Add(this.gyroValueLabel);
            this.gyro_groupbox.Controls.Add(this.zValueLabel);
            this.gyro_groupbox.Controls.Add(this.yValueLabel);
            this.gyro_groupbox.Controls.Add(this.xValueLabel);
            this.gyro_groupbox.Controls.Add(this.zLabel);
            this.gyro_groupbox.Controls.Add(this.yLabel);
            this.gyro_groupbox.Controls.Add(this.xLabel);
            this.gyro_groupbox.Location = new System.Drawing.Point(834, 150);
            this.gyro_groupbox.Name = "gyro_groupbox";
            this.gyro_groupbox.Size = new System.Drawing.Size(200, 112);
            this.gyro_groupbox.TabIndex = 3;
            this.gyro_groupbox.TabStop = false;
            this.gyro_groupbox.Text = "Gyro";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(7, 22);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(21, 17);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(7, 43);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(21, 17);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "Y:";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(7, 64);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(21, 17);
            this.zLabel.TabIndex = 2;
            this.zLabel.Text = "Z:";
            // 
            // xValueLabel
            // 
            this.xValueLabel.AutoSize = true;
            this.xValueLabel.Location = new System.Drawing.Point(34, 22);
            this.xValueLabel.Name = "xValueLabel";
            this.xValueLabel.Size = new System.Drawing.Size(46, 17);
            this.xValueLabel.TabIndex = 3;
            this.xValueLabel.Text = "label1";
            // 
            // yValueLabel
            // 
            this.yValueLabel.AutoSize = true;
            this.yValueLabel.Location = new System.Drawing.Point(35, 42);
            this.yValueLabel.Name = "yValueLabel";
            this.yValueLabel.Size = new System.Drawing.Size(46, 17);
            this.yValueLabel.TabIndex = 4;
            this.yValueLabel.Text = "label2";
            // 
            // zValueLabel
            // 
            this.zValueLabel.AutoSize = true;
            this.zValueLabel.Location = new System.Drawing.Point(35, 63);
            this.zValueLabel.Name = "zValueLabel";
            this.zValueLabel.Size = new System.Drawing.Size(46, 17);
            this.zValueLabel.TabIndex = 5;
            this.zValueLabel.Text = "label3";
            // 
            // gyroValueLabel
            // 
            this.gyroValueLabel.AutoSize = true;
            this.gyroValueLabel.ForeColor = System.Drawing.Color.Red;
            this.gyroValueLabel.Location = new System.Drawing.Point(7, 87);
            this.gyroValueLabel.Name = "gyroValueLabel";
            this.gyroValueLabel.Size = new System.Drawing.Size(117, 17);
            this.gyroValueLabel.TabIndex = 6;
            this.gyroValueLabel.Text = "No gyro detected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 417);
            this.Controls.Add(this.gyro_groupbox);
            this.Controls.Add(this.gps_groupbox);
            this.Controls.Add(this.gpsBrowser);
            this.Controls.Add(this.radio_groupbox);
            this.Controls.Add(this.serial_groupbox);
            this.Name = "Form1";
            this.Text = "FlightMonitor by Spulber George";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.serial_groupbox.ResumeLayout(false);
            this.serial_groupbox.PerformLayout();
            this.radio_groupbox.ResumeLayout(false);
            this.radio_groupbox.PerformLayout();
            this.calibrateRadio_groupbox.ResumeLayout(false);
            this.calibrateRadio_groupbox.PerformLayout();
            this.gps_groupbox.ResumeLayout(false);
            this.gps_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satellitePictureBox)).EndInit();
            this.gyro_groupbox.ResumeLayout(false);
            this.gyro_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serial_groupbox;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.Label comLabel;
        private System.Windows.Forms.ComboBox baud_cBox;
        private System.Windows.Forms.ComboBox com_cBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label serialStatusLabel;
        private System.Windows.Forms.GroupBox radio_groupbox;
        private System.Windows.Forms.ProgressBar roll_progress;
        private System.Windows.Forms.ProgressBar pitch_progress;
        private System.Windows.Forms.ProgressBar throttle_progress;
        private System.Windows.Forms.ProgressBar yaw_progress;
        private System.Windows.Forms.Label yawLabel;
        private System.Windows.Forms.Label throttleLabel;
        private System.Windows.Forms.Label pitchLabel;
        private System.Windows.Forms.Label rollLabel;
        private System.Windows.Forms.Label yawValueLabel;
        private System.Windows.Forms.Label throttleValueLabel;
        private System.Windows.Forms.Label pitchValueLabel;
        private System.Windows.Forms.Label rollValueLabel;
        private System.Windows.Forms.Label waitingLabel;
        private System.Windows.Forms.Label yawCal;
        private System.Windows.Forms.Label throttleCal;
        private System.Windows.Forms.Label pitchCal;
        private System.Windows.Forms.Label rollCal;
        private System.Windows.Forms.Label calibrateLabel;
        private System.Windows.Forms.Button calibrateBtn;
        private System.Windows.Forms.GroupBox calibrateRadio_groupbox;
        private System.Windows.Forms.Label calibrateLabel2;
        private System.Windows.Forms.WebBrowser gpsBrowser;
        private System.Windows.Forms.GroupBox gps_groupbox;
        private System.Windows.Forms.Label gpsStatusLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lonLabel;
        private System.Windows.Forms.Label lonValueLabel;
        private System.Windows.Forms.Label latValueLabel;
        private System.Windows.Forms.PictureBox satellitePictureBox;
        private System.Windows.Forms.Label satellitesValueLabel;
        private System.Windows.Forms.GroupBox gyro_groupbox;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label zValueLabel;
        private System.Windows.Forms.Label yValueLabel;
        private System.Windows.Forms.Label xValueLabel;
        private System.Windows.Forms.Label gyroValueLabel;
    }
}

