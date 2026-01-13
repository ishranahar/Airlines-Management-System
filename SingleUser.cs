using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class SingleUser : Form
    {
        int userId;

        public SingleUser(int id, string username, string role, int status)
        {
            InitializeComponent();

            userId = id;

            SignleUserFormUserIDTxtBox.Text = id.ToString();
            SingleUserFormUserNameTxtBox.Text = username;
            SingleUserFormRoleCmb.SelectedItem = role;
            SingleUserFormStatusCmbBox.SelectedIndex = status == 1 ? 0 : 1;
        }

        private void SingleUserFormUpdateBtn_Click(object sender, EventArgs e)
        {
            int id = userId;
            string username = SingleUserFormUserNameTxtBox.Text;
            string password = SingleUserFormPasswordTxtBox.Text;
            string role = SingleUserFormRoleCmb.SelectedItem.ToString();
            int status = SingleUserFormStatusCmbBox.SelectedIndex == 0 ? 1 : 0;

            // 🔹 Duplicate username check
            if (User.IsUserNameTaken(username, id))
            {
                MessageBox.Show(
                    "Username already exists. Please choose another one.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            User.UpdateUser(id, username, password, role, status);

            MessageBox.Show("User updated successfully");
            this.Close();
        }

        private void SingleUserFormBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllUsers a = new AllUsers();
            a.Show();

        }
    }
}
