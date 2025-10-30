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

namespace CEI_2_Project
{
    public partial class Teacher : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
        public Teacher()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teacher", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Teacher (Teacher_Id, Name, Gender, DOB, Phone, Department) VALUES (@Teacher_Id, @Name, @Gender, @DOB, @Phone, @Department)", con);

                cmd.Parameters.AddWithValue("@Teacher_Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Phone", textBox2.Text);
                cmd.Parameters.AddWithValue("@Department", comboBox2.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Added Successfully!");
                button5_Click(sender, e);  // Refresh DataGridView
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Teacher SET Name=@Name, Gender=@Gender, DOB=@DOB, Phone=@Phone, Department=@Department WHERE Teacher_Id=@Teacher_Id", con);

                cmd.Parameters.AddWithValue("@Teacher_Id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@Department", comboBox2.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Updated Successfully!");
                button5_Click(sender, e);  // Refresh DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Teacher WHERE Teacher_Id=@Teacher_Id", con);
                cmd.Parameters.AddWithValue("@Teacher_Id", int.Parse(textBox1.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Deleted Successfully!");
                button5_Click(sender, e);  // Refresh DataGridView
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Teacher_Id"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                comboBox1.Text = row.Cells["Gender"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                textBox3.Text = row.Cells["Phone"].Value.ToString();
                comboBox2.Text = row.Cells["Department"].Value.ToString();
            }
        }
    }
}
