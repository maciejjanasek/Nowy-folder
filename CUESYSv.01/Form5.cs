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
    public partial class Form5 : Form
    {
        dbConn printDbConn = new dbConn();
        public Form5()
        {
            InitializeComponent();
            dbConfig();//database connection
            printDbConn.connect();
            if (printDbConn.connOpen() == true)
            {
                dataGridView.DataSource = printDbConn.qry("SELECT * FROM `tblbookings`").Tables[0];
            }
            printDbConn.connClose();
        }

        public bool dbConfig()
        {
            try
            {
                printDbConn.varConfigServer = "janasekm.cucstudents.org";
                printDbConn.varConfigDatabase = "BT_Airlines_Database";
                printDbConn.varConfigUser = "ac8453_CUEsys";
                printDbConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }


        private void loadBookingButton_Click(object sender, EventArgs e)//sending query to database and preload of data
        {
            if (IDTextBox.Text != "")
            {
                if (printDbConn.connOpen() == true)
                {
                    dataGridView.DataSource = printDbConn.qry("SELECT * FROM `tblbookings` WHERE `id`=" + IDTextBox.Text).Tables[0];
                }
                printDbConn.connClose();
                loadBookingButton.Visible = false;
                IDTextBox.Visible = false;
                label1.Visible = false;
                loadData.Visible = true;
            }
            else
            {
                MessageBox.Show("Booking id is empty!");
            }
        }

        private void loadData_Click(object sender, EventArgs e)//loading desired data for invoice and putting information in form to print
        {
            printInvoiceButton.Visible = true;
            printPreviewButton.Visible = true;
            loadData.Visible = false;

            if (IDTextBox.Text != "")
            {
                if (printDbConn.connOpen() == true)
                {
                    dataGridView.DataSource = printDbConn.qry("SELECT * FROM `tblbookings` WHERE `id` = " + IDTextBox.Text).Tables[0];
                }
                printDbConn.connClose();
            }
        }

        private void printPreviewButton_Click(object sender, EventArgs e)
        {

        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }


        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//invoice apperiance 
        {
            {
                e.Graphics.DrawString("BT AIRLINES", new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(300, 0));
                e.Graphics.DrawString("Customer Name and Surname: " + custContact.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 60));
                e.Graphics.DrawString("Flight ID: " + flightNumber.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 120));
                e.Graphics.DrawString("Departure City: " + departure.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 150));
                e.Graphics.DrawString("Departure Date: " + monthCalendar1, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 180));
                e.Graphics.DrawString("Departure Time: " + departureTime.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 210));
                e.Graphics.DrawString("Arrival City  " + arrival.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 240));
                e.Graphics.DrawString("Arrival Date: " + monthCalendar2, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 270));
                e.Graphics.DrawString("Arrival Time: " + arrivalTime.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 300));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 190));
                e.Graphics.DrawString("Tickets Type", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 330));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 220));
                e.Graphics.DrawString("Quantity", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 330));
                e.Graphics.DrawString("Adult: " + bookingCostAdult.Text + "£", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 360));
                e.Graphics.DrawString("Children: " + bookingCostChild.Text + "£", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 400));
                e.Graphics.DrawString("Infant: " + bookingCostInfant.Text + "£", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 430));
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 340));
                e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 520));
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)//specification for data form database
        {
            string date1 = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            string date2 = monthCalendar2.SelectionRange.Start.ToString("MM/dd/yyyy");
            if (dataGridView.SelectedRows.Count > 0)
            {
                custContact.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                flightNumber.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                departure.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                date1 = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                departureTime.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                arrival.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                date2 = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                arrivalTime.Text = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                bookingRoom.Text = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                bookingCostAdult.Text = dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                bookingCostChild.Text = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                bookingCostInfant.Text = dataGridView.SelectedRows[0].Cells[12].Value.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
