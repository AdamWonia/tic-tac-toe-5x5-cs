using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player = true;
        int move = 0;
        int[,] matrix = new int[5, 5];

        public Form1()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box1.Image = Image.FromFile(path);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            player = true;
            move = 0;
            turnLabel.Text = "X";
            pointsO.Text = "0";
            pointsX.Text = "0";
            Button[] boxList = new Button[25];
            boxList[0] = box1;
            boxList[1] = box2;
            boxList[2] = box3;
            boxList[3] = box4;
            boxList[4] = box5;
            boxList[5] = box6;
            boxList[6] = box7;
            boxList[7] = box8;
            boxList[8] = box9;
            boxList[9] = box10;
            boxList[10] = box11;
            boxList[11] = box12;
            boxList[12] = box13;
            boxList[13] = box14;
            boxList[14] = box15;
            boxList[15] = box16;
            boxList[16] = box17;
            boxList[17] = box18;
            boxList[18] = box19;
            boxList[19] = box20;
            boxList[20] = box21;
            boxList[21] = box22;
            boxList[22] = box23;
            boxList[23] = box24;
            boxList[24] = box25;
            foreach (Button btn in boxList)
            {
                btn.Enabled = true;
                btn.Image = Image.FromFile("../../images/default.png");
            }
        }
    }
}
