using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24SOECE13901_Saurav_Pandit_DEMO_TEST__Windoes_Form_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;

        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hello Saurav");
            listBox1.Items.Add("Hello Bhumi Mam");
            listBox1.Items.Add("Razz");
            listBox1.Items.Add("Rahul Bhai");
            listBox1.Items.Add("Mohin");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
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

        private void btn_count_Click(object sender, EventArgs e)
        {
            int total = listBox1.Items.Count;
            label1.Text = "Total Items: " + total;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label2.Text = "Your Selection: " + listBox1.SelectedItem.ToString();
            }
        }
    }
}
