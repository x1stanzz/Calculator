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
    public partial class Form1 : Form
    {
        double firstNum;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null || textBox1.Text == "Error")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = '+';
        }

        private void mult_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = '*';
        }

        private void div_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = '/';
        }

        private void diff_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = '-';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondNum = Convert.ToDouble(textBox1.Text);
            double result;

            if (operation == '+')
            {
                result = firstNum + secondNum;
                textBox1.Text = Convert.ToString(result);
                firstNum = result;
            }

            if (operation == '*')
            {
                result = firstNum * secondNum;
                textBox1.Text = Convert.ToString(result);
                firstNum = result;
            }

            if (operation == '/')
            {
                if (secondNum == 0)
                {
                    textBox1.Text = "Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    textBox1.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }

            if (operation == '-')
            {
                result = firstNum - secondNum;
                textBox1.Text = Convert.ToString(result);
                firstNum = result;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
