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
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();   // better than Close
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // 1️⃣ Input Validation - Check for empty fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // Email
                string.IsNullOrWhiteSpace(textBox2.Text) ||  // Name
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // Password
                string.IsNullOrWhiteSpace(textBox4.Text) ||  // Confirm Password
                string.IsNullOrWhiteSpace(comboBox1.Text))   // Gender
            {
                MessageBox.Show("Please fill all fields before signing up!",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Check if passwords match
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop here, do not insert
            }

            // 3️⃣ Insert into database
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Users (Email, Name, Password, Gender) VALUES (@Email, @Name, @Password, @Gender)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim()); // Store password as plain text (not recommended for production)
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Signup Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
