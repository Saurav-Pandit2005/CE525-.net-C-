using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEI_2_Project
{
    public partial class Home_Screen : Form
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open Student form
            Student studentForm = new Student();
            studentForm.Show();   // Open as new window
            this.Hide();          // Hide Home_Screen (optional)

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Open Teacher form
            Teacher teacherForm = new Teacher();
            teacherForm.Show();   // Open as new window
            this.Hide();          // Hide Home_Screen (optional)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Department deptForm = new Department();
            deptForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open Login form
            Login loginForm = new Login();
            loginForm.Show();

            // Close current Home_Screen
            this.Hide();
        }
    }
}
