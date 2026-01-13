namespace US_Bangla_Airline_Management_App
{
    partial class SingleUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SingleUserFormUserIDLabel = new System.Windows.Forms.Label();
            this.SignleUserFormUserIDTxtBox = new System.Windows.Forms.TextBox();
            this.SignleUserFormUserNameLabel = new System.Windows.Forms.Label();
            this.SingleUserFormUserNameTxtBox = new System.Windows.Forms.TextBox();
            this.SingleUserFormRoleLabel = new System.Windows.Forms.Label();
            this.SingleUserFormRoleCmb = new System.Windows.Forms.ComboBox();
            this.SingleUserFormStatusLabel = new System.Windows.Forms.Label();
            this.SingleUserFormStatusCmbBox = new System.Windows.Forms.ComboBox();
            this.SingleUserFormPasswordLabel = new System.Windows.Forms.Label();
            this.SingleUserFormPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.SingleUserFormUpdateBtn = new System.Windows.Forms.Button();
            this.SingleUserFormBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ===== UserID Label =====
            this.SingleUserFormUserIDLabel.AutoSize = true;
            this.SingleUserFormUserIDLabel.Location = new System.Drawing.Point(80, 50);
            this.SingleUserFormUserIDLabel.Text = "User ID:";

            // ===== UserID TextBox =====
            this.SignleUserFormUserIDTxtBox.Location = new System.Drawing.Point(180, 50);
            this.SignleUserFormUserIDTxtBox.Size = new System.Drawing.Size(200, 22);
            this.SignleUserFormUserIDTxtBox.ReadOnly = true;

            // ===== UserName Label =====
            this.SignleUserFormUserNameLabel.AutoSize = true;
            this.SignleUserFormUserNameLabel.Location = new System.Drawing.Point(80, 100);
            this.SignleUserFormUserNameLabel.Text = "User Name:";

            // ===== UserName TextBox =====
            this.SingleUserFormUserNameTxtBox.Location = new System.Drawing.Point(180, 100);
            this.SingleUserFormUserNameTxtBox.Size = new System.Drawing.Size(200, 22);

            // ===== Password Label =====
            this.SingleUserFormPasswordLabel.AutoSize = true;
            this.SingleUserFormPasswordLabel.Location = new System.Drawing.Point(80, 150);
            this.SingleUserFormPasswordLabel.Text = "Password:";

            // ===== Password TextBox =====
            this.SingleUserFormPasswordTxtBox.Location = new System.Drawing.Point(180, 150);
            this.SingleUserFormPasswordTxtBox.Size = new System.Drawing.Size(200, 22);

            // ===== Role Label =====
            this.SingleUserFormRoleLabel.AutoSize = true;
            this.SingleUserFormRoleLabel.Location = new System.Drawing.Point(80, 200);
            this.SingleUserFormRoleLabel.Text = "Role:";

            // ===== Role ComboBox =====
            this.SingleUserFormRoleCmb.Location = new System.Drawing.Point(180, 200);
            this.SingleUserFormRoleCmb.Size = new System.Drawing.Size(150, 24);
            this.SingleUserFormRoleCmb.Items.AddRange(new object[] { "Admin", "Customer", "Counter Staff" });

            // ===== Status Label =====
            this.SingleUserFormStatusLabel.AutoSize = true;
            this.SingleUserFormStatusLabel.Location = new System.Drawing.Point(80, 250);
            this.SingleUserFormStatusLabel.Text = "Status:";

            // ===== Status ComboBox =====
            this.SingleUserFormStatusCmbBox.Location = new System.Drawing.Point(180, 250);
            this.SingleUserFormStatusCmbBox.Size = new System.Drawing.Size(120, 24);
            this.SingleUserFormStatusCmbBox.Items.AddRange(new object[] { "Active", "Inactive" });

            // ===== Update Button =====
            this.SingleUserFormUpdateBtn.Location = new System.Drawing.Point(80, 320);
            this.SingleUserFormUpdateBtn.Size = new System.Drawing.Size(150, 40);
            this.SingleUserFormUpdateBtn.Text = "Update User 💾";
            this.SingleUserFormUpdateBtn.Click += new System.EventHandler(this.SingleUserFormUpdateBtn_Click);

            // ===== Back Button =====
            this.SingleUserFormBackBtn.Location = new System.Drawing.Point(260, 320);
            this.SingleUserFormBackBtn.Size = new System.Drawing.Size(150, 40);
            this.SingleUserFormBackBtn.Text = "Back ⬅️";
            this.SingleUserFormBackBtn.Click += new System.EventHandler(this.SingleUserFormBackBtn_Click);

            // ===== Form Properties =====
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.SingleUserFormUserIDLabel);
            this.Controls.Add(this.SignleUserFormUserIDTxtBox);
            this.Controls.Add(this.SignleUserFormUserNameLabel);
            this.Controls.Add(this.SingleUserFormUserNameTxtBox);
            this.Controls.Add(this.SingleUserFormPasswordLabel);
            this.Controls.Add(this.SingleUserFormPasswordTxtBox);
            this.Controls.Add(this.SingleUserFormRoleLabel);
            this.Controls.Add(this.SingleUserFormRoleCmb);
            this.Controls.Add(this.SingleUserFormStatusLabel);
            this.Controls.Add(this.SingleUserFormStatusCmbBox);
            this.Controls.Add(this.SingleUserFormUpdateBtn);
            this.Controls.Add(this.SingleUserFormBackBtn);

            this.Text = "Edit User 👤";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label SingleUserFormUserIDLabel;
        private System.Windows.Forms.TextBox SignleUserFormUserIDTxtBox;
        private System.Windows.Forms.Label SignleUserFormUserNameLabel;
        private System.Windows.Forms.TextBox SingleUserFormUserNameTxtBox;
        private System.Windows.Forms.Label SingleUserFormRoleLabel;
        private System.Windows.Forms.ComboBox SingleUserFormRoleCmb;
        private System.Windows.Forms.Label SingleUserFormStatusLabel;
        private System.Windows.Forms.ComboBox SingleUserFormStatusCmbBox;
        private System.Windows.Forms.Label SingleUserFormPasswordLabel;
        private System.Windows.Forms.TextBox SingleUserFormPasswordTxtBox;
        private System.Windows.Forms.Button SingleUserFormUpdateBtn;
        private System.Windows.Forms.Button SingleUserFormBackBtn;
    }
}


