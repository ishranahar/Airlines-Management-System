using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    public partial class LogInForm : Form
    {
        string connectionString =
         @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserTable WHERE UserName = @username AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", LogInFormUserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", LogInFormPassTxtBox.Text);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    con.Open();
                    sda.Fill(dt);

                    // DATA MATCH CHECK
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        AdminDashboard AD = new AdminDashboard();
                        AD.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password incorrect",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
          


            regis If = new regis();
            If.Show();
            this.Hide();
        }
    }
}
