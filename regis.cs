using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class regis : Form
    {
        // 🔗 Database connection string
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";

        public regis()
        {
            InitializeComponent();
            LoadRole();
        }

        // 🔹 Load Role into ComboBox
        private void LoadRole()
        {
            RegisFormRoleComBox.Items.Clear();
            RegisFormRoleComBox.Items.Add("Admin");
            RegisFormRoleComBox.Items.Add("Customer");
            RegisFormRoleComBox.Items.Add("Staff");
            RegisFormRoleComBox.SelectedIndex = 0;
        }
        // ===== AUTO-GENERATED EVENT PATCH METHODS =====
        // These methods exist only to satisfy Designer.cs references

        private void FullName_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void RegisFormUserNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // No action needed
        }
        // ===== QUICK PATCH FOR DESIGNER EVENT =====

       
        // ===== QUICK PATCH FOR CANCEL BUTTON EVENT =====

        private void Cancel_Click(object sender, EventArgs e)
        {
            // No action needed
        }





        // 🔹 SIGN UP BUTTON CLICK
        private void signup_Click(object sender, EventArgs e)
        {
            // 🔍 Basic validation
            if (RegisFormIDTxtForm.Text == "" ||
                RegisFormUserNameTxtBox.Text == "" ||
                RegisFormPasswordTxtBox.Text == "" ||
                RegisFormRoleComBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                // ✅ STEP 1: CHECK UNIQUE ID
                string checkQuery = "SELECT COUNT(*) FROM UserTable WHERE ID = @ID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@ID", RegisFormIDTxtForm.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This ID already exists. Please use a different ID.");
                    con.Close();
                    return;
                }

                // ✅ STEP 2: INSERT DATA
                string insertQuery =
                    "INSERT INTO UserTable (ID, UserName, Password, Role, Status) " +
                    "VALUES (@ID, @UserName, @Password, @Role, @Status)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(RegisFormIDTxtForm.Text));
                cmd.Parameters.AddWithValue("@UserName", RegisFormUserNameTxtBox.Text);
                cmd.Parameters.AddWithValue("@Password", RegisFormPasswordTxtBox.Text);
                cmd.Parameters.AddWithValue("@Role", RegisFormRoleComBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Status", 1); // 1 = Active

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sign Up Successful!");

                con.Close();

                // 🔁 Redirect to Login
                this.Hide();
                LogInForm login = new LogInForm();
                login.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔹 CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 🔹 LOGIN NOW BUTTON
        private void btnLoginNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }
    }
}
