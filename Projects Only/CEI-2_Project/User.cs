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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        int selectedUserId = 0; // Global variable

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Hide();   // Close Student/Teacher form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;

                conn.Open();
                // Only select the columns you want to display
                string query = "SELECT User_Id, Email, Name, Password FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Users (Email, Name, Password) VALUES (@Email, @Name, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Added!");
                button5_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Users SET Email=@Email, Name=@Name, Password=@Password WHERE User_Id=@User_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);
                cmd.Parameters.AddWithValue("@User_Id", selectedUserId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("User Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers(); // Refresh DataGridView
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                  "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "DELETE FROM Users WHERE User_Id=@User_Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@User_Id", selectedUserId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("User Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers(); // Refresh DataGridView
            }
        }

        private void LoadUsers()
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT User_Id, Email, Name, Password FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Bind data to DataGridView
            }

            // Optional: Reset selectedUserId after refresh
            selectedUserId = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header row
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Fill textboxes from selected row
                textBox1.Text = row.Cells["Email"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Password"].Value.ToString();

                // Store the ID for Update/Delete
                selectedUserId = Convert.ToInt32(row.Cells["User_Id"].Value);
            }
        }
    }
}
