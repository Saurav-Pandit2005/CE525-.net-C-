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

namespace Tutorial_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox2.Text;
            string org = textBox1.Text;
            string comment = textBox3.Text;

            MessageBox.Show("Message of " + name + " from " + org + " with " + comment);
        }
    }
}
