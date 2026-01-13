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
       // string connectionString =  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";
        public LogInForm()
        {
            InitializeComponent();
        }

       

private void LogInButton_Click(object sender, EventArgs e)
    {
       
        string username = LogInFormUserNameTextBox.Text;
        string password = LogInFormPassTxtBox.Text;

      
        if (username == "" || password == "")
        {
            MessageBox.Show("Please enter username and password");
            return;
        }

       
        bool isValidUser = User.ReadUser(username, password);

        if (isValidUser)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }
        else
        {
            MessageBox.Show(
                "Username or Password incorrect",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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
