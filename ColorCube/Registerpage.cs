using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ColorCube.Option;
using System.Text.RegularExpressions;
using System.Threading;

namespace ColorCube
{
    public partial class Registerpage : Form
    {
        SerialPort serialport1 = new SerialPort();

        public Registerpage()
        {
            InitializeComponent();
        }

        private void Registerpage_Load(object sender, EventArgs e)
        {

            //set all comboxes
            cbBaudRateCombox();
            cbDataBitsCombox();
            cbStopCombox();
            cbParityCombox();

            //检查是否含有串口
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                _ = MessageBox.Show("本机没有串口！", "Error");
                return;
            }

            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                //System.Diagnostics.Debug.WriteLine(s);
                cbSerial.Items.Add(s);
            }

            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            serialport1.DataReceived += new SerialDataReceivedEventHandler(sp1DataReceived);

            //串口设置默认选择项
            //cbSerial.SelectedIndex = 1;
            serialport1.BaudRate = 9600;

            //准备就绪              
            serialport1.DtrEnable = true;
            serialport1.RtsEnable = true;  //???
            //设置数据读取超时为1秒
            serialport1.ReadTimeout = 1000;

            serialport1.Close();
        }
        private void cbBaudRateCombox()
        {
            ListItem item1 = new ListItem();
            item1.Text = "300";
            item1.Value = "0";
            

            ListItem item2 = new ListItem();
            item2.Text = "600";
            item2.Value = "1";

            ListItem item3 = new ListItem();
            item3.Text = "1200";
            item3.Value = "2";

            ListItem item4 = new ListItem();
            item4.Text = "2400";
            item4.Value = "3";

            ListItem item5 = new ListItem();
            item5.Text = "4800";
            item5.Value = "4";

            ListItem item6 = new ListItem();
            item6.Text = "9600";
            item6.Value = "5";

            this.cbBaudRate.Items.Add(item1);
            this.cbBaudRate.Items.Add(item2);
            this.cbBaudRate.Items.Add(item3);
            this.cbBaudRate.Items.Add(item4);
            this.cbBaudRate.Items.Add(item5);
            this.cbBaudRate.Items.Add(item6);

            cbBaudRate.SelectedIndex = 5;
        }

        private void cbDataBitsCombox()
        {
            ListItem item1 = new ListItem();
            item1.Text = "5";
            item1.Value = "0";

            ListItem item2 = new ListItem();
            item2.Text = "6";
            item2.Value = "1";

            ListItem item3 = new ListItem();
            item3.Text = "7";
            item3.Value = "2";

            ListItem item4 = new ListItem();
            item4.Text = "8";
            item4.Value = "3";

            this.cbDataBits.Items.Add(item1);
            this.cbDataBits.Items.Add(item2);
            this.cbDataBits.Items.Add(item3);
            this.cbDataBits.Items.Add(item4);

            cbDataBits.SelectedIndex = 3;

        }

        private void cbStopCombox()
        {
            ListItem item1 = new ListItem();
            item1.Text = "1";
            item1.Value = "0";

            ListItem item2 = new ListItem();
            item2.Text = "1.5";
            item2.Value = "1";

            ListItem item3 = new ListItem();
            item3.Text = "2";
            item3.Value = "2";

            this.cbStop.Items.Add(item1);
            this.cbStop.Items.Add(item2);
            this.cbStop.Items.Add(item3);

            cbStop.SelectedIndex = 0;
        }

        private void cbParityCombox()
        {
            ListItem item1 = new ListItem();
            item1.Text = "NONE";
            item1.Value = "0";

            ListItem item2 = new ListItem();
            item2.Text = "ODD";
            item2.Value = "1";

            ListItem item3 = new ListItem();
            item3.Text = "EVEN";
            item3.Value = "2";

            this.cbParity.Items.Add(item1);
            this.cbParity.Items.Add(item2);
            this.cbParity.Items.Add(item3);

            cbParity.SelectedIndex = 0;
        }

        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(serialport1.IsOpen)
            {
                if (TimeCheck.Checked)
                {
                    tmSend.Enabled = true;
                }
                else
                {
                    tmSend.Enabled = false;
                }

                //send message to ports
                serialport1.WriteLine(SendBox.Text);
            }
            else
            {
                _ = MessageBox.Show("No port is open ! Please check the setting !", "Error");
            }
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (cbSerial.Text == "")
            {
                _ = MessageBox.Show("No port is chosen now ! Please check the setting first !", "Error");
            }
            else
            {
                if (!serialport1.IsOpen)
                {
                    try
                    {
                        //set the port
                        serialport1.PortName = cbSerial.SelectedItem.ToString();
                        string strBaud = cbBaudRate.Text;
                        string strData = cbDataBits.Text;
                        string strStop = cbStop.Text;
                        Int32 iBaud = Convert.ToInt32(strBaud);
                        Int32 iData = Convert.ToInt32(strData);

                        serialport1.BaudRate = iBaud;
                        serialport1.DataBits = iData;
                        switch (cbStop.Text)
                        {
                            case "1":
                                serialport1.StopBits = StopBits.One;
                                break;
                            case "1.5":
                                serialport1.StopBits = StopBits.OnePointFive;
                                break;
                            case "2":
                                serialport1.StopBits = StopBits.Two;
                                break;
                            default:
                                _ = MessageBox.Show("Error: Unavailable input !");
                                break;
                        }
                        switch (cbParity.Text)             //校验位
                        {
                            case "NONE":
                                serialport1.Parity = Parity.None;
                                break;
                            case "ODD":
                                serialport1.Parity = Parity.Odd;
                                break;
                            case "EVEN":
                                serialport1.Parity = Parity.Even;
                                break;
                            default:
                                MessageBox.Show("Error: Unavailable input !", "Error");
                                break;
                        }

                        HistoryBox.AppendText("Baud Rate: " + serialport1.BaudRate + System.Environment.NewLine);
                        HistoryBox.AppendText("Stop Bits: " + serialport1.StopBits + System.Environment.NewLine);
                        HistoryBox.AppendText("Data Bits: " + serialport1.DataBits + System.Environment.NewLine);
                        HistoryBox.AppendText("Parity Bits: " + serialport1.Parity + System.Environment.NewLine);

                        serialport1.Open();     //打开串口
                        btnSwitch.Text = "Close serial port";
                        HistoryBox.AppendText("Serial port " + serialport1.PortName + " is open." + System.Environment.NewLine);

                        //设置必要控件不可用
                        cbSerial.Enabled = false;
                        cbBaudRate.Enabled = false;
                        cbDataBits.Enabled = false;
                        cbStop.Enabled = false;
                        cbParity.Enabled = false;
                    }
                    catch (System.Exception ex)
                    {
                        _ = MessageBox.Show("Error: " + ex.Message, "Error");
                        HistoryBox.AppendText("Something goes wrong when the PC trys to connect to the machine. " +
                            "Please check the connection." + System.Environment.NewLine);
                        tmSend.Enabled = false;   //Initial state for the timer
                        return;
                    }
                }
                else
                {
                    //恢复控件功能
                    //设置必要控件不可用
                    cbSerial.Enabled = true;
                    cbBaudRate.Enabled = true;
                    cbDataBits.Enabled = true;
                    cbStop.Enabled = true;
                    cbParity.Enabled = true;

                    serialport1.Close();                    //关闭串口
                    btnSwitch.Text = "Open serial port";
                    tmSend.Enabled = false;         //关闭计时器

                    HistoryBox.AppendText("Serial port " + serialport1.PortName + " is close." + System.Environment.NewLine);
                }
            }  
        }

        private void sp1DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Show current time
            //DateTime dt = DateTime.Now;
            //ReceivedBox.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";

            System.Threading.Thread.Sleep(100);  //delay to receive all data            
            string command = serialport1.ReadExisting();

            //creat a byte array for the data received.
            /*  byte[] command = new byte[serialport1.BytesToRead];
                ReceivedBox.AppendText("Receive: " + command + System.Environment.NewLine); */

            ReceivedBox.AppendText(command + System.Environment.NewLine);
            serialport1.DiscardInBuffer(); //clear buffer in ports controller

            /*
            this.Invoke((EventHandler)(delegate
            {
                serialport1.Read(command, 0, command.Length);
            }
            );
            */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReceivedBox.Text = "";  //method to clear all the text
            HistoryBox.AppendText("Clear" + System.Environment.NewLine);
        }

        private void Registerpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
            serialport1.Close();
        }

        /// <summary>
        /// Automatically Send message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmSend_Tick(object sender, EventArgs e)
        {
            //转换时间间隔
            string strSecond = TdelayBox.Text;
            try
            {
                int isecond = int.Parse(strSecond) * 1000;//Interval以微秒为单位
                tmSend.Interval = isecond;
                if (tmSend.Enabled == true)
                {
                    btnSend.PerformClick();
                }
            }
            catch (System.Exception ex)
            {
                tmSend.Enabled = false;
                MessageBox.Show("Error: Unavailable Input !", "Error");
            }
        }

        /// <summary>
        /// Return to the home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(serialport1.IsOpen)
            {
                serialport1.Close();
            }

            try
            {
                Thread t6 = new Thread(starfrm6);
                t6.Start();
                this.Close();
            }
            catch(System.Exception ex)
            {
                _ = MessageBox.Show("Error: " + ex.Message, "Error");
            }
            
        }
        private void starfrm6()
        {
            Application.Run(new Form1());
        }

        /// <summary>
        /// Send a message for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitial_Click(object sender, EventArgs e)
        {
            if(serialport1.IsOpen)
            {
                serialport1.WriteLine("Initialize");
                HistoryBox.Text = null;
                HistoryBox.AppendText("Starting Initializing, notice the Received Box for the finishing message."
                    + System.Environment.NewLine);
            }
            else
            {
                _ = MessageBox.Show("No machine is connected now, please check the setting first !", "Error");
            }
        }

        private void cbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ReceivedBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
