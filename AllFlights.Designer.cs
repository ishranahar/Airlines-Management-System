namespace US_Bangla_Airline_Management_App
{
    partial class AllFlights
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel MainPanel;

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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AllFlightsFormFlightDataTable = new System.Windows.Forms.DataGridView();
            this.AllFlightsFormAddFlightBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormEditFlightBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormDeleteBtn = new System.Windows.Forms.Button();
            this.AllFlightsFormBackBtn = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllFlightsFormFlightDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.AllFlightsFormFlightDataTable);
            this.MainPanel.Controls.Add(this.AllFlightsFormAddFlightBtn);
            this.MainPanel.Controls.Add(this.AllFlightsFormEditFlightBtn);
            this.MainPanel.Controls.Add(this.AllFlightsFormDeleteBtn);
            this.MainPanel.Controls.Add(this.AllFlightsFormBackBtn);
            this.MainPanel.Location = new System.Drawing.Point(50, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 360);
            this.MainPanel.TabIndex = 0;
            // 
            // AllFlightsFormFlightDataTable
            // 
            this.AllFlightsFormFlightDataTable.AllowUserToAddRows = false;
            this.AllFlightsFormFlightDataTable.AllowUserToDeleteRows = false;
            this.AllFlightsFormFlightDataTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.AllFlightsFormFlightDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllFlightsFormFlightDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllFlightsFormFlightDataTable.Location = new System.Drawing.Point(20, 20);
            this.AllFlightsFormFlightDataTable.MultiSelect = false;
            this.AllFlightsFormFlightDataTable.Name = "AllFlightsFormFlightDataTable";
            this.AllFlightsFormFlightDataTable.ReadOnly = true;
            this.AllFlightsFormFlightDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllFlightsFormFlightDataTable.Size = new System.Drawing.Size(655, 200);
            this.AllFlightsFormFlightDataTable.TabIndex = 0;
            // 
            // AllFlightsFormAddFlightBtn
            // 
            this.AllFlightsFormAddFlightBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AllFlightsFormAddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightsFormAddFlightBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AllFlightsFormAddFlightBtn.ForeColor = System.Drawing.Color.White;
            this.AllFlightsFormAddFlightBtn.Location = new System.Drawing.Point(20, 250);
            this.AllFlightsFormAddFlightBtn.Name = "AllFlightsFormAddFlightBtn";
            this.AllFlightsFormAddFlightBtn.Size = new System.Drawing.Size(150, 45);
            this.AllFlightsFormAddFlightBtn.TabIndex = 1;
            this.AllFlightsFormAddFlightBtn.Text = "Add Flight";
            this.AllFlightsFormAddFlightBtn.UseVisualStyleBackColor = false;
            this.AllFlightsFormAddFlightBtn.Click += new System.EventHandler(this.AllFlightsFormAddFlightBtn_Click);
            // 
            // AllFlightsFormEditFlightBtn
            // 
            this.AllFlightsFormEditFlightBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.AllFlightsFormEditFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightsFormEditFlightBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AllFlightsFormEditFlightBtn.ForeColor = System.Drawing.Color.Black;
            this.AllFlightsFormEditFlightBtn.Location = new System.Drawing.Point(190, 250);
            this.AllFlightsFormEditFlightBtn.Name = "AllFlightsFormEditFlightBtn";
            this.AllFlightsFormEditFlightBtn.Size = new System.Drawing.Size(150, 45);
            this.AllFlightsFormEditFlightBtn.TabIndex = 2;
            this.AllFlightsFormEditFlightBtn.Text = "Edit Flight";
            this.AllFlightsFormEditFlightBtn.UseVisualStyleBackColor = false;
            this.AllFlightsFormEditFlightBtn.Click += new System.EventHandler(this.AllFlightsFormEditFlightBtn_Click);
            // 
            // AllFlightsFormDeleteBtn
            // 
            this.AllFlightsFormDeleteBtn.BackColor = System.Drawing.Color.Firebrick;
            this.AllFlightsFormDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightsFormDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AllFlightsFormDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.AllFlightsFormDeleteBtn.Location = new System.Drawing.Point(360, 250);
            this.AllFlightsFormDeleteBtn.Name = "AllFlightsFormDeleteBtn";
            this.AllFlightsFormDeleteBtn.Size = new System.Drawing.Size(150, 45);
            this.AllFlightsFormDeleteBtn.TabIndex = 3;
            this.AllFlightsFormDeleteBtn.Text = "Delete Flight";
            this.AllFlightsFormDeleteBtn.UseVisualStyleBackColor = false;
            this.AllFlightsFormDeleteBtn.Click += new System.EventHandler(this.AllFlightsFormDeleteBtn_Click);
            // 
            // AllFlightsFormBackBtn
            // 
            this.AllFlightsFormBackBtn.BackColor = System.Drawing.Color.Gray;
            this.AllFlightsFormBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightsFormBackBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AllFlightsFormBackBtn.ForeColor = System.Drawing.Color.White;
            this.AllFlightsFormBackBtn.Location = new System.Drawing.Point(525, 250);
            this.AllFlightsFormBackBtn.Name = "AllFlightsFormBackBtn";
            this.AllFlightsFormBackBtn.Size = new System.Drawing.Size(150, 45);
            this.AllFlightsFormBackBtn.TabIndex = 4;
            this.AllFlightsFormBackBtn.Text = "Back";
            this.AllFlightsFormBackBtn.UseVisualStyleBackColor = false;
            this.AllFlightsFormBackBtn.Click += new System.EventHandler(this.AllFlightsFormBackBtn_Click);
            // 
            // AllFlights
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AllFlights";
            this.Text = "All Flights";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllFlightsFormFlightDataTable)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView AllFlightsFormFlightDataTable;
        private System.Windows.Forms.Button AllFlightsFormAddFlightBtn;
        private System.Windows.Forms.Button AllFlightsFormEditFlightBtn;
        private System.Windows.Forms.Button AllFlightsFormDeleteBtn;
        private System.Windows.Forms.Button AllFlightsFormBackBtn;
    }
}

