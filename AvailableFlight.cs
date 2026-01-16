using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace US_Bangla_Airline_Management_App
{
    
    public partial class AvailableFlight : Form
    {
        public AvailableFlight()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=USB-DB;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM FlightTable", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvflight.DataSource = dtbl;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerForm = new CustomerDashboard();
            customerForm.ShowDialog();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.ShowDialog();
           
        }
     
        private void dgvflight_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvflight.Rows[e.RowIndex];

            
                string departure = row.Cells[1].Value?.ToString() ?? "";  
                string destination = row.Cells[2].Value?.ToString() ?? "";  
                string depDateTime = row.Cells[3].Value?.ToString() ?? "";  
                string arrDateTime = row.Cells[4].Value?.ToString() ?? ""; 
                string aircraftNo = row.Cells[6].Value?.ToString() ?? "";  
                string flightStatus = row.Cells[7].Value?.ToString() ?? "0"; 

                BookingForm bookingForm = new BookingForm(departure,
            destination,
            depDateTime,
            arrDateTime,
            aircraftNo,
            flightStatus);

                bookingForm.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("সমস্যা: " + ex.Message);
            }




        }
    }
}
