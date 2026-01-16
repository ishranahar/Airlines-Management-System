
namespace US_Bangla_Airline_Management_App
{
    partial class AvailableFlight
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvflight = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dgvflight
            // 
            this.dgvflight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflight.Location = new System.Drawing.Point(30, 110);
            this.dgvflight.Name = "dgvflight";
            this.dgvflight.Size = new System.Drawing.Size(739, 260);
            this.dgvflight.TabIndex = 1;
            this.dgvflight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvflight_CellClick);
            this.dgvflight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.LightGray;
            this.show.Location = new System.Drawing.Point(351, 61);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 2;
            this.show.Text = "show List";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.Location = new System.Drawing.Point(241, 396);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(301, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Flight List";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LightCoral;
            this.confirm.Location = new System.Drawing.Point(459, 396);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // AvailableFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.show);
            this.Controls.Add(this.dgvflight);
            this.Controls.Add(this.label1);
            this.Name = "AvailableFlight";
            this.Text = "AvailableFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dgvflight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvflight;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm;
    }
}