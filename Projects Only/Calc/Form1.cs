using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double firstno, secondno, ANS;
        String op = "";
        public Form1() 
        { 
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "1" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "*";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "2" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "3" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "4" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "5" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "6" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "7" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "-";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secondno = Convert.ToDouble(richTextBox1.Text); 
            if(op == "+")
            {
                ANS = firstno + secondno;
                richTextBox1.Text = ANS.ToString();
            }
            else if(op == "-")
            {
                ANS = firstno - secondno;
                richTextBox1.Text = ANS.ToString();
            }
            else if (op == "*")
            {
                ANS = firstno * secondno;
                richTextBox1.Text = ANS.ToString();
            }
            else if (op == "/")
            {
                if(secondno != 0)
                {
                    ANS = firstno / secondno;
                    richTextBox1.Text = ANS.ToString();
                }
                else
                {
                    MessageBox.Show("Cannot Divide by Zero");
                    richTextBox1.Text = "0";
                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "8" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "9" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }
    }
}
