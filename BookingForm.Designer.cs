
namespace US_Bangla_Airline_Management_App
{
    partial class BookingForm
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
            this.name = new System.Windows.Forms.Label();
            this.nid = new System.Windows.Forms.Label();
            this.ArrivalDateTime = new System.Windows.Forms.Label();
            this.textDepartureDateTime = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.FlightStatus = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.textDepartureDate = new System.Windows.Forms.TextBox();
            this.textArrivalDate = new System.Windows.Forms.TextBox();
            this.textFlightStatus = new System.Windows.Forms.TextBox();
            this.AircraftNo = new System.Windows.Forms.Label();
            this.textAircraftNo = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Form";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(31, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Full Name";
            // 
            // nid
            // 
            this.nid.AutoSize = true;
            this.nid.Location = new System.Drawing.Point(31, 124);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(26, 13);
            this.nid.TabIndex = 2;
            this.nid.Text = "NID";
            // 
            // ArrivalDateTime
            // 
            this.ArrivalDateTime.AutoSize = true;
            this.ArrivalDateTime.Location = new System.Drawing.Point(31, 298);
            this.ArrivalDateTime.Name = "ArrivalDateTime";
            this.ArrivalDateTime.Size = new System.Drawing.Size(82, 13);
            this.ArrivalDateTime.TabIndex = 3;
            this.ArrivalDateTime.Text = "ArrivalDateTime";
            // 
            // textDepartureDateTime
            // 
            this.textDepartureDateTime.AutoSize = true;
            this.textDepartureDateTime.Location = new System.Drawing.Point(30, 267);
            this.textDepartureDateTime.Name = "textDepartureDateTime";
            this.textDepartureDateTime.Size = new System.Drawing.Size(100, 13);
            this.textDepartureDateTime.TabIndex = 4;
            this.textDepartureDateTime.Text = "DepartureDateTime";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(30, 158);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(78, 13);
            this.phone.TabIndex = 5;
            this.phone.Text = "Phone Number";
            // 
            // FlightStatus
            // 
            this.FlightStatus.AutoSize = true;
            this.FlightStatus.Location = new System.Drawing.Point(31, 337);
            this.FlightStatus.Name = "FlightStatus";
            this.FlightStatus.Size = new System.Drawing.Size(62, 13);
            this.FlightStatus.TabIndex = 6;
            this.FlightStatus.Text = "FlightStatus";
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Location = new System.Drawing.Point(31, 230);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(60, 13);
            this.Destination.TabIndex = 7;
            this.Destination.Text = "Destination";
            // 
            // Departure
            // 
            this.Departure.AutoSize = true;
            this.Departure.Location = new System.Drawing.Point(30, 194);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(54, 13);
            this.Departure.TabIndex = 8;
            this.Departure.Text = "Departure";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 20);
            this.textBox3.TabIndex = 11;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(152, 194);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(201, 20);
            this.txtDeparture.TabIndex = 12;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(152, 230);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(201, 20);
            this.textDestination.TabIndex = 13;
            // 
            // textDepartureDate
            // 
            this.textDepartureDate.Location = new System.Drawing.Point(152, 267);
            this.textDepartureDate.Name = "textDepartureDate";
            this.textDepartureDate.Size = new System.Drawing.Size(201, 20);
            this.textDepartureDate.TabIndex = 14;
            // 
            // textArrivalDate
            // 
            this.textArrivalDate.Location = new System.Drawing.Point(152, 298);
            this.textArrivalDate.Name = "textArrivalDate";
            this.textArrivalDate.Size = new System.Drawing.Size(201, 20);
            this.textArrivalDate.TabIndex = 15;
            // 
            // textFlightStatus
            // 
            this.textFlightStatus.Location = new System.Drawing.Point(152, 330);
            this.textFlightStatus.Name = "textFlightStatus";
            this.textFlightStatus.Size = new System.Drawing.Size(201, 20);
            this.textFlightStatus.TabIndex = 16;
            // 
            // AircraftNo
            // 
            this.AircraftNo.AutoSize = true;
            this.AircraftNo.Location = new System.Drawing.Point(30, 373);
            this.AircraftNo.Name = "AircraftNo";
            this.AircraftNo.Size = new System.Drawing.Size(54, 13);
            this.AircraftNo.TabIndex = 19;
            this.AircraftNo.Text = "AircraftNo";
            // 
            // textAircraftNo
            // 
            this.textAircraftNo.Location = new System.Drawing.Point(152, 366);
            this.textAircraftNo.Name = "textAircraftNo";
            this.textAircraftNo.Size = new System.Drawing.Size(201, 20);
            this.textAircraftNo.TabIndex = 20;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(260, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 21;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Info;
            this.Save.Location = new System.Drawing.Point(442, 415);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textAircraftNo);
            this.Controls.Add(this.AircraftNo);
            this.Controls.Add(this.textFlightStatus);
            this.Controls.Add(this.textArrivalDate);
            this.Controls.Add(this.textDepartureDate);
            this.Controls.Add(this.textDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.FlightStatus);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.textDepartureDateTime);
            this.Controls.Add(this.ArrivalDateTime);
            this.Controls.Add(this.nid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label nid;
        private System.Windows.Forms.Label ArrivalDateTime;
        private System.Windows.Forms.Label textDepartureDateTime;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label FlightStatus;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.Label Departure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.TextBox textDepartureDate;
        private System.Windows.Forms.TextBox textArrivalDate;
        private System.Windows.Forms.TextBox textFlightStatus;
        private System.Windows.Forms.Label AircraftNo;
        private System.Windows.Forms.TextBox textAircraftNo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Save;
    }
}