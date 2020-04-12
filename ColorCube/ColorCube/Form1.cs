using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColorCube.Option;

namespace ColorCube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (PublicValues.choice == 1)
            {
                UserEnter.Text = "User Enter";
                RegisterEnter.Text = "Resigter Enter";
                Option.Text = "Option";
                Exit1.Text = "Exit";
            }
            else if (PublicValues.choice == 0)
            {
                UserEnter.Text = "用户登录";
                RegisterEnter.Text = "管理员登录";
                Option.Text = "游戏设置";
                Exit1.Text = "退出游戏";
            }
        }

        public void LanguageChoice(int reset)
        {
            if(reset == 1)
            {
                UserEnter.Text = "User Enter";
                RegisterEnter.Text = "Resigter Enter";
                Option.Text = "Option";
                Exit1.Text = "Exit";
            }
            else if(reset == 0)
            {
                UserEnter.Text = "用户登录";
                RegisterEnter.Text = "管理员登录";
                Option.Text = "游戏设置";
                Exit1.Text = "退出游戏";
            }
        }

        /// <summary>
        /// User entrance, to open the operative page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserEnter_Click(object sender, EventArgs e)
        {
            //按钮被点击的事件
            Thread t2 = new Thread(starfrm2);//创建线程
            t2.Start();//启动线程
            this.Close();
        }
        private void starfrm2()
        {
            Application.Run(new Enrollment());
            //在新线程中运行第二个窗口
        }

        /// <summary>
        /// Register entrance, to open the maintance page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterEnter_Click(object sender, EventArgs e)
        {
            //按钮被点击的事件
            Thread t3 = new Thread(starfrm3);//创建线程
            t3.Start();//启动线程
            this.Close();//关闭本窗口
        }
        private void starfrm3()
        {
            Application.Run(new Enrollment());
            //在新线程中运行第二个窗口
        }

        /// <summary>
        /// Operations on the title"ColorCube Technology"
        /// Details about our company and will link to the website later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Title_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            // 
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 200;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            if(PublicValues.choice == 1)
            {            
                toolTip1.SetToolTip(Title, "Click to learn more about us");//设置提示按钮和提示内容
            }
            else
            {
                toolTip1.SetToolTip(Title, "点击这里了解我们");
            }
        }

        //
        private void Title_Click(object sender, EventArgs e)
        {
            if(PublicValues.choice == 1)
                 _ = MessageBox.Show("The company's official website: http://colorcube.pw");
            else
                _ = MessageBox.Show("公司官网：http://colorcube.pw");
        }

        //Eixt the program
        private void Exit1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Choose the language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static Option fm1;
        private void Option_Click(object sender, EventArgs e)
        {
            //check to open the OptionPage only once
            if (fm1 == null || fm1.IsDisposed)
            {
                fm1 = new Option(this);
                fm1.Show(this);
                fm1.Activate();
            }
            else
            {
                fm1.Activate();
                fm1.WindowState = FormWindowState.Normal;
            }
        }

    }


}
