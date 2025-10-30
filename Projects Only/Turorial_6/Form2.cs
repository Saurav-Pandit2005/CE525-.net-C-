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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Saurav");
            listBox1.Items.Add("Razz");
            listBox1.Items.Add("Rajan");
            listBox1.Items.Add("Rahul");
            listBox1.Items.Add("Mohin");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblCount.Text = "Total Items: 0";
            lblSelection.Text = "Your Selection: ";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int total = listBox1.Items.Count;
            lblCount.Text = "Total Items: " + total;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblSelection.Text = "Your Selection: " + listBox1.SelectedItem.ToString();
            }
        }
    }
}

