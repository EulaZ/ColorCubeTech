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

/// <summary>
/// //set the serial port name first
/// 协议：
    /// 输出：（默认16进制发送）
    /// 关卡模式选择：
    ///         0x01：简单模式 20s
    ///         0x02：中等模式 15s
    ///         0x03：困难模式 10s
    /// 游戏开始：打开串口，不发送任何数据。
    /// 遥感操纵：
    ///         0x10 向前
    ///         0x20 向后
    ///         0x30 向左
    ///         0x40 向右
    /// 游戏结束：发送“0x00”之后关闭串口。
///输入：（默认以字符串形式接收）
///每秒钟接受一次信号，以显示倒计时。
///输入字符串：【当前距离/当前颜色 +\n】
///             0-255 / r g b y p +\n
/// </summary>

namespace ColorCube
{
    public partial class Usagepage : Form
    {
        SerialPort serialport1 = new SerialPort("com5", 9600);

        public int tm_interval; //time interval = 1000ms = 1s
        
        public string distance;
        public string color;

        public bool Flag_Counting;
        public int time;
        public int turn;
        public int scores = 0;
        public int scores_last = 0;
        
        public byte[] level;

        public Usagepage()
        {
            InitializeComponent();
            //不检查是否有线程冲突
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Usagepage_Load(object sender, EventArgs e)
        {
            PageSetting();

            //set ports
            serialport1.Close();
            serialport1.DataBits = 8;  //Max bits
            serialport1.StopBits = StopBits.One;
            serialport1.Parity = Parity.None;

            serialport1.DataReceived += new SerialDataReceivedEventHandler(sp1DataReceived);
            serialport1.ReadTimeout = -1;

            //设置按钮不可用
            btnForward.Enabled = false;
            btnBack.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
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
                labDistance.Text = "Distance :";
                labUnit.Text = "Sec";

                btnForward.Text = "Forward";
                btnLeft.Text = "Left";
                btnRight.Text = "Right";
                btnBack.Text = "Back";
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
                labDistance.Text = "当前距离：";
                labUnit.Text = "秒";

                btnForward.Text = "向前";
                btnLeft.Text = "向左";
                btnRight.Text = "向右";
                btnBack.Text = "向后";
            }

            labNumber.Text = scores.ToString();
            LevelchoiceCombox();
        }

        //Set the "Current Difficulty level" combox
        private void LevelchoiceCombox()
        {
            ListItem item1 = new ListItem();
            item1.Value = "1";

            ListItem item2 = new ListItem();
            item2.Value = "2";

            ListItem item3 = new ListItem();
            item3.Value = "3";

            if (PublicValues.choice == 1)
            {
                item1.Text = "Simple mode";
                item2.Text = "Middle mode";
                item3.Text = "Difficult mode";
            }
            else if (PublicValues.choice == 0)
            {
                item1.Text = "简单模式";
                item2.Text = "中等模式";
                item3.Text = "困难模式";
            }

            this.Levelchoice.Items.Add(item1);
            this.Levelchoice.Items.Add(item2);
            this.Levelchoice.Items.Add(item3);
        }

