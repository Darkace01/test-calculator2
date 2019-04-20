using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_calculator
{
    public partial class Calculator : Form
    {
        double FNumber;
        string Operation;
        double SecoundNumber;
        public Calculator()
        {
            
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            } else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void nAdd_Click(object sender, EventArgs e)
        {
            //converting the inputed num to a double then we include the operation
            FNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = FNumber + "+";
            Operation = "+";
            SecoundNumber = Convert.ToDouble(textBox1.Text);
        }

        private void nSub_Click(object sender, EventArgs e)
        {
            //converting the inputed num to a double then we include the operation
            FNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = FNumber + "-";
            Operation = "-";
            SecoundNumber = Convert.ToDouble(textBox1.Text);
        }

        private void nMul_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = FNumber + "*";
            Operation = "*";
            SecoundNumber = Convert.ToDouble(textBox1.Text);
        }

        private void nDiv_Click(object sender, EventArgs e)
        {
            FNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = FNumber + "/";
            Operation = "/";
            SecoundNumber = Convert.ToDouble(textBox1.Text);
        }
        
        private void nRes_Click(object sender, EventArgs e)
        {
            
            double Result;
            


            if (Operation == "+")
            {
                Result = (FNumber + SecoundNumber);
                textBox1.Text = Convert.ToString(Result);
                FNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FNumber - SecoundNumber);
                textBox1.Text = Convert.ToString(Result);
                FNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FNumber * SecoundNumber);
                textBox1.Text = Convert.ToString(Result);
                FNumber = Result;
            }
            if (Operation == "/")
            {
                Result = (FNumber / SecoundNumber);
                textBox1.Text = Convert.ToString(Result);
                FNumber = Result;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ndot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }

   
}
