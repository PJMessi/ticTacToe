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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checker()
        {
            bool one, two, three, four, five, six, seven, eight;

            one = (a11.Text == "o" && a22.Text == "o" && a33.Text == "o") || (a11.Text == "x" && a22.Text == "x" && a33.Text == "x");
            two = (a31.Text == "o" && a22.Text == "o" && a13.Text == "o") || (a31.Text == "x" && a22.Text == "x" && a13.Text == "x");

            three = (a11.Text == "o" && a12.Text == "o" && a13.Text == "o") || (a11.Text == "x" && a12.Text == "x" && a13.Text == "x");
            four = (a21.Text == "o" && a22.Text == "o" && a23.Text == "o") || (a21.Text == "x" && a22.Text == "x" && a23.Text == "x");
            five = (a31.Text == "o" && a32.Text == "o" && a33.Text == "o") || (a31.Text == "x" && a32.Text == "x" && a33.Text == "x");

            six = (a11.Text == "o" && a21.Text == "o" && a31.Text == "o") || (a11.Text == "x" && a21.Text == "x" && a31.Text == "x");
            seven = (a12.Text == "o" && a22.Text == "o" && a32.Text == "o") || (a12.Text == "x" && a22.Text == "x" && a32.Text == "x");
            eight = (a13.Text == "o" && a23.Text == "o" && a33.Text == "o") || (a13.Text == "x" && a23.Text == "x" && a33.Text == "x");


            if (one || two || three || four || five || six || seven || eight)
            {
                lblresult.Text = "game won";
            }
        }

        private void a11_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a12_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a13_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a21_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a22_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a23_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a31_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a32_TextChanged(object sender, EventArgs e)
        {
            checker();
        }

        private void a33_TextChanged(object sender, EventArgs e)
        {
            checker();
        }
    }
}
