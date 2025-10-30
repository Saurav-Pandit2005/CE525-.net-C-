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
    public partial class Department : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True");

        public Department()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Hide();   // Close Student/Teacher form
        }

        void LoadDepartment()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Department", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        // 🧹 CLEAR TEXTBOXES
        void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        // View
        private void button5_Click(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Department VALUES(@Id,@Name,@Description,@Duration)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox3.Text);
            cmd.Parameters.AddWithValue("@Duration", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Added Successfully!");
            LoadDepartment();
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Department SET Name=@Name, Description=@Description, Duration=@Duration WHERE Department_Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Description", textBox3.Text);
            cmd.Parameters.AddWithValue("@Duration", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Updated Successfully!");
            LoadDepartment();
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE Department_Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Department Deleted Successfully!");
            LoadDepartment();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Department_Id"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Description"].Value.ToString();
                textBox4.Text = row.Cells["Duration"].Value.ToString();
            }
        }
    }
}
