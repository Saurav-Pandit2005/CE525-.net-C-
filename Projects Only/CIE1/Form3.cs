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

namespace CIE1
{
    public partial class Form3 : Form
    {
        string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From student ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand command = new SqlCommand("Insert into student  (name, course, dob, address, contact ) values (@name, @course, @dob, @address,@contact)", conn);
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.Parameters.AddWithValue("@course", textBox2.Text);
            command.Parameters.AddWithValue("@dob", textBox3.Text);
            command.Parameters.AddWithValue("@address", textBox4.Text);
            command.Parameters.AddWithValue("@contact", Convert.ToInt64(textBox5.Text));
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Inserted Succesfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM student WHERE id=@id", conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully");

            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);


                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE student SET name=@name, course=@course, dob=@dob, address=@address, contact=@contact WHERE id=@id", conn);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@course", textBox2.Text);
                command.Parameters.AddWithValue("@dob", textBox3.Text);
                command.Parameters.AddWithValue("@address", textBox4.Text);
                command.Parameters.AddWithValue("@contact", Convert.ToInt64(textBox5.Text));
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");

            }
        }
    }
}
