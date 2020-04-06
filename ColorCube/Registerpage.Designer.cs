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
            this.SendBox = new System.Windows.Forms.TextBox();
            this.labSerialsName = new System.Windows.Forms.Label();
            this.labSet = new System.Windows.Forms.Label();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.ReceivedBox = new System.Windows.Forms.TextBox();
            this.labSend = new System.Windows.Forms.Label();
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
            this.Databox = new System.Windows.Forms.TextBox();
            this.btnInitial = new System.Windows.Forms.Button();
            this.labUnit = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
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
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(404, 414);
            this.SendBox.Multiline = true;
            this.SendBox.Name = "SendBox";
            this.SendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendBox.Size = new System.Drawing.Size(357, 189);
            this.SendBox.TabIndex = 1;
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
            this.cbSerial.SelectedIndexChanged += new System.EventHandler(this.cbSerial_SelectedIndexChanged);
            // 
            // ReceivedBox
            // 
            this.ReceivedBox.AcceptsReturn = true;
            this.ReceivedBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReceivedBox.Location = new System.Drawing.Point(404, 87);
            this.ReceivedBox.Multiline = true;
            this.ReceivedBox.Name = "ReceivedBox";
            this.ReceivedBox.ReadOnly = true;
            this.ReceivedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedBox.Size = new System.Drawing.Size(357, 229);
            this.ReceivedBox.TabIndex = 5;
            this.ReceivedBox.TextChanged += new System.EventHandler(this.ReceivedBox_TextChanged);
            // 
            // labSend
            // 
            this.labSend.AutoSize = true;
            this.labSend.BackColor = System.Drawing.Color.Transparent;
            this.labSend.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSend.Location = new System.Drawing.Point(398, 375);
            this.labSend.Name = "labSend";
            this.labSend.Size = new System.Drawing.Size(195, 36);
            this.labSend.TabIndex = 6;
            this.labSend.Text = "Send Message: ";
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
            this.btnSend.Location = new System.Drawing.Point(217, 485);
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
            this.btnClear.Location = new System.Drawing.Point(636, 322);
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
            this.TdelayBox.Location = new System.Drawing.Point(30, 493);
            this.TdelayBox.Name = "TdelayBox";
            this.TdelayBox.Size = new System.Drawing.Size(100, 32);
            this.TdelayBox.TabIndex = 15;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(25, 461);
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
            this.labAuto.Location = new System.Drawing.Point(25, 362);
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
            this.labBaud.Location = new System.Drawing.Point(28, 170);
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
            this.cbBaudRate.Location = new System.Drawing.Point(31, 207);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 31);
            this.cbBaudRate.TabIndex = 21;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // labDatabits
            // 
            this.labDatabits.AutoSize = true;
            this.labDatabits.BackColor = System.Drawing.Color.Transparent;
            this.labDatabits.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDatabits.Location = new System.Drawing.Point(212, 170);
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
            this.cbDataBits.Location = new System.Drawing.Point(217, 207);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 31);
            this.cbDataBits.TabIndex = 23;
            this.cbDataBits.SelectedIndexChanged += new System.EventHandler(this.cbDataBits_SelectedIndexChanged);
            // 
            // labStopBits
            // 
            this.labStopBits.AutoSize = true;
            this.labStopBits.BackColor = System.Drawing.Color.Transparent;
            this.labStopBits.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStopBits.Location = new System.Drawing.Point(26, 257);
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
            this.cbStop.Location = new System.Drawing.Point(31, 289);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 31);
            this.cbStop.TabIndex = 25;
            // 
            // labParity
            // 
            this.labParity.AutoSize = true;
            this.labParity.BackColor = System.Drawing.Color.Transparent;
            this.labParity.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labParity.Location = new System.Drawing.Point(212, 257);
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
            this.cbParity.Location = new System.Drawing.Point(217, 289);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 31);
            this.cbParity.TabIndex = 27;
            // 
            // TimeCheck
            // 
            this.TimeCheck.AutoSize = true;
            this.TimeCheck.BackColor = System.Drawing.Color.Transparent;
            this.TimeCheck.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.TimeCheck.Location = new System.Drawing.Point(33, 414);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 25);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            this.labReqdata.Location = new System.Drawing.Point(28, 540);
            this.labReqdata.Name = "labReqdata";
            this.labReqdata.Size = new System.Drawing.Size(159, 29);
            this.labReqdata.TabIndex = 31;
            this.labReqdata.Text = "Required Data: ";
            // 
            // Databox
            // 
            this.Databox.Font = new System.Drawing.Font("Century", 12F);
            this.Databox.Location = new System.Drawing.Point(33, 572);
            this.Databox.Name = "Databox";
            this.Databox.Size = new System.Drawing.Size(315, 32);
            this.Databox.TabIndex = 32;
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
            this.labUnit.Location = new System.Drawing.Point(136, 496);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(50, 29);
            this.labUnit.TabIndex = 34;
            this.labUnit.Text = "Sec ";
            // 
            // Registerpage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Registerpage;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.labUnit);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.Databox);
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
            this.Controls.Add(this.labSend);
            this.Controls.Add(this.ReceivedBox);
            this.Controls.Add(this.cbSerial);
            this.Controls.Add(this.labSet);
            this.Controls.Add(this.labSerialsName);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.HistoryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registerpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorCube Technology";
            this.Load += new System.EventHandler(this.Registerpage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.Label labSerialsName;
        private System.Windows.Forms.Label labSet;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.TextBox ReceivedBox;
        private System.Windows.Forms.Label labSend;
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
        private System.Windows.Forms.TextBox Databox;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Label labUnit;
    }
}