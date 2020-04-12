using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCube
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        public Form1 form1;
        public Option(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        
        public class PublicValues
        {
            public static int choice = 1;
        }


        private void Option_Load(object sender, EventArgs e)
        {
            if (PublicValues.choice == 0)
            {
                radioButton1.Text = "英语";
                radioButton2.Text = "简体中文";
                button1.Text = "确认选择";
                label1.Text = "选择语言";
            }
            else if (PublicValues.choice == 1)
            {
                radioButton1.Text = "English";
                radioButton2.Text = "Chinese";
                button1.Text = "Check";
                label1.Text = "Language Choice";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PublicValues.choice = 0;
                radioButton1.Text = "英语";
                radioButton2.Text = "简体中文";
                button1.Text = "确认选择";
                label1.Text = "选择语言";
            }
            else if(radioButton1.Checked == true)
            {
                PublicValues.choice = 1;
                radioButton1.Text = "English";
                radioButton2.Text = "Chinese";
                button1.Text = "Check";
                label1.Text = "Language Choice";
            }

            this.form1.LanguageChoice(PublicValues.choice);
        }

    }
}
