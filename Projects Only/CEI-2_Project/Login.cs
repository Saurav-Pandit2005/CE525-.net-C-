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

namespace CEI_2_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();   // hide Login form
            Sign_In signupForm = new Sign_In();
            signupForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection = True";

            // 1️⃣ Check if Email or Password is empty first
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Email and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop login process here
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email=@Email AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Home_Screen home = new Home_Screen();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password!");
                }
            }
        }

    }
}
