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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.Exit2 = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.Timebox = new System.Windows.Forms.TextBox();
            this.labTime = new System.Windows.Forms.Label();
            this.LEDbox = new System.Windows.Forms.TextBox();
            this.labLED = new System.Windows.Forms.Label();
            this.labLevel = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tmSend = new System.Windows.Forms.Timer(this.components);
            this.Levelchoice = new System.Windows.Forms.ComboBox();
            this.labNumber = new System.Windows.Forms.Label();
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
            this.btnStart.Location = new System.Drawing.Point(888, 205);
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
            this.btnGuide.Location = new System.Drawing.Point(888, 68);
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
            this.Exit2.Location = new System.Drawing.Point(888, 491);
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
            this.labScore.Location = new System.Drawing.Point(206, 143);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(241, 34);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Scores Obtained";
            // 
            // Timebox
            // 
            this.Timebox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Timebox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.Timebox.Location = new System.Drawing.Point(71, 536);
            this.Timebox.Name = "Timebox";
            this.Timebox.ReadOnly = true;
            this.Timebox.Size = new System.Drawing.Size(121, 30);
            this.Timebox.TabIndex = 9;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(65, 505);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(168, 28);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "Lasting Time: ";
            // 
            // LEDbox
            // 
            this.LEDbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LEDbox.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.LEDbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LEDbox.Location = new System.Drawing.Point(71, 445);
            this.LEDbox.Name = "LEDbox";
            this.LEDbox.ReadOnly = true;
            this.LEDbox.Size = new System.Drawing.Size(122, 30);
            this.LEDbox.TabIndex = 8;
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
            this.btnEnd.Location = new System.Drawing.Point(888, 348);
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
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.BackColor = System.Drawing.Color.Transparent;
            this.labNumber.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber.Location = new System.Drawing.Point(503, 124);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(64, 66);
            this.labNumber.TabIndex = 14;
            this.labNumber.Text = "0";
            // 
            // Usagepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Userpage;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.Levelchoice);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.Timebox);
            this.Controls.Add(this.LEDbox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.TextBox Timebox;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.TextBox LEDbox;
        private System.Windows.Forms.Label labLED;
        private System.Windows.Forms.Label labLevel;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer tmSend;
        private System.Windows.Forms.ComboBox Levelchoice;
        private System.Windows.Forms.Label labNumber;
    }
}