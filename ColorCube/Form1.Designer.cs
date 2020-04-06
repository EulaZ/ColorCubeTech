namespace ColorCube
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UserEnter = new System.Windows.Forms.Button();
            this.RegisterEnter = new System.Windows.Forms.Button();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Option = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tag.png");
            this.imageList1.Images.SetKeyName(1, "tag.zooming.png");
            // 
            // UserEnter
            // 
            this.UserEnter.BackColor = System.Drawing.Color.Transparent;
            this.UserEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserEnter.FlatAppearance.BorderSize = 0;
            this.UserEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UserEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UserEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserEnter.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEnter.Location = new System.Drawing.Point(878, 179);
            this.UserEnter.Name = "UserEnter";
            this.UserEnter.Size = new System.Drawing.Size(204, 58);
            this.UserEnter.TabIndex = 1;
            this.UserEnter.Text = "User Enter";
            this.UserEnter.UseVisualStyleBackColor = false;
            this.UserEnter.Click += new System.EventHandler(this.UserEnter_Click);
            // 
            // RegisterEnter
            // 
            this.RegisterEnter.BackColor = System.Drawing.Color.Transparent;
            this.RegisterEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterEnter.FlatAppearance.BorderSize = 0;
            this.RegisterEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegisterEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegisterEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterEnter.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterEnter.Location = new System.Drawing.Point(995, 602);
            this.RegisterEnter.Name = "RegisterEnter";
            this.RegisterEnter.Size = new System.Drawing.Size(150, 45);
            this.RegisterEnter.TabIndex = 2;
            this.RegisterEnter.Text = "Register Enter";
            this.RegisterEnter.UseVisualStyleBackColor = false;
            this.RegisterEnter.Click += new System.EventHandler(this.RegisterEnter_Click);
            // 
            // Exit1
            // 
            this.Exit1.BackColor = System.Drawing.Color.Transparent;
            this.Exit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit1.FlatAppearance.BorderSize = 0;
            this.Exit1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit1.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.Exit1.Location = new System.Drawing.Point(878, 480);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(204, 59);
            this.Exit1.TabIndex = 3;
            this.Exit1.Text = "Exit";
            this.Exit1.UseVisualStyleBackColor = false;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatAppearance.BorderSize = 0;
            this.Title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkRed;
            this.Title.Location = new System.Drawing.Point(487, -7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(684, 102);
            this.Title.TabIndex = 4;
            this.Title.Text = "ColorCube Game";
            this.Title.UseVisualStyleBackColor = false;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            this.Title.MouseEnter += new System.EventHandler(this.Title_MouseHover);
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.Transparent;
            this.Option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Option.FlatAppearance.BorderSize = 0;
            this.Option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option.Location = new System.Drawing.Point(878, 319);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(204, 58);
            this.Option.TabIndex = 5;
            this.Option.Text = "Option";
            this.Option.UseVisualStyleBackColor = false;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ColorCube.Properties.Resources.HomePage;
            this.ClientSize = new System.Drawing.Size(1157, 649);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Exit1);
            this.Controls.Add(this.RegisterEnter);
            this.Controls.Add(this.UserEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorCube Technology";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button UserEnter;
        private System.Windows.Forms.Button RegisterEnter;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Option;
    }
}

