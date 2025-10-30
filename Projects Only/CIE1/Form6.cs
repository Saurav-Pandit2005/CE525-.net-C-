using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIE1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Sender and receiver details
                string fromEmail = textBox1.Text;
                string toEmail = textBox2.Text;
                string messageBody = textBox3.Text;

                // Create the MailMessage object
                MailMessage mail = new MailMessage(fromEmail, toEmail);
                mail.Subject = "Test Mail from C# Application";
                mail.Body = messageBody;

                // Setup SMTP client (using Gmail as example)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("spandit341@rku.ac.in", "qdek vrbp wvjy gesb"); // Gmail app password
                smtp.EnableSsl = true;

                // Send mail
                smtp.Send(mail);

                MessageBox.Show("Mail sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
