namespace ColorCube
{
    partial class Guidance
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
            this.GuideBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GuideBox
            // 
            this.GuideBox.BackColor = System.Drawing.SystemColors.Info;
            this.GuideBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GuideBox.Location = new System.Drawing.Point(90, 55);
            this.GuideBox.Name = "GuideBox";
            this.GuideBox.ReadOnly = true;
            this.GuideBox.Size = new System.Drawing.Size(950, 116);
            this.GuideBox.TabIndex = 0;
            this.GuideBox.Text = "";
            // 
            // Guidance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.Registerpage;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.GuideBox);
            this.Name = "Guidance";
            this.Text = "Guidance";
            this.Load += new System.EventHandler(this.Guidance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox GuideBox;
    }
}