using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColorCube.Option;

namespace ColorCube
{
    public partial class Guidance : Form
    {
        public Guidance()
        {
            InitializeComponent();
        }
        private void Guidance_Load(object sender, EventArgs e)
        {
            if(PublicValues.choice == 1)
            {
                GuideBox.Text = "Game Instruction:\n" +
                    "Before starting the game, please choose Difficulty Level first.\n" +
                    "Click 'Game Start' to enter the game, please operate the white cube by using the buttons " +
                    "on the page and try to push the cube with corrensponding color into the hole within the " +
                    "stipulated time. If successful, you can obtain scores. Either a timeout or a cube with " +
                    "the wrong color pushed in will deducted your scores.\n" +
                    "If you want to end or restart the game, please click 'Game Over' to end up the game. " +
                    "After waiting a short time for the machine to reset, you can start the game again.\n";
            }
            else
            {
                GuideBox.Text = "游戏说明：\n" +
                    "开始游戏前，请选择关卡难度：\n" +
                    "点击开始游戏，将会开始计时，请点击页面上的按钮操纵白色方块，" +
                    "在规定时间内将正确颜色的方块推入洞中则计分，" +
                    "若超时或推入颜色错误的方块则会扣除相应分数。\n" +
                    "若想结束游戏，或重新开始，请点击‘游戏结束’，等待游戏机重置后方可重新开始游戏。\n";
            }
        }
    }
}
