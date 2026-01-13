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
    public partial class AllUsers : Form
    {
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";
        public AllUsers()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                LoadAllUsers();
            }
        }



        private void LoadAllUsers()
        {
            AllUsersTable.DataSource = User.GetAllUsers();
        }

        private void SelectUserBtn_Click(object sender, EventArgs e)
        {


                if (AllUsersTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user");
                    return;
                }

               
                DataGridViewRow row = AllUsersTable.SelectedRows[0];

             
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string username = row.Cells["UserName"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();
                int status = Convert.ToInt32(row.Cells["Status"].Value);

               
                SingleUser su = new SingleUser(id, username, role, status);
                su.ShowDialog();

                // 4️⃣ Refresh table after update
                LoadAllUsers();
            

        }

        private void AllUsersFormDeleteUserBtn_Click(object sender, EventArgs e)
        {


            
                if (AllUsersTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user");
                    return;
                }

                // Get selected row
                DataGridViewRow row = AllUsersTable.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);

                // Confirmation
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    User.DeleteUser(id);
                    MessageBox.Show("User deleted successfully");

                    // Refresh table
                    LoadAllUsers();
                }
            






        }

        private void AllUsersBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard a = new AdminDashboard();
            a.Show();

        }
    }
}
