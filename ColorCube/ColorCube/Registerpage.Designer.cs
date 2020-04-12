namespace ColorCube
{
    partial class Registerpage
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
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.labSerialsName = new System.Windows.Forms.Label();
            this.labSet = new System.Windows.Forms.Label();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.ReceivedBox = new System.Windows.Forms.TextBox();
            this.labReceived = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.TdelayBox = new System.Windows.Forms.TextBox();
            this.labTime = new System.Windows.Forms.Label();
            this.labAuto = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labBaud = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.labDatabits = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.labStopBits = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.labParity = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.TimeCheck = new System.Windows.Forms.CheckBox();
            this.tmSend = new System.Windows.Forms.Timer(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labReqdata = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.btnInitial = new System.Windows.Forms.Button();
            this.labUnit = new System.Windows.Forms.Label();
            this.rdsentHex = new System.Windows.Forms.RadioButton();
            this.rdsentStr = new System.Windows.Forms.RadioButton();
            this.rdrcvHex = new System.Windows.Forms.RadioButton();
            this.rdrcvStr = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryBox
            // 
            this.HistoryBox.BackColor = System.Drawing.Color.Cornsilk;
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HistoryBox.Location = new System.Drawing.Point(857, 80);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.ReadOnly = true;
            this.HistoryBox.Size = new System.Drawing.Size(276, 367);
            this.HistoryBox.TabIndex = 0;
            // 
            // labSerialsName
            // 
            this.labSerialsName.AutoSize = true;
            this.labSerialsName.BackColor = System.Drawing.Color.Transparent;
            this.labSerialsName.Location = new System.Drawing.Point(-125, 39);
            this.labSerialsName.Name = "labSerialsName";
            this.labSerialsName.Size = new System.Drawing.Size(55, 15);
            this.labSerialsName.TabIndex = 2;
            this.labSerialsName.Text = "label1";
            // 
            // labSet
            // 
            this.labSet.AutoSize = true;
            this.labSet.BackColor = System.Drawing.Color.Transparent;
            this.labSet.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSet.Location = new System.Drawing.Point(25, 24);
            this.labSet.Name = "labSet";
            this.labSet.Size = new System.Drawing.Size(239, 36);
            this.labSet.TabIndex = 3;
            this.labSet.Text = "Serials Port Setting";
            // 
            // cbSerial
            // 
            this.cbSerial.BackColor = System.Drawing.SystemColors.Window;
            this.cbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerial.Font = new System.Drawing.Font("Century", 12F);
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(30, 112);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(121, 31);
            this.cbSerial.TabIndex = 4;
            // 
            // ReceivedBox
            // 
            this.ReceivedBox.AcceptsReturn = true;
            this.ReceivedBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReceivedBox.Location = new System.Drawing.Point(404, 155);
            this.ReceivedBox.Multiline = true;
            this.ReceivedBox.Name = "ReceivedBox";
            this.ReceivedBox.ReadOnly = true;
            this.ReceivedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedBox.Size = new System.Drawing.Size(294, 438);
            this.ReceivedBox.TabIndex = 5;
            // 
            // labReceived
            // 
            this.labReceived.AutoSize = true;
            this.labReceived.BackColor = System.Drawing.Color.Transparent;
            this.labReceived.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReceived.Location = new System.Drawing.Point(398, 48);
            this.labReceived.Name = "labReceived";
            this.labReceived.Size = new System.Drawing.Size(243, 36);
            this.labReceived.TabIndex = 7;
            this.labReceived.Text = "Received Message: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(-359, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(-343, -137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Wheat;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSend.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(223, 569);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 44);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Wheat;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(748, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Wheat;
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSwitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSwitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSwitch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(189, 95);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(170, 48);
            this.btnSwitch.TabIndex = 12;
            this.btnSwitch.Text = "Open serial port";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // TdelayBox
            // 
            this.TdelayBox.Font = new System.Drawing.Font("Century", 12F);
            this.TdelayBox.Location = new System.Drawing.Point(188, 460);
            this.TdelayBox.Name = "TdelayBox";
            this.TdelayBox.Size = new System.Drawing.Size(116, 32);
            this.TdelayBox.TabIndex = 15;
            this.TdelayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TdelayBox_KeyPress);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(28, 463);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(129, 29);
            this.labTime.TabIndex = 16;
            this.labTime.Text = "Time delay: ";
            // 
            // labAuto
            // 
            this.labAuto.AutoSize = true;
            this.labAuto.BackColor = System.Drawing.Color.Transparent;
            this.labAuto.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuto.Location = new System.Drawing.Point(24, 304);
            this.labAuto.Name = "labAuto";
            this.labAuto.Size = new System.Drawing.Size(323, 36);
            this.labAuto.TabIndex = 17;
            this.labAuto.Text = "Automatically Sent Setting";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(26, 80);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(123, 29);
            this.labName.TabIndex = 19;
            this.labName.Text = "Port name: ";
            // 
            // labBaud
            // 
            this.labBaud.AutoSize = true;
            this.labBaud.BackColor = System.Drawing.Color.Transparent;
            this.labBaud.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBaud.Location = new System.Drawing.Point(26, 155);
            this.labBaud.Name = "labBaud";
            this.labBaud.Size = new System.Drawing.Size(118, 29);
            this.labBaud.TabIndex = 20;
            this.labBaud.Text = "Baud rate: ";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.BackColor = System.Drawing.SystemColors.Window;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("Century", 12F);
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(30, 187);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 31);
            this.cbBaudRate.TabIndex = 21;
            // 
            // labDatabits
            // 
            this.labDatabits.AutoSize = true;
            this.labDatabits.BackColor = System.Drawing.Color.Transparent;
            this.labDatabits.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDatabits.Location = new System.Drawing.Point(212, 155);
            this.labDatabits.Name = "labDatabits";
            this.labDatabits.Size = new System.Drawing.Size(110, 29);
            this.labDatabits.TabIndex = 22;
            this.labDatabits.Text = "Data bits: ";
            // 
            // cbDataBits
            // 
            this.cbDataBits.BackColor = System.Drawing.SystemColors.Window;
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("Century", 12F);
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(217, 187);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 31);
            this.cbDataBits.TabIndex = 23;
            // 
            // labStopBits
            // 
            this.labStopBits.AutoSize = true;
            this.labStopBits.BackColor = System.Drawing.Color.Transparent;
            this.labStopBits.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStopBits.Location = new System.Drawing.Point(26, 221);
            this.labStopBits.Name = "labStopBits";
            this.labStopBits.Size = new System.Drawing.Size(108, 29);
            this.labStopBits.TabIndex = 24;
            this.labStopBits.Text = "Stop bits: ";
            // 
            // cbStop
            // 
            this.cbStop.BackColor = System.Drawing.SystemColors.Window;
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.Font = new System.Drawing.Font("Century", 12F);
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(30, 255);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 31);
            this.cbStop.TabIndex = 25;
            // 
            // labParity
            // 
            this.labParity.AutoSize = true;
            this.labParity.BackColor = System.Drawing.Color.Transparent;
            this.labParity.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labParity.Location = new System.Drawing.Point(215, 221);
            this.labParity.Name = "labParity";
            this.labParity.Size = new System.Drawing.Size(123, 29);
            this.labParity.TabIndex = 26;
            this.labParity.Text = "Parity bits: ";
            // 
            // cbParity
            // 
            this.cbParity.BackColor = System.Drawing.SystemColors.Window;
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("Century", 12F);
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(220, 255);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 31);
            this.cbParity.TabIndex = 27;
            // 
            // TimeCheck
            // 
            this.TimeCheck.AutoSize = true;
            this.TimeCheck.BackColor = System.Drawing.Color.Transparent;
            this.TimeCheck.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.TimeCheck.Location = new System.Drawing.Point(33, 421);
            this.TimeCheck.Name = "TimeCheck";
            this.TimeCheck.Size = new System.Drawing.Size(171, 33);
            this.TimeCheck.TabIndex = 28;
            this.TimeCheck.Text = "Regularly Sent";
            this.TimeCheck.UseVisualStyleBackColor = false;
            // 
            // tmSend
            // 
            this.tmSend.Tick += new System.EventHandler(this.tmSend_Tick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Wheat;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReturn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(953, 559);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 44);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 26);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(407, 20);
            this.toolStripStatusLabel1.Text = "Development board model: MBED NXP LPC1768; FPGA";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(184, 20);
            this.toolStripStatusLabel3.Text = "Color Sensor: TSC34725";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(187, 20);
            this.toolStripStatusLabel5.Text = "Distance Sensor: VL6180";
            // 
            // labReqdata
            // 
            this.labReqdata.AutoSize = true;
            this.labReqdata.BackColor = System.Drawing.Color.Transparent;
            this.labReqdata.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labReqdata.Location = new System.Drawing.Point(28, 499);
            this.labReqdata.Name = "labReqdata";
            this.labReqdata.Size = new System.Drawing.Size(159, 29);
            this.labReqdata.TabIndex = 31;
            this.labReqdata.Text = "Required Data: ";
            // 
            // DataBox
            // 
            this.DataBox.Font = new System.Drawing.Font("Century", 12F);
            this.DataBox.Location = new System.Drawing.Point(30, 531);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(315, 32);
            this.DataBox.TabIndex = 32;
            this.DataBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataBox_KeyPress);
            // 
            // btnInitial
            // 
            this.btnInitial.BackColor = System.Drawing.Color.Wheat;
            this.btnInitial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInitial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInitial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInitial.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitial.Location = new System.Drawing.Point(953, 486);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(180, 43);
            this.btnInitial.TabIndex = 33;
            this.btnInitial.Text = "Initialize";
            this.btnInitial.UseVisualStyleBackColor = false;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // labUnit
            // 
            this.labUnit.AutoSize = true;
            this.labUnit.BackColor = System.Drawing.Color.Transparent;
            this.labUnit.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUnit.Location = new System.Drawing.Point(310, 462);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(50, 29);
            this.labUnit.TabIndex = 34;
            this.labUnit.Text = "Sec ";
            // 
            // rdsentHex
            // 
            this.rdsentHex.AutoSize = true;
            this.rdsentHex.BackColor = System.Drawing.Color.Transparent;
            this.rdsentHex.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.rdsentHex.Location = new System.Drawing.Point(17, 19);
            this.rdsentHex.Name = "rdsentHex";
            this.rdsentHex.Size = new System.Drawing.Size(121, 33);
            this.rdsentHex.TabIndex = 35;
            this.rdsentHex.TabStop = true;
            this.rdsentHex.Text = "Hex form";
            this.rdsentHex.UseVisualStyleBackColor = false;
            // 
            // rdsentStr
            // 
            this.rdsentStr.AutoSize = true;
            this.rdsentStr.BackColor = System.Drawing.Color.Transparent;
            this.rdsentStr.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.rdsentStr.Location = new System.Drawing.Point(162, 19);
            this.rdsentStr.Name = "rdsentStr";
            this.rdsentStr.Size = new System.Drawing.Size(142, 33);
            this.rdsentStr.TabIndex = 36;
            this.rdsentStr.TabStop = true;
            this.rdsentStr.Text = "String form";
            this.rdsentStr.UseVisualStyleBackColor = false;
            // 
            // rdrcvHex
            // 
            this.rdrcvHex.AutoSize = true;
            this.rdrcvHex.BackColor = System.Drawing.Color.Transparent;
            this.rdrcvHex.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.rdrcvHex.Location = new System.Drawing.Point(24, 15);
            this.rdrcvHex.Name = "rdrcvHex";
            this.rdrcvHex.Size = new System.Drawing.Size(121, 33);
            this.rdrcvHex.TabIndex = 37;
            this.rdrcvHex.TabStop = true;
            this.rdrcvHex.Text = "Hex form";
            this.rdrcvHex.UseVisualStyleBackColor = false;
            // 
            // rdrcvStr
            // 
            this.rdrcvStr.AutoSize = true;
            this.rdrcvStr.BackColor = System.Drawing.Color.Transparent;
            this.rdrcvStr.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.rdrcvStr.Location = new System.Drawing.Point(151, 15);
            this.rdrcvStr.Name = "rdrcvStr";
            this.rdrcvStr.Size = new System.Drawing.Size(142, 33);
            this.rdrcvStr.TabIndex = 38;
            this.rdrcvStr.TabStop = true;
            this.rdrcvStr.Text = "String form";
            this.rdrcvStr.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdsentStr);
            this.groupBox1.Controls.Add(this.rdsentHex);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(30, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 52);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdrcvStr);
            this.groupBox2.Controls.Add(this.rdrcvHex);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(404, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 51);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choice";
            // 
            // Registerpage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Registerpage;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.labUnit);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.labReqdata);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.TimeCheck);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.labParity);
            this.Controls.Add(this.cbStop);
            this.Controls.Add(this.labStopBits);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.labDatabits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.labBaud);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labAuto);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.TdelayBox);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labReceived);
            this.Controls.Add(this.ReceivedBox);
            this.Controls.Add(this.cbSerial);
            this.Controls.Add(this.labSet);
            this.Controls.Add(this.labSerialsName);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registerpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorCube Technology";
            this.Load += new System.EventHandler(this.Registerpage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.Label labSerialsName;
        private System.Windows.Forms.Label labSet;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.TextBox ReceivedBox;
        private System.Windows.Forms.Label labReceived;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox TdelayBox;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labAuto;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labBaud;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label labDatabits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label labStopBits;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label labParity;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.CheckBox TimeCheck;
        private System.Windows.Forms.Timer tmSend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Label labReqdata;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Label labUnit;
        private System.Windows.Forms.RadioButton rdsentHex;
        private System.Windows.Forms.RadioButton rdsentStr;
        private System.Windows.Forms.RadioButton rdrcvHex;
        private System.Windows.Forms.RadioButton rdrcvStr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}