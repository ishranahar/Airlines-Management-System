
namespace US_Bangla_Airline_Management_App
{
    partial class BookingFlight
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
            this.available = new System.Windows.Forms.Label();
            this.flightid = new System.Windows.Forms.Label();
            this.passeneger = new System.Windows.Forms.Label();
            this.nid = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.flightname = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DepartureDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrivalDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Location = new System.Drawing.Point(25, 24);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(165, 26);
            this.available.TabIndex = 0;
            this.available.Text = "Booking Flight";
            // 
            // flightid
            // 
            this.flightid.AutoSize = true;
            this.flightid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightid.Location = new System.Drawing.Point(23, 65);
            this.flightid.Name = "flightid";
            this.flightid.Size = new System.Drawing.Size(67, 20);
            this.flightid.TabIndex = 1;
            this.flightid.Text = "FlightID";
            // 
            // passeneger
            // 
            this.passeneger.AutoSize = true;
            this.passeneger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passeneger.Location = new System.Drawing.Point(23, 98);
            this.passeneger.Name = "passeneger";
            this.passeneger.Size = new System.Drawing.Size(138, 20);
            this.passeneger.TabIndex = 2;
            this.passeneger.Text = "Passenger Name";
            // 
            // nid
            // 
            this.nid.AutoSize = true;
            this.nid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nid.Location = new System.Drawing.Point(27, 129);
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(38, 20);
            this.nid.TabIndex = 3;
            this.nid.Text = "NID";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(27, 199);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(94, 20);
            this.destination.TabIndex = 4;
            this.destination.Text = "Destination";
            // 
            // flightname
            // 
            this.flightname.AutoSize = true;
            this.flightname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightname.Location = new System.Drawing.Point(23, 299);
            this.flightname.Name = "flightname";
            this.flightname.Size = new System.Drawing.Size(124, 20);
            this.flightname.TabIndex = 5;
            this.flightname.Text = "Available Seats";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(26, 165);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(48, 20);
            this.from.TabIndex = 6;
            this.from.Text = "From";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(197, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(211, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 22);
            this.textBox6.TabIndex = 12;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Red;
            this.save.Location = new System.Drawing.Point(244, 397);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 28);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Green;
            this.cancel.Location = new System.Drawing.Point(68, 397);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 28);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(292, 175);
            this.dataGridView1.TabIndex = 15;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DarkViolet;
            this.show.Location = new System.Drawing.Point(556, 282);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 28);
            this.show.TabIndex = 16;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Aircraft No";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(211, 331);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(178, 22);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(211, 359);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(178, 22);
            this.textBox8.TabIndex = 19;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(27, 359);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 20);
            this.status.TabIndex = 20;
            this.status.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 269);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // DepartureDateTime
            // 
            this.DepartureDateTime.AutoSize = true;
            this.DepartureDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureDateTime.Location = new System.Drawing.Point(27, 232);
            this.DepartureDateTime.Name = "DepartureDateTime";
            this.DepartureDateTime.Size = new System.Drawing.Size(157, 20);
            this.DepartureDateTime.TabIndex = 23;
            this.DepartureDateTime.Text = "DepartureDateTime";
            this.DepartureDateTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 24;
            // 
            // ArrivalDateTime
            // 
            this.ArrivalDateTime.AutoSize = true;
            this.ArrivalDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDateTime.Location = new System.Drawing.Point(23, 269);
            this.ArrivalDateTime.Name = "ArrivalDateTime";
            this.ArrivalDateTime.Size = new System.Drawing.Size(130, 20);
            this.ArrivalDateTime.TabIndex = 25;
            this.ArrivalDateTime.Text = "ArrivalDateTime";
            // 
            // BookingFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArrivalDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartureDateTime);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.flightname);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.nid);
            this.Controls.Add(this.passeneger);
            this.Controls.Add(this.flightid);
            this.Controls.Add(this.available);
            this.Name = "BookingFlight";
            this.Text = "BookingFlight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label available;
        private System.Windows.Forms.Label flightid;
        private System.Windows.Forms.Label passeneger;
        private System.Windows.Forms.Label nid;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label flightname;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label DepartureDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ArrivalDateTime;
    }
}