        private void Levelchoice_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Levelchoice.SelectedIndex)
            {
                case 0:
                    tm_interval = 20;
                    level[0] = 0x01;
                    break;
                case 1:
                    tm_interval = 15;
                    level[0] = 0x02;
                    break;
                case 2:
                    tm_interval = 10;
                    level[0] = 0x03;
                    break;
                default:
                    {
                        //level[0] = 0x00;
                        /*
                        if (PublicValues.choice == 1)
                            _ = MessageBox.Show("Error: Difficulty level has not been chosen yet !", "Error");
                        else
                            _ = MessageBox.Show("没有选择当前关卡难度 !", "错误");
                        */
                        break;
                    }
            }
        }

        /// <summary>
        /// Open the Guidance page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static Guidance fm1;
        private void btnGuide_Click(object sender, EventArgs e)
        {
            if (PublicValues.choice == 1)
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
            if (Levelchoice.SelectedItem == null)
            {
                if (PublicValues.choice == 1)
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
                //Open the serial port to interact with the machine
                if (!serialport1.IsOpen)
                {
                    try
                    {
                        //set the port
                        serialport1.Open();     //打开串口
                        _ = MessageBox.Show("Serail port " + serialport1.PortName + " is open");
                        
                        //make sure to open the serial port
                        while(!serialport1.IsOpen)
                        {
                            Thread.Sleep(100);
                        }
                        
                        //Choose the level
                        serialport1.Write(level, 0, 1);
                        _ = MessageBox.Show("[ " + level + " ]" + "is sent", "Tips");

                        Levelchoice.Enabled = false;
                        btnForward.Enabled = true;
                        btnBack.Enabled = true;
                        btnLeft.Enabled = true;
                        btnRight.Enabled = true;
                        btnStart.Enabled = false;
                        btnEnd.Enabled = true;

                        //开始倒计时和图片切换
                        scores_last = scores;
                        Flag_Counting = true;
                        LastingTimeCounting();               
                    }
                    catch (System.Exception ex)
                    {
                        _ = MessageBox.Show("Error: " + ex.Message, "Error");

                        if (PublicValues.choice == 1)
                        {
                            _ = MessageBox.Show("Something goes wrong with this game machine, please contact with the register !",
                                "Error");
                        }
                        else
                        {
                            _ = MessageBox.Show("游戏机链接出现故障，请联系管理员进行维修 ！", "错误");
                        }

                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 持续接收串口数据，判断颜色是否相同并积分。
        /// </summary>
        private void sp1DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialport1.IsOpen)
            {
                try
                {
                    string rcvdata = serialport1.ReadExisting();
                    serialport1.DiscardInBuffer();  //clear buffer in ports controller

                    //deal with the string
                    //split the received data into several parts to show on the page.
                    //(0 - 255) / (r g b y p) +\n
                    distance = rcvdata.Substring(1, rcvdata.Length-2);  //distance number
                    color = rcvdata.Substring(0, 1); ;

                    DistanceBox.Text = distance;
                    labRcvM.Text = rcvdata;
                }
                catch(System.Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                _ = MessageBox.Show("Please check the state of the port !", "Error");
            }

        }

        /// <summary>
        /// Reset all choices and clear all data, send a signal to MBED to reset the game flat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            //设置停止倒计时flag
            Flag_Counting = false;

            //设置按钮不可用
            btnForward.Enabled = false;
            btnBack.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnStart.Enabled = true;
            btnEnd.Enabled = false;

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
            Levelchoice.Enabled = true;
            //LEDbox.Text = "";
            TimeBox.Text = "";
            labNumber.Text = "0";
            pictureLED.Image = null;


            if (serialport1.IsOpen)
            {
                byte[] signalend = { 0x00 };
                serialport1.Write(signalend, 0, 1);
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
            btnEnd.PerformClick();
            Thread t1 = new Thread(starfrm4);//创建线程
            t1.Start();//启动线程
            this.Close();//关闭本窗口
        }
        private void starfrm4()
        {
            Application.Run(new Form1());
            //在新线程中运行第二个窗口
        }

        /// <summary>
        /// Operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public byte[] strmove = new byte[1];
        private void btnForward_Click(object sender, EventArgs e)
        {
            strmove[0] = 0x10;
            serialport1.Write(strmove, 0, 1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            strmove[0] = 0x20;
            serialport1.Write(strmove, 0, 1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            strmove[0] = 0x30;
            serialport1.Write(strmove, 0, 1);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            strmove[0] = 0x40;
            serialport1.Write(strmove, 0, 1);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int.TryParse(distance, out int dis_int);
            if (dis_int < 100)  //within 1cm, determine the chosen color.
            {
                switch (color)
                {
                    case "r":
                        if (pictureLED.Image == ImlistLED.Images[0]) scores += 10;
                        else scores -= 10;
                        break;
                    case "g":
                        if (pictureLED.Image == ImlistLED.Images[1]) scores += 10;
                        else scores -= 10;
                        break;
                    case "b":
                        if (pictureLED.Image == ImlistLED.Images[2]) scores += 10;
                        else scores -= 10;
                        break;
                    case "y":
                        if (pictureLED.Image == ImlistLED.Images[3]) scores += 10;
                        else scores -= 10;
                        break;
                    case "p":
                        if (pictureLED.Image == ImlistLED.Images[4]) scores += 10;
                        else scores -= 10;
                        break;
                    default:

                        if(PublicValues.choice == 1)
                        {
                            _ = MessageBox.Show("Unavailable Input ! No color cube is chosen !",
                                    "Error");
                        }
                        else
                        {
                            _ = MessageBox.Show("无效 ！没有被选中的方块 ！",
                                    "错误");
                        }
                        
                        break;
                }
            }

            labNumber.Text = scores.ToString();  //Show the scores we obtained
        }

        /// <summary>
        /// To calculate and show the lasting time
        /// </summary>
        /// public Form1 form1;
        private void LastingTimeCounting()
        {
            bool Flag = btnStart.Enabled;

            Thread t9 = new Thread(starfrm9);//创建倒计时线程
            t9.Start();
        }

        private void starfrm9()
        {
            time = tm_interval;
            turn = 0;

            int[] order = GetDisruptedItems();  //生成随机图片序列

            do
            {
                ChangeLEDColor(order[turn]);

                if (Flag_Counting)
                {
                    if (scores_last == scores)
                    {
                        if (time > 0 && turn < 5)
                        {
                            TimeBox.Text = time.ToString();
                            Thread.Sleep(1000);
                            time -= 1;
                        }
                        else if (time == 0 && turn < 5)
                        {
                            TimeBox.Text = time.ToString();

                            if (PublicValues.choice == 1)
                                _ = MessageBox.Show("Time Out", "Failure");
                            else
                                _ = MessageBox.Show("任务超时 ！", "失败");
                            Thread.Sleep(1000);

                            turn++;
                            time = tm_interval;
                        }
                    }
                    else
                    {
                        scores_last = scores;
                        time = tm_interval;
                        turn++;
                    }

                }
                else
                {
                    break;
                }

            } while (turn < 5);

            btnEnd.PerformClick();
            Application.ExitThread();
        }

        private void ChangeLEDColor(int i)
        {
            switch (i)
            {
                case 0:
                    pictureLED.Image = ImlistLED.Images[0];
                    break;
                case 1:
                    pictureLED.Image = ImlistLED.Images[1];
                    break;
                case 2:
                    pictureLED.Image = ImlistLED.Images[2];
                    break;
                case 3:
                    pictureLED.Image = ImlistLED.Images[3];
                    break;
                case 4:
                    pictureLED.Image = ImlistLED.Images[4];
                    break;
                default:
                    pictureLED.Image = null;
                    _ = MessageBox.Show("Something goes wrong with the LED. " +
                        "Please contact with the register !", "Error");
                    break;
            }
        }

        /// <summary>
        /// 打乱数组中元素顺序，用于生成随机序列。
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>order[]
        private int[] GetDisruptedItems()
        {
            int[] result = new int[5] { 0, 1, 2, 3, 4 };
            int[] temp = new int[5] { 0, 1, 2, 3, 4 };
            int t = new int();

            //打乱数组中元素顺序
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 5; i++)
            {
                int x, y;
                x = rand.Next(0, result.Length);
                do
                {
                    y = rand.Next(0, result.Length);
                } while (y == x);
                t = temp[x];
                temp[x] = temp[y];
                temp[y] = t;


            }
            return temp;
        }

        /*
        /// <summary>
        /// 委托新线程进行倒计时和切换颜色。
        /// </summary>
        public void LastingTime()
        {
            if (btnStart.Enabled == false)
            {
                time = tm_interval;
                turn = 0;

                int[] order = GetDisruptedItems();  //生成随机图片序列

                DateTime beforeDT = System.DateTime.Now;

                do
                {
                    switch (order[turn])
                    {
                        case 0:
                            pictureLED.Image = ImlistLED.Images[0];
                            break;
                        case 1:
                            pictureLED.Image = ImlistLED.Images[1];
                            break;
                        case 2:
                            pictureLED.Image = ImlistLED.Images[2];
                            break;
                        case 3:
                            pictureLED.Image = ImlistLED.Images[3];
                            break;
                        case 4:
                            pictureLED.Image = ImlistLED.Images[4];
                            break;
                        default:
                            _ = MessageBox.Show("Something goes wrong with the LED. " +
                                "Please contact with the register !", "Error");
                            break;
                    }

                    if (scores_last == scores)
                    {
                        if (time > 0 && turn < 5)
                        {
                            Thread.Sleep(1000);
                            time -= 1;
                            TimeBox.Text = time.ToString();
                        }
                        else if (time == 0 && turn < 5)
                        {
                            TimeBox.Text = time.ToString();

                            if (PublicValues.choice == 1)
                                _ = MessageBox.Show("Time Out", "Failure");
                            else
                                _ = MessageBox.Show("任务超时 ！", "失败");
                            Thread.Sleep(2000);

                            turn++;
                            time = tm_interval;
                        }
                    }
                    else
                    {
                        scores_last = scores;
                        time = tm_interval;
                        turn++;
                    }

                } while (turn < 5);

                btnEnd.PerformClick();
                this.Close();
            }
            else
            {
                btnEnd.PerformClick();
                this.Close();
            }
        }
        public delegate void LastingTime_dg();
        private void CallCountDown()
        {
            this.BeginInvoke(new LastingTime_dg(LastingTime));
        }

        private void CoutDowning()
        {
            Thread t9 = new Thread(new ThreadStart(DoCountDowning));//创建倒计时线程
            t9.Start();//启动线程
        }

        public void DoCountDowning()
        {
            CallCountDown();
        }
        */

    }
}

