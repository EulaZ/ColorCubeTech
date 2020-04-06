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
    public partial class Enrollment : Form
    {
        public int dir = -1; // direction to choose where is the next page

        public Enrollment()
        {
            InitializeComponent();
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            if (PublicValues.choice == 1)
            {
                labID.Text = "UserName :";
                labkey.Text = "Password :";
                btnsignup.Text = "Sign Up";
                btnReturn.Text = "Return";
            }
            else if (PublicValues.choice == 0)
            {
                labID.Text = "用户名 :";
                labkey.Text = "密码 :";
                btnsignup.Text = "登录";
                btnReturn.Text = "返回";
            }
        }

        /// <summary>
        /// Vistior Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsignup_Click(object sender, EventArgs e)
        {
            if(Namebox.Text == "Register" && Keybox.Text == "B39VSGroup04") //register enter : 
            {
                dir = 0;
            }
            else if(Namebox.Text == "User")  //user enter
            {
                dir = 1;
            }
            else if(Namebox.Text == "Register" && Keybox.Text != "B39VSGroup04")
            {
                if(PublicValues.choice == 1)
                {
                    _ = MessageBox.Show("Error : Username or Password is not correct !", "Error");
                }
                
                else
                {
                    _ = MessageBox.Show("用户名或密码输入错误 ！", "错误");
                }
            }
            else
            {
                if(PublicValues.choice == 1)
                {
                    _ = MessageBox.Show("Error : Unavailable UserName !", "Error");
                }
                else
                {
                    _ = MessageBox.Show("无效的用户名 !", "错误");
                }
                
            }

            if (dir == 0 || dir == 1)
            {
                Thread t1 = new Thread(starfrm5);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                this.Close();
            }
        }
        private void starfrm5()
        {
            switch(dir)
            {
                case 0: Application.Run(new Registerpage()); break;
                case 1: Application.Run(new Usagepage()); break;
                default: System.Environment.Exit(0); break;
            }
            
        }

        private void Keybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnsignup.PerformClick();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Thread t7 = new Thread(starfrm7);
            t7.Start();
            this.Close();
        }
        private void starfrm7()
        {
            Application.Run(new Form1());
        }
    }
}
