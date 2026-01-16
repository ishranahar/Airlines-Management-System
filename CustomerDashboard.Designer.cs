
namespace US_Bangla_Airline_Management_App
{
    partial class CustomerDashboard
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
            this.CustomerDashBoardTitleLabel = new System.Windows.Forms.Label();
            this.AdminDashboardLogOutBtn = new System.Windows.Forms.Button();
            this.AdminDashboardProfileBtn = new System.Windows.Forms.Button();
            this.AvailableFlightBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerDashBoardTitleLabel
            // 
            this.CustomerDashBoardTitleLabel.AutoSize = true;
            this.CustomerDashBoardTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.CustomerDashBoardTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.CustomerDashBoardTitleLabel.Location = new System.Drawing.Point(240, 37);
            this.CustomerDashBoardTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerDashBoardTitleLabel.Name = "CustomerDashBoardTitleLabel";
            this.CustomerDashBoardTitleLabel.Size = new System.Drawing.Size(256, 32);
            this.CustomerDashBoardTitleLabel.TabIndex = 8;
            this.CustomerDashBoardTitleLabel.Text = "Customer Dashboard";
            // 
            // AdminDashboardLogOutBtn
            // 
            this.AdminDashboardLogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.AdminDashboardLogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardLogOutBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardLogOutBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardLogOutBtn.Location = new System.Drawing.Point(417, 341);
            this.AdminDashboardLogOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminDashboardLogOutBtn.Name = "AdminDashboardLogOutBtn";
            this.AdminDashboardLogOutBtn.Size = new System.Drawing.Size(196, 40);
            this.AdminDashboardLogOutBtn.TabIndex = 10;
            this.AdminDashboardLogOutBtn.Text = "🚪 Log Out";
            this.AdminDashboardLogOutBtn.UseVisualStyleBackColor = false;
            this.AdminDashboardLogOutBtn.Click += new System.EventHandler(this.AdminDashboardLogOutBtn_Click);
            // 
            // AdminDashboardProfileBtn
            // 
            this.AdminDashboardProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AdminDashboardProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboardProfileBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AdminDashboardProfileBtn.ForeColor = System.Drawing.Color.White;
            this.AdminDashboardProfileBtn.Location = new System.Drawing.Point(589, 29);
            this.AdminDashboardProfileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AdminDashboardProfileBtn.Name = "AdminDashboardProfileBtn";
            this.AdminDashboardProfileBtn.Size = new System.Drawing.Size(170, 56);
            this.AdminDashboardProfileBtn.TabIndex = 11;
            this.AdminDashboardProfileBtn.Text = " Profile";
            this.AdminDashboardProfileBtn.UseVisualStyleBackColor = false;
            // 
            // AvailableFlightBtn
            // 
            this.AvailableFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AvailableFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailableFlightBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AvailableFlightBtn.ForeColor = System.Drawing.Color.White;
            this.AvailableFlightBtn.Location = new System.Drawing.Point(246, 146);
            this.AvailableFlightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AvailableFlightBtn.Name = "AvailableFlightBtn";
            this.AvailableFlightBtn.Size = new System.Drawing.Size(259, 70);
            this.AvailableFlightBtn.TabIndex = 13;
            this.AvailableFlightBtn.Text = "✈ Available Flight";
            this.AvailableFlightBtn.UseVisualStyleBackColor = false;
            this.AvailableFlightBtn.Click += new System.EventHandler(this.AvailableFlightBtn_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Blue;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(184, 341);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(196, 40);
            this.Back.TabIndex = 14;
            this.Back.Text = "🚪 Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CustomerDashBoardTitleLabel);
            this.Controls.Add(this.AdminDashboardLogOutBtn);
            this.Controls.Add(this.AdminDashboardProfileBtn);
            this.Controls.Add(this.AvailableFlightBtn);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerDashBoardTitleLabel;
        private System.Windows.Forms.Button AdminDashboardLogOutBtn;
        private System.Windows.Forms.Button AdminDashboardProfileBtn;
        private System.Windows.Forms.Button AvailableFlightBtn;
        private System.Windows.Forms.Button Back;
    }
}