using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class Form2 : Form
    {
        dbConn dbsqlConnection = new dbConn();
        public Form2()
        {
            InitializeComponent();
            dbConfig();
            dbsqlConnection.connect();
            if (dbsqlConnection.connOpen() == true)
            {
                dataGridView1.DataSource = dbsqlConnection.qry("SELECT * FROM `tblbookings`").Tables[0];
            }
            dbsqlConnection.connClose();
        }

        public bool dbConfig()
        {
            try
            {
                dbsqlConnection.varConfigServer = "janasekm.cucstudents.org";
                dbsqlConnection.varConfigDatabase = "BT_Airlines_Database";
                dbsqlConnection.varConfigUser = "ac8453_CUEsys";
                dbsqlConnection.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookingButton_Click(object sender, EventArgs e)
        {
            dbsqlConnection.connOpen();
            string date1 = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("MM/dd/yyyy");
            string varPaid;
            if (checkBoxPaid.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            dbsqlConnection.InsertBooking(custContact.Text, flightNumber.Text, departure.Text, date1, departureTime.Text, arrival.Text, date2, arrivalTime.Text, bookingRoom.Text, bookingCostAdult.Text, bookingCostChild.Text, bookingCostInfant.Text, varPaid);
            MessageBox.Show("Booking succesful");
        }

        private void custContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void departure_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        private void bookingRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookingCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPaid_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bookingUpdateButton_Click(object sender, EventArgs e)
        {
            string date1 = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("MM/dd/yyyy");
            string varPaid;
            if (checkBoxPaid.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            if (dbsqlConnection.connOpen() == true)
            {
                dbsqlConnection.UpdateBooking(dataGridView1.SelectedCells[0].Value.ToString(), custContact.Text, flightNumber.Text, departure.Text, date1, departureTime.Text, arrival.Text, date2, arrivalTime.Text, bookingRoom.Text, bookingCostAdult.Text, bookingCostChild.Text, bookingCostInfant.Text, varPaid);
                dataGridView1.DataSource = dbsqlConnection.qry("SELECT * FROM `tblbookings`").Tables[0];
            }
            dbsqlConnection.connClose();
        }

        private void deleteBookingButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (dbsqlConnection.connOpen() == true)
                {
                    dbsqlConnection.DeleteBooking(dataGridView1.SelectedCells[0].Value.ToString());
                    dataGridView1.DataSource = dbsqlConnection.qry("SELECT * FROM `tblbookings`").Tables[0];
                }
                dbsqlConnection.connClose();
            }
        }
    }
}
