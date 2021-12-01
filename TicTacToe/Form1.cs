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
        // Player X starts game
        bool player = true;
        // Initial moves number
        int move = 0;
        // Matrix containing the numbers 1 (X) or -1 (O), used then to check who won
        int[,] matrix = new int[5, 5];
        // List with all PictureBoxes used in game
        PictureBox[] boxList = new PictureBox[25];

        public Form1()
        {
            InitializeComponent();
            // Initialize game with disabled boxes
            ChangeBoxesEnable(false);
        }

        /// <summary>Set the Enabled state of PictureBoxes and the default image</summary>
        private void ChangeBoxesEnable(bool enable)
        {
            move = 0;
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
            foreach (PictureBox box in boxList)
            {
                box.Enabled = enable;
                box.Image = Image.FromFile("../../images/default.png");
            }
        }

        private void box1_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box1.Image = Image.FromFile(path);
            matrix[0, 0] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box1.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box2.Image = Image.FromFile(path);
            matrix[0, 1] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box2.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box3.Image = Image.FromFile(path);
            matrix[0, 2] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box3.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box4.Image = Image.FromFile(path);
            matrix[0, 3] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box4.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box5.Image = Image.FromFile(path);
            matrix[0, 4] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box5.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box6.Image = Image.FromFile(path);
            matrix[1, 0] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box6.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box7.Image = Image.FromFile(path);
            matrix[1, 1] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box7.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box8.Image = Image.FromFile(path);
            matrix[1, 2] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box8.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box9.Image = Image.FromFile(path);
            matrix[1, 3] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box9.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box10_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box10.Image = Image.FromFile(path);
            matrix[1, 4] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box10.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box11_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box11.Image = Image.FromFile(path);
            matrix[2, 0] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box11.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box12_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box12.Image = Image.FromFile(path);
            matrix[2, 1] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box12.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box13_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box13.Image = Image.FromFile(path);
            matrix[2, 2] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box13.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box14_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box14.Image = Image.FromFile(path);
            matrix[2, 3] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box14.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box15_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box15.Image = Image.FromFile(path);
            matrix[2, 4] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box15.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box16_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box16.Image = Image.FromFile(path);
            matrix[3, 0] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box16.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box17_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box17.Image = Image.FromFile(path);
            matrix[3, 1] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box17.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box18_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box18.Image = Image.FromFile(path);
            matrix[3, 2] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box18.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box19_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box19.Image = Image.FromFile(path);
            matrix[3, 3] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box19.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box20_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box20.Image = Image.FromFile(path);
            matrix[3, 4] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box20.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box21_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box21.Image = Image.FromFile(path);
            matrix[4, 0] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box21.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box22_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box22.Image = Image.FromFile(path);
            matrix[4, 1] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box22.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box23_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box23.Image = Image.FromFile(path);
            matrix[4, 2] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box23.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box24_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box24.Image = Image.FromFile(path);
            matrix[4, 3] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box24.Enabled = false;
            move++;
            CheckAllFields();
        }

        private void box25_Click(object sender, EventArgs e)
        {
            string path = player ? "../../images/imageX.png" : "../../images/imageO.png";
            box25.Image = Image.FromFile(path);
            matrix[4, 4] = player ? 1 : -1;
            player = !player;
            turnLabel.Text = player ? "X" : "O";
            box25.Enabled = false;
            move++;
            CheckAllFields();
        }

        /// <summary>Calculates sums of values in all rows, columns and diagonals.</summary>
        private void CheckAllFields()
        {
            // There are 28 opportunities to win
            int[] sumList = new int[28];
            int idx = 0;
            if (move > 6)
            {
                // Check sum in rows -> Iterate over each row
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    // There are two opportunities to win in each row
                    for (int offset = 0; offset < 2; offset++)
                    {
                        // Iterate over each column, but one less
                        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                        {
                            sumList[idx] += matrix[row, col + offset];
                        }
                        idx++;
                    }
                }
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                // Check sum in columns -> Iterate over each row
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // There are two opportunities to win in each row
                    for (int offset = 0; offset < 2; offset++)
                    {
                        // Iterate over each column, but one less
                        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                        {
                            sumList[idx] += matrix[row + offset, col];
                        }
                        idx++;
                    }
                }
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                // Check diagonals - main diagonals
                for (int offset = 0; offset < 2; offset++)
                {
                    // Iterate over first main diagonal
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        sumList[idx] += matrix[row + offset, row + offset];
                    }
                    idx++;
                }
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                for (int offset = 0; offset < 2; offset++)
                {
                    // Iterate over second main diagonal
                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        sumList[idx] += matrix[row + offset, matrix.GetLength(0) - row - offset - 1];
                    }
                    idx++;
                }
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                // Check other 4 diagonals
                for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                {
                    sumList[idx] += matrix[k + 1, k];
                }
                idx++;
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                {
                    sumList[idx] += matrix[k, k + 1];
                }
                idx++;
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                {
                    sumList[idx] += matrix[matrix.GetLength(0) - k - 2, k];
                }
                idx++;
                // Check if there is a win player before go further
                CheckGameWon(sumList);
                for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                {
                    sumList[idx] += matrix[matrix.GetLength(0) - k - 1, k + 1];
                }
                // Check if there is a win player before go further
                CheckGameWon(sumList);
            }
            if (move == 25)
            {
                gameDraw();
            }
        }

        /// <summary>Displays a message when there is a draw and resets the game.</summary>
        private void gameDraw()
        {
            MessageBox.Show("Draw!", "Game over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ResetGame();
        }

        /// <summary>Checks if there are somewhere 4 symbols in a row, adds points and resets the game.</summary>
        private void CheckGameWon(int[] sumList)
        {
            if (sumList.Contains(4) || sumList.Contains(-4))
            {
                MessageBox.Show((player ? "O" : "X") + " won!", "Game over!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (player)
                    pointsO.Text = (int.Parse(pointsO.Text) + 1).ToString();
                else
                    pointsX.Text = (int.Parse(pointsX.Text) + 1).ToString();
                // Clear sumList:
                for (int i = 0; i < sumList.Length; i++)
                {
                    sumList[i] = 0;
                }
                ResetGame();
            }
        }

        /// <summary>Enables all boxes and displays message.</summary>
        private void startBtn_Click(object sender, EventArgs e)
        {
            ChangeBoxesEnable(true);
            startBtn.Enabled = false;
            MessageBox.Show("Place 4 in a row to win!", "Start!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>Disables all boxes and resets points.</summary>
        private void restartBtn_Click(object sender, EventArgs e)
        {
            player = true;
            move = 0;
            turnLabel.Text = "X";
            pointsO.Text = "0";
            pointsX.Text = "0";
            startBtn.Enabled = true;
            ChangeBoxesEnable(false);
        }

        /// <summary>Resets the game.</summary>
        private void ResetGame()
        {
            // Set moves to 0
            move = 0;
            // Clear game matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            // Set boxes to default state
            ChangeBoxesEnable(true);
        }
    }
}
