using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Turorial_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string prefix = "";

            // Gender Selection
            if (radioButton1.Checked)
            {
                prefix = "Mr.";
            }
            else if (radioButton2.Checked)
            {
                prefix = "Miss";
            }

            // Sources of Information
            List<string> sources = new List<string>();
            if (checkBox1.Checked) sources.Add("News Paper");
            if (checkBox2.Checked) sources.Add("Friends");
            if (checkBox3.Checked) sources.Add("Website");
            if (checkBox4.Checked && !string.IsNullOrWhiteSpace(textBox2.Text))
                sources.Add(textBox2.Text);

            // Final Output
            string sourceText = string.Join(", ", sources);
            lblMessage.Text = $"Hello {prefix} {name}. You know about us from {sourceText}.";
        }
    }
}
