
namespace US_Bangla_Airline_Management_App
{
    partial class AllUsers
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
            this.AllUsersTable = new System.Windows.Forms.DataGridView();
            this.AllUsersFormShowAllUsersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsersTable
            // 
            this.AllUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersTable.Location = new System.Drawing.Point(70, 12);
            this.AllUsersTable.Name = "AllUsersTable";
            this.AllUsersTable.RowHeadersWidth = 51;
            this.AllUsersTable.RowTemplate.Height = 24;
            this.AllUsersTable.Size = new System.Drawing.Size(567, 302);
            this.AllUsersTable.TabIndex = 0;
            // 
            // AllUsersFormShowAllUsersBtn
            // 
            this.AllUsersFormShowAllUsersBtn.Location = new System.Drawing.Point(255, 335);
            this.AllUsersFormShowAllUsersBtn.Name = "AllUsersFormShowAllUsersBtn";
            this.AllUsersFormShowAllUsersBtn.Size = new System.Drawing.Size(192, 40);
            this.AllUsersFormShowAllUsersBtn.TabIndex = 1;
            this.AllUsersFormShowAllUsersBtn.Text = "Show ";
            this.AllUsersFormShowAllUsersBtn.UseVisualStyleBackColor = true;
            this.AllUsersFormShowAllUsersBtn.Click += new System.EventHandler(this.AllUsersFormShowAllUsersBtn_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllUsersFormShowAllUsersBtn);
            this.Controls.Add(this.AllUsersTable);
            this.Name = "AllUsers";
            this.Text = "AllUsers";
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUsersTable;
        private System.Windows.Forms.Button AllUsersFormShowAllUsersBtn;
    }
}