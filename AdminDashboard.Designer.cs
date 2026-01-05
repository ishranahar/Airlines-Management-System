
namespace US_Bangla_Airline_Management_App
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminDashboardFlightListBtn = new System.Windows.Forms.Button();
            this.AdminDashBoardFlightBookingListBtn = new System.Windows.Forms.Button();
            this.AdminDashboardProfileBtn = new System.Windows.Forms.Button();
            this.AdminDashboardBackBtn = new System.Windows.Forms.Button();
            this.AdminDashBoardUserList = new System.Windows.Forms.Button();
            this.AdminDashBoardTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminDashboardFlightListBtn
            // 
            this.AdminDashboardFlightListBtn.Location = new System.Drawing.Point(36, 221);
            this.AdminDashboardFlightListBtn.Name = "AdminDashboardFlightListBtn";
            this.AdminDashboardFlightListBtn.Size = new System.Drawing.Size(198, 65);
            this.AdminDashboardFlightListBtn.TabIndex = 0;
            this.AdminDashboardFlightListBtn.Text = "Flight List";
            this.AdminDashboardFlightListBtn.UseVisualStyleBackColor = true;
            // 
            // AdminDashBoardFlightBookingListBtn
            // 
            this.AdminDashBoardFlightBookingListBtn.Location = new System.Drawing.Point(552, 221);
            this.AdminDashBoardFlightBookingListBtn.Name = "AdminDashBoardFlightBookingListBtn";
            this.AdminDashBoardFlightBookingListBtn.Size = new System.Drawing.Size(195, 65);
            this.AdminDashBoardFlightBookingListBtn.TabIndex = 1;
            this.AdminDashBoardFlightBookingListBtn.Text = "Flight Booking List";
            this.AdminDashBoardFlightBookingListBtn.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardProfileBtn
            // 
            this.AdminDashboardProfileBtn.Location = new System.Drawing.Point(21, 28);
            this.AdminDashboardProfileBtn.Name = "AdminDashboardProfileBtn";
            this.AdminDashboardProfileBtn.Size = new System.Drawing.Size(135, 54);
            this.AdminDashboardProfileBtn.TabIndex = 2;
            this.AdminDashboardProfileBtn.Text = "Profile";
            this.AdminDashboardProfileBtn.UseVisualStyleBackColor = true;
            this.AdminDashboardProfileBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminDashboardBackBtn
            // 
            this.AdminDashboardBackBtn.Location = new System.Drawing.Point(350, 359);
            this.AdminDashboardBackBtn.Name = "AdminDashboardBackBtn";
            this.AdminDashboardBackBtn.Size = new System.Drawing.Size(109, 44);
            this.AdminDashboardBackBtn.TabIndex = 3;
            this.AdminDashboardBackBtn.Text = "Back ";
            this.AdminDashboardBackBtn.UseVisualStyleBackColor = true;
            // 
            // AdminDashBoardUserList
            // 
            this.AdminDashBoardUserList.Location = new System.Drawing.Point(303, 221);
            this.AdminDashBoardUserList.Name = "AdminDashBoardUserList";
            this.AdminDashBoardUserList.Size = new System.Drawing.Size(190, 65);
            this.AdminDashBoardUserList.TabIndex = 4;
            this.AdminDashBoardUserList.Text = "User List";
            this.AdminDashBoardUserList.UseVisualStyleBackColor = true;
            this.AdminDashBoardUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserListAction);
            // 
            // AdminDashBoardTitleLabel
            // 
            this.AdminDashBoardTitleLabel.AutoSize = true;
            this.AdminDashBoardTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDashBoardTitleLabel.Location = new System.Drawing.Point(300, 65);
            this.AdminDashBoardTitleLabel.Name = "AdminDashBoardTitleLabel";
            this.AdminDashBoardTitleLabel.Size = new System.Drawing.Size(257, 32);
            this.AdminDashBoardTitleLabel.TabIndex = 5;
            this.AdminDashBoardTitleLabel.Text = "Admin Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDashBoardTitleLabel);
            this.Controls.Add(this.AdminDashBoardUserList);
            this.Controls.Add(this.AdminDashboardBackBtn);
            this.Controls.Add(this.AdminDashboardProfileBtn);
            this.Controls.Add(this.AdminDashBoardFlightBookingListBtn);
            this.Controls.Add(this.AdminDashboardFlightListBtn);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminDashboardFlightListBtn;
        private System.Windows.Forms.Button AdminDashBoardFlightBookingListBtn;
        private System.Windows.Forms.Button AdminDashboardProfileBtn;
        private System.Windows.Forms.Button AdminDashboardBackBtn;
        private System.Windows.Forms.Button AdminDashBoardUserList;
        private System.Windows.Forms.Label AdminDashBoardTitleLabel;
    }
}