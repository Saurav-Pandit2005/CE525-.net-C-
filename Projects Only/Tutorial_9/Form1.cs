using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tutorial_9
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "insert into student values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + Convert.ToInt64(textBox5.Text) + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update!");
                return;
            }


            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = ("UPDATE student SET " +
                           "name = '" + textBox1.Text + "', " +
                           "course = '" + textBox2.Text + "', " +
                           "dob = '" + textBox3.Text + "', " +
                           "address = '" + textBox4.Text + "', " +
                           "contact = '" + Convert.ToInt64(textBox5.Text) + "' " +
                           "WHERE id = " + id);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "DELETE FROM student WHERE id = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["name"].Value.ToString();
                textBox2.Text = row.Cells["course"].Value.ToString();
                textBox3.Text = row.Cells["dob"].Value.ToString();
                textBox4.Text = row.Cells["address"].Value.ToString();
                textBox5.Text = row.Cells["contact"].Value.ToString();
            }
        }
    }
}
