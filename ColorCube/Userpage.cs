using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ColorCube.Option;

namespace ColorCube
{
    public partial class Usagepage : Form
    {
        SerialPort serialport1 = new SerialPort("com5", 9600);
        //SerialPort serialport2 = new SerialPort("com2", 9600);

        public int level;

        public Usagepage()
        {
            InitializeComponent();
        }

        private void Usagepage_Load(object sender, EventArgs e)
        {
            PageSetting();

            //set ports
            serialport1.DataBits = 8;  //Max bits
            serialport1.StopBits = StopBits.One;
            serialport1.Parity = Parity.None;
        }

        //Set the language of this page
        private void PageSetting()
        {
            if (PublicValues.choice == 1)
            {
                btnGuide.Text = "Game  Guide";
                btnStart.Text = "Game  Start";
                btnEnd.Text = "Game Over";
                Exit2.Text = "Return to Home";
                labLevel.Text = "Current difficulty level";
                labLED.Text = "Current LED color :";
                labTime.Text = "Lasting Time :";
                labScore.Text = "Scores Obtained :";
            }
            else if (PublicValues.choice == 0)
            {
                btnGuide.Text = "游戏教程";
                btnStart.Text = "开始游戏";
                btnEnd.Text = "结束游戏";
                Exit2.Text = "返回主页";
                labLevel.Text = "当前关卡难度：";
                labLED.Text = "当前指定颜色：";
                labTime.Text = "倒计时：";
                labScore.Text = "已经获得的分数：";
            }

            LevelchoiceCombox();
        }

        //Set the "Current Difficulty level" combox
        private void LevelchoiceCombox()
        {
            ListItem item1 = new ListItem();
            item1.Value = "0";

            ListItem item2 = new ListItem();
            item2.Value = "1";
            
            ListItem item3 = new ListItem();
            item3.Value = "2";
            
            if (PublicValues.choice == 1)
            {
                item1.Text = "Simple mode";
                item2.Text = "Middle mode";
                item3.Text = "Difficult mode";
            }
            else if(PublicValues.choice == 0)
            {
                item1.Text = "简单模式";
                item2.Text = "中等模式";
                item3.Text = "困难模式";
            }

            this.Levelchoice.Items.Add(item1);
            this.Levelchoice.Items.Add(item2);
            this.Levelchoice.Items.Add(item3);
        }

        /// <summary>
        /// Open the Guidance page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static Guidance fm1;
        private void btnGuide_Click(object sender, EventArgs e)
        {
            if(PublicValues.choice == 1)
            {
                _ = MessageBox.Show("Welcome to ColorCube Game Box !\n" +
                      "We have a simple guide for you to understand how to play with this machine as below."
                      , "Help");

            }
            else
            {
                _ = MessageBox.Show("欢迎来到卡乐立方推箱子游戏 !\n" +
                      "我们为你准备了一份简单的教程，以便你能够更好地享受它。"
                      , "帮助");

            }

            //check to open the OptionPage only once
            if (fm1 == null || fm1.IsDisposed)
            {
                fm1 = new Guidance();
                fm1.Show(this);
                fm1.Activate();
            }
            else
            {
                fm1.Activate();
                fm1.WindowState = FormWindowState.Normal;
            }

    }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //start the game
            if(Levelchoice.SelectedItem == null)
            {
                if(PublicValues.choice == 1)
                {
                    _ = MessageBox.Show("Please choose Current Difficulty Level first !", "Error");
                }
                else
                {
                    _ = MessageBox.Show("请先选择关卡难度 !", "错误");
                    return;
                }
            }
            else
            {
                //Open the serial port to interact with MBED
                if (!serialport1.IsOpen)
                {
                    try
                    {
                        //set the port
                        serialport1.Open();     //打开串口
                        _ = MessageBox.Show("Serail port " + serialport1.PortName + " is open");
                    }
                    catch (System.Exception ex)
                    {
                        _ = MessageBox.Show("Error: " + ex.Message, "Error");
                        return;
                    }
                }
            }

            


            //tmReceive_Tick();
        }

        /// <summary>
        /// 持续接收串口数据。
        /// </summary>
        private void GameProcess()
        {
            serialport1.ReadTimeout = -1;
            //serialport1.DataReceived += new SerialDataReceivedEventHandler(sp1DataReceived);
        }



        /*
        /// <summary>
        /// 一定时间间隔自动接收来自MBED的数据，把显示时间提前半秒。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmSend_Tick(object sender, EventArgs e)
        {
            try
            {
                //tmSend.Interval = isecond;
                if (tmSend.Enabled == true)
                {
                    //btnR.PerformClick();
                }
            }
            catch (System.Exception ex)
            {
                tmSend.Enabled = false;
                if (PublicValues.choice == 1)
                    _ = MessageBox.Show("Error: Something wrong with this machine, please contact register !", "Error");
                else
                    _ = MessageBox.Show("机器出现未知错误，游戏无法顺利进行，请联系管理员 !", "错误");
            }
        }
        */

        
        /// <summary>
        /// Reset all choices and clear all data, send a signal to MBED to reset the game flat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (PublicValues.choice == 1)
            {
                _ = MessageBox.Show("Game Over !\n" +
                    "Your final scores: " + labNumber.Text,
                    "Congulations");
            }
            else
            {
                _ = MessageBox.Show("游戏结束 !\n" +
                    "你的最终得分是：" + labNumber.Text,
                    "祝贺你");
            }

            //clear all the lable
            Levelchoice.SelectedItem = null;
            LEDbox.Text = "";
            Timebox.Text = "";
            labNumber.Text = "0";

            if (serialport1.IsOpen)
            {
                serialport1.WriteLine("End");
                serialport1.Close();
                _ = MessageBox.Show("Serial port " + serialport1.PortName + " is close");
            }
            
        }

        /// <summary>
        /// Click here to return to the Home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit2_Click(object sender, EventArgs e)
        {
            //按钮被点击的事件
            Thread t1 = new Thread(starfrm4);//创建线程
            t1.Start();//启动线程
            this.Close();//关闭本窗口
        }
        private void starfrm4()
        {
            Application.Run(new Form1());
            //在新线程中运行第二个窗口
        }

        private void Levelchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(Levelchoice.SelectedItem.ToString())
            {
                case "Simple Mode":
                    level = 0;
                    break;
                case "Middle Mode":
                    level = 1;
                    break;
                case "Difficult Mode":
                    level = 2;
                    break;
                default:
                    {
                        if(PublicValues.choice ==1 )
                            _ = MessageBox.Show("Error: Difficulty level has not been chosen yet !", "Error");
                        else
                            _ = MessageBox.Show("没有选择当前关卡难度 !", "错误");
                        break;
                    }
            }
        }


    }
}