using System.Web.UI.WebControls;

namespace ColorCube
{
    partial class Usagepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usagepage));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.Exit2 = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.labTime = new System.Windows.Forms.Label();
            this.labLED = new System.Windows.Forms.Label();
            this.labLevel = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.Levelchoice = new System.Windows.Forms.ComboBox();
            this.labNumber = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureLED = new System.Windows.Forms.PictureBox();
            this.tmLED = new System.Windows.Forms.Timer(this.components);
            this.ImlistLED = new System.Windows.Forms.ImageList(this.components);
            this.labDistance = new System.Windows.Forms.Label();
            this.DistanceBox = new System.Windows.Forms.TextBox();
            this.labUnit = new System.Windows.Forms.Label();
            this.labRcvM = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLED)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(903, 205);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(193, 59);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Game  Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuide.Location = new System.Drawing.Point(903, 68);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(193, 55);
            this.btnGuide.TabIndex = 5;
            this.btnGuide.Text = "Game  Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // Exit2
            // 
            this.Exit2.BackColor = System.Drawing.Color.Transparent;
            this.Exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit2.FlatAppearance.BorderSize = 0;
            this.Exit2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit2.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit2.Location = new System.Drawing.Point(901, 498);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(199, 56);
            this.Exit2.TabIndex = 6;
            this.Exit2.Text = "Return to Home";
            this.Exit2.UseVisualStyleBackColor = false;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.BackColor = System.Drawing.Color.Transparent;
            this.labScore.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(232, 143);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(241, 34);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Scores Obtained";
            // 
            // TimeBox
            // 
            this.TimeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeBox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.TimeBox.Location = new System.Drawing.Point(324, 462);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(94, 30);
            this.TimeBox.TabIndex = 9;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(319, 414);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(168, 28);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "Lasting Time: ";
            // 
            // labLED
            // 
            this.labLED.AutoSize = true;
            this.labLED.BackColor = System.Drawing.Color.Transparent;
            this.labLED.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLED.Location = new System.Drawing.Point(66, 414);
            this.labLED.Name = "labLED";
            this.labLED.Size = new System.Drawing.Size(224, 28);
            this.labLED.TabIndex = 1;
            this.labLED.Text = "Current LED color: ";
            // 
            // labLevel
            // 
            this.labLevel.AutoSize = true;
            this.labLevel.BackColor = System.Drawing.Color.Transparent;
            this.labLevel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLevel.Location = new System.Drawing.Point(64, 297);
            this.labLevel.Name = "labLevel";
            this.labLevel.Size = new System.Drawing.Size(327, 34);
            this.labLevel.TabIndex = 0;
            this.labLevel.Text = "Current difficulty level: ";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(899, 350);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(193, 58);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "Game  Over";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Levelchoice
            // 
            this.Levelchoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Levelchoice.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Levelchoice.FormattingEnabled = true;
            this.Levelchoice.Location = new System.Drawing.Point(71, 342);
            this.Levelchoice.Name = "Levelchoice";
            this.Levelchoice.Size = new System.Drawing.Size(207, 29);
            this.Levelchoice.TabIndex = 13;
            this.Levelchoice.SelectedValueChanged += new System.EventHandler(this.Levelchoice_SelectedValueChanged);
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.BackColor = System.Drawing.Color.Transparent;
            this.labNumber.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber.Location = new System.Drawing.Point(520, 124);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(64, 66);
            this.labNumber.TabIndex = 14;
            this.labNumber.Text = "0";
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(515, 462);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(127, 48);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(705, 462);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(127, 48);
            this.btnRight.TabIndex = 16;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(614, 350);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(117, 106);
            this.btnForward.TabIndex = 17;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(621, 516);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 121);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureLED
            // 
            this.pictureLED.BackColor = System.Drawing.Color.Transparent;
            this.pictureLED.Location = new System.Drawing.Point(71, 448);
            this.pictureLED.Name = "pictureLED";
            this.pictureLED.Size = new System.Drawing.Size(184, 175);
            this.pictureLED.TabIndex = 19;
            this.pictureLED.TabStop = false;
            // 
            // ImlistLED
            // 
            this.ImlistLED.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlistLED.ImageStream")));
            this.ImlistLED.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlistLED.Images.SetKeyName(0, "RedLED.jpg");
            this.ImlistLED.Images.SetKeyName(1, "GreenLED.jpg");
            this.ImlistLED.Images.SetKeyName(2, "BlueLED.jpg");
            this.ImlistLED.Images.SetKeyName(3, "YellowLED.jpg");
            this.ImlistLED.Images.SetKeyName(4, "PurpleLED.jpg");
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.BackColor = System.Drawing.Color.Transparent;
            this.labDistance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDistance.Location = new System.Drawing.Point(319, 512);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(127, 28);
            this.labDistance.TabIndex = 20;
            this.labDistance.Text = "Distance: ";
            // 
            // DistanceBox
            // 
            this.DistanceBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DistanceBox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.DistanceBox.Location = new System.Drawing.Point(324, 560);
            this.DistanceBox.Name = "DistanceBox";
            this.DistanceBox.ReadOnly = true;
            this.DistanceBox.Size = new System.Drawing.Size(144, 30);
            this.DistanceBox.TabIndex = 21;
            // 
            // labUnit
            // 
            this.labUnit.AutoSize = true;
            this.labUnit.BackColor = System.Drawing.Color.Transparent;
            this.labUnit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUnit.Location = new System.Drawing.Point(424, 469);
            this.labUnit.Name = "labUnit";
            this.labUnit.Size = new System.Drawing.Size(44, 23);
            this.labUnit.TabIndex = 22;
            this.labUnit.Text = "Sec";
            // 
            // labRcvM
            // 
            this.labRcvM.AutoSize = true;
            this.labRcvM.BackColor = System.Drawing.Color.Transparent;
            this.labRcvM.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRcvM.Location = new System.Drawing.Point(898, 285);
            this.labRcvM.Name = "labRcvM";
            this.labRcvM.Size = new System.Drawing.Size(234, 28);
            this.labRcvM.TabIndex = 23;
            this.labRcvM.Text = "Received Message";
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.Tomato;
            this.btnPush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPush.FlatAppearance.BorderSize = 0;
            this.btnPush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnPush.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(624, 285);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(101, 52);
            this.btnPush.TabIndex = 24;
            this.btnPush.Text = "Push !";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // Usagepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Userpage3;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.labRcvM);
            this.Controls.Add(this.labUnit);
            this.Controls.Add(this.DistanceBox);
            this.Controls.Add(this.labDistance);
            this.Controls.Add(this.pictureLED);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.Levelchoice);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Exit2);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labLED);
            this.Controls.Add(this.labLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Usagepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorCube Technology";
            this.Load += new System.EventHandler(this.Usagepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labLED;
        private System.Windows.Forms.Label labLevel;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ComboBox Levelchoice;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureLED;
        private System.Windows.Forms.Timer tmLED;
        private System.Windows.Forms.ImageList ImlistLED;
        private System.Windows.Forms.Label labDistance;
        private System.Windows.Forms.TextBox DistanceBox;
        private System.Windows.Forms.Label labUnit;
        private System.Windows.Forms.Label labRcvM;
        private System.Windows.Forms.Button btnPush;
    }
}