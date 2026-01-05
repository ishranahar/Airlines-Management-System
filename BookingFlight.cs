using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace US_Bangla_Airline_Management_App
{
    public partial class BookingFlight : Form
    {
        public BookingFlight()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string connection =
               @"Data Source=LAPTOP-5J5HOEO3;Initial Catalog=US-BanglaAirlineDB;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    SqlCommand sq = new SqlCommand(
@"INSERT INTO FlightsTable
(FlightID,Departure, Destination, DepartureDateTime, ArrivalDateTime, AvailableSeats, AircraftNo, Status)
VALUES
(@FlightID,@Departure, @Destination, @DepartureDT, @ArrivalDT, @AvailableSeats, @AircraftNo, @Status)",
conn
);

                    sq.Parameters.AddWithValue("@FlightID", textBox1.Text);
                    sq.Parameters.AddWithValue("@Departure", textBox4.Text);
                    sq.Parameters.AddWithValue("@Destination", textBox5.Text);
                  sq.Parameters.AddWithValue("@DepartureDT", dateTimePicker1.Value);
                    sq.Parameters.AddWithValue("@ArrivalDT", dateTimePicker2.Value);
                    sq.Parameters.AddWithValue("@AvailableSeats", textBox6.Text);
                    sq.Parameters.AddWithValue("@AircraftNo", textBox7.Text);
                    sq.Parameters.AddWithValue("@Status", textBox8.Text);


                    int rows = sq.ExecuteNonQuery();
                    MessageBox.Show("Rows inserted = " + rows);
                }

                MessageBox.Show("Booking added successfully");

                LogInForm lf = new LogInForm();
                lf.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Other error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
