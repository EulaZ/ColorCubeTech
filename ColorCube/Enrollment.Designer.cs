namespace ColorCube
{
    partial class Enrollment
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
            this.labID = new System.Windows.Forms.Label();
            this.labkey = new System.Windows.Forms.Label();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Keybox = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.BackColor = System.Drawing.Color.Transparent;
            this.labID.Font = new System.Drawing.Font("Tempus Sans ITC", 18F);
            this.labID.Location = new System.Drawing.Point(348, 245);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(167, 39);
            this.labID.TabIndex = 0;
            this.labID.Text = "UserName: ";
            // 
            // labkey
            // 
            this.labkey.AutoSize = true;
            this.labkey.BackColor = System.Drawing.Color.Transparent;
            this.labkey.Font = new System.Drawing.Font("Tempus Sans ITC", 18F);
            this.labkey.Location = new System.Drawing.Point(350, 323);
            this.labkey.Name = "labkey";
            this.labkey.Size = new System.Drawing.Size(147, 39);
            this.labkey.TabIndex = 1;
            this.labkey.Text = "Password: ";
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Namebox.Location = new System.Drawing.Point(524, 247);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(224, 34);
            this.Namebox.TabIndex = 2;
            // 
            // Keybox
            // 
            this.Keybox.Font = new System.Drawing.Font("宋体", 13.8F);
            this.Keybox.Location = new System.Drawing.Point(524, 329);
            this.Keybox.Name = "Keybox";
            this.Keybox.PasswordChar = '*';
            this.Keybox.Size = new System.Drawing.Size(224, 34);
            this.Keybox.TabIndex = 3;
            this.Keybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keybox_KeyPress);
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.Transparent;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.FlatAppearance.BorderSize = 0;
            this.btnsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.btnsignup.Location = new System.Drawing.Point(308, 493);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(207, 52);
            this.btnsignup.TabIndex = 4;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            this.btnsignup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keybox_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.btnReturn.Location = new System.Drawing.Point(640, 493);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(210, 52);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Enrollment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Enrollment;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.Keybox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.labkey);
            this.Controls.Add(this.labID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labkey;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox Keybox;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button btnReturn;
    }
}