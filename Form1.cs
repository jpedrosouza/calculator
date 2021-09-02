using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        

        public Calculator()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text != "0")
            {
                numbersDisplay.Text += "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "2";
            } else
            {
                numbersDisplay.Text += "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "1";
            } else
            {
                numbersDisplay.Text += "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "3";
            } else
            {
                numbersDisplay.Text += "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "4";
            } else
            {
                numbersDisplay.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "5";
            } else
            {
                numbersDisplay.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "6";
            } else
            {
                numbersDisplay.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "7";
            } else
            {
                numbersDisplay.Text += "7";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "8";
            } else
            {
                numbersDisplay.Text += "8";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += "9";
            } else
            {
                numbersDisplay.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            numbersDisplay.Text = "";
        }
    }
}
