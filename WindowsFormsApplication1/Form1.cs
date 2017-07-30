using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TicTacToe : Form
    {
        public bool initial = true;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void newGame()
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.BackColor = default(Color);
            btn22.BackColor = default(Color);
            btn33.BackColor = default(Color);
            btn31.BackColor = default(Color);
            btn22.BackColor = default(Color);
            btn13.BackColor = default(Color);
            btn11.BackColor = default(Color);
            btn12.BackColor = default(Color);
            btn13.BackColor = default(Color);
            btn21.BackColor = default(Color);
            btn22.BackColor = default(Color);
            btn23.BackColor = default(Color);
            btn31.BackColor = default(Color);
            btn32.BackColor = default(Color);
            btn33.BackColor = default(Color);
            btn11.BackColor = default(Color);
            btn21.BackColor = default(Color);
            btn31.BackColor = default(Color);
            btn12.BackColor = default(Color);
            btn22.BackColor = default(Color);
            btn32.BackColor = default(Color);
            btn13.BackColor = default(Color);
            btn23.BackColor = default(Color);
            btn33.BackColor = default(Color);
        }

        private void checker(Button x)
        {
            bool one, two, three, four, five, six, seven, eight;

            if (initial)
            {
                x.Text = "O";
                initial = false;
            }
            else
            {
                x.Text = "X";
                initial = true;
            }

            one = (btn11.Text == "X" && btn22.Text == "X" && btn33.Text == "X") || (btn11.Text == "O" && btn22.Text == "O" && btn33.Text == "O");
            two = (btn31.Text == "X" && btn22.Text == "X" && btn13.Text == "X") || (btn31.Text == "O" && btn22.Text == "O" && btn13.Text == "O");

            three = (btn11.Text == "X" && btn12.Text == "X" && btn13.Text == "X") || (btn11.Text == "O" && btn12.Text == "O" && btn13.Text == "O");
            four = (btn21.Text == "X" && btn22.Text == "X" && btn23.Text == "X") || (btn21.Text == "O" && btn22.Text == "O" && btn23.Text == "O");
            five = (btn31.Text == "X" && btn32.Text == "X" && btn33.Text == "X") || (btn31.Text == "O" && btn32.Text == "O" && btn33.Text == "O");

            six = (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") || (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O");
            seven = (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") || (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O");
            eight = (btn13.Text == "X" && btn23.Text == "X" && btn33.Text == "X") || (btn13.Text == "O" && btn23.Text == "O" && btn33.Text == "O");


            if (one || two || three || four || five || six || seven || eight)
            {
                if (one)
                {
                    btn11.BackColor = System.Drawing.Color.LimeGreen;
                    btn22.BackColor = System.Drawing.Color.LimeGreen;
                    btn33.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (two)
                {
                    btn31.BackColor = System.Drawing.Color.LimeGreen;
                    btn22.BackColor = System.Drawing.Color.LimeGreen;
                    btn13.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (three)
                {
                    btn11.BackColor = System.Drawing.Color.LimeGreen;
                    btn12.BackColor = System.Drawing.Color.LimeGreen;
                    btn13.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (four)
                {
                    btn21.BackColor = System.Drawing.Color.LimeGreen;
                    btn22.BackColor = System.Drawing.Color.LimeGreen;
                    btn23.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (five)
                {
                    btn31.BackColor = System.Drawing.Color.LimeGreen;
                    btn32.BackColor = System.Drawing.Color.LimeGreen;
                    btn33.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (six)
                {
                    btn11.BackColor = System.Drawing.Color.LimeGreen;
                    btn21.BackColor = System.Drawing.Color.LimeGreen;
                    btn31.BackColor = System.Drawing.Color.LimeGreen;
                }
                else if (seven)
                {
                    btn12.BackColor = System.Drawing.Color.LimeGreen;
                    btn22.BackColor = System.Drawing.Color.LimeGreen;
                    btn32.BackColor = System.Drawing.Color.LimeGreen;
                }
                else
                {
                    btn13.BackColor = System.Drawing.Color.LimeGreen;
                    btn23.BackColor = System.Drawing.Color.LimeGreen;
                    btn33.BackColor = System.Drawing.Color.LimeGreen;
                }

                MessageBox.Show("you won dood");
                newGame();
            }
            if (btn11.Text != "" && btn12.Text != "" && btn13.Text != "" && btn21.Text != "" && btn22.Text != "" && btn23.Text != "" && btn31.Text != "" && btn32.Text != "" && btn33.Text != "")
            {
                MessageBox.Show("aww tie, try again");
                newGame();
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            checker(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            checker(btn12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            checker(btn13);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            checker(btn21);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            checker(btn22);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            checker(btn23);
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            checker(btn31);
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            checker(btn32);
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            checker(btn33);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by the wierd guy");
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ah common, u need instructin to play a simple tic tac toe??????");
        }
    }
}
