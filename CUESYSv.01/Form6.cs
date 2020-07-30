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
    public partial class Form6 : Form
    {
        dbConn manageFlightDbConn = new dbConn();
        public Form6()
        {
            InitializeComponent();
            dbConfig();//database connection
            manageFlightDbConn.connect();
            if (manageFlightDbConn.connOpen() == true)
            {
                dataGridView1.DataSource = manageFlightDbConn.qry("SELECT * FROM `tblflights`").Tables[0];
            }
            manageFlightDbConn.connClose();
        }

        public bool dbConfig()
        {
            try
            {
                manageFlightDbConn.varConfigServer = "janasekm.cucstudents.org";
                manageFlightDbConn.varConfigDatabase = "BT_Airlines_Database";
                manageFlightDbConn.varConfigUser = "ac8453_CUEsys";
                manageFlightDbConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }
        private void addFlightButton_Click(object sender, EventArgs e)
        {
            manageFlightDbConn.connOpen();
            string date1 = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("MM/dd/yyyy");
            manageFlightDbConn.InsertFlight(flightNumber.Text,departure.Text, date1, departureTime.Text, arrival.Text, date2, arrivalTime.Text);
            MessageBox.Show("Booking succesful");
        }

        private void updateFlightButton_Click(object sender, EventArgs e)
        {
            string date1 = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("MM/dd/yyyy");

            if (manageFlightDbConn.connOpen() == true)
            {
                manageFlightDbConn.UpdateFlight(dataGridView1.SelectedCells[0].Value.ToString(), departure.Text, date1, departureTime.Text, arrival.Text, date2, arrivalTime.Text);//Selection for desired record
                dataGridView1.DataSource = manageFlightDbConn.qry("SELECT * FROM `tblflights`").Tables[0];
            }
            manageFlightDbConn.connClose();
        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))//confirmation window
            {
                if (manageFlightDbConn.connOpen() == true)
                {
                    manageFlightDbConn.DeleteFlight(dataGridView1.SelectedCells[0].Value.ToString());//Selection for desired record
                    dataGridView1.DataSource = manageFlightDbConn.qry("SELECT * FROM `tblflights`").Tables[0];
                }
                manageFlightDbConn.connClose();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
