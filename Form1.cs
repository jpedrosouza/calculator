using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        bool getFirstValue = false;
        
        String operation = "";

        double value1 = 0.0;
        double value2 = 0.0;

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

        private void button2_Click(object sender, EventArgs e) => numbersDisplay.Text += '.';

        private void button3_Click(object sender, EventArgs e)
        {
            getValue("addition");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            getValue("multiplication");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            getValue("division");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(7);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(8);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setCharacterInDisplay(9);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            numbersDisplay.Text = "";
        }

        private void setCharacterInDisplay(int number)
        {
            if (numbersDisplay.Text == "0")
            {
                numbersDisplay.Text = "";
                numbersDisplay.Text += number.ToString();
            }
            else
            {
                numbersDisplay.Text += number.ToString();
            }
        }

        private void getValue(string choosedOperationButton)
        {
            if (!getFirstValue)
            {
                operation = choosedOperationButton;

                value1 = double.Parse(numbersDisplay.Text);

                numbersDisplay.Text = "";

                getFirstValue = true;
            } else
            {
                value2 = double.Parse(numbersDisplay.Text);
            }
        }

        private void calculate()
        {
            double result = 0.0;

            if (getFirstValue)
            {
                value2 = double.Parse(numbersDisplay.Text);
            }

            if (operation == "multiplication")
            {
                result = value1 * value2;
            } else if (operation == "subtraction")
            {
                result = value1 - value2;
            } else if (operation == "addition")
            {
                result = value1 + value2;
            } else if (operation == "division")
            {
                result = value1 / value2;
            }

            getFirstValue = false;

            numbersDisplay.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getValue("subtraction");
        }
    }
}
