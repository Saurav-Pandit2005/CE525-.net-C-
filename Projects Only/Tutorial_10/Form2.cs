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

namespace Tutorial_10
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add query numbers 1 to 10 to the ComboBox
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0; // Set default selection to 1
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Set to dropdown list
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YourDatabasePath\YourDatabase.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "";
            int selectedQuery = Convert.ToInt32(comboBox1.SelectedItem);

            if (selectedQuery == 1)
            {
                query = "SELECT o.OrderID, o.CustID, c.Name, c.City, c.State, o.OrderAmount " +
                        "FROM Customer c, Orders o " +
                        "WHERE c.CustID = o.CustID";
            }
            else if (selectedQuery == 2)
            {
                query = "SELECT o.OrderID, o.CustID, c.Name, c.City, c.State, o.OrderAmount " +
                        "FROM Customer c, Orders o " +
                        "WHERE c.CustID = o.CustID AND o.OrderAmount > 10000";
            }
            else if (selectedQuery == 3)
            {
                query = "SELECT c.CustID, c.Name, c.City, c.State, SUM(o.OrderAmount) as TotalOrderAmount " +
                        "FROM Customer c, Orders o " +
                        "WHERE c.CustID = o.CustID " +
                        "GROUP BY c.CustID, c.Name, c.City, c.State";
            }
            // Add more else-if blocks for queries 4 to 10 as needed

            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
