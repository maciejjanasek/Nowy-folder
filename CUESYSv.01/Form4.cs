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
    public partial class Form4 : Form
    {
        dbConn customerDbConn = new dbConn();
        public Form4()
        {
            InitializeComponent();
            dbConfig();//dtabase connection
            customerDbConn.connect();
            if (customerDbConn.connOpen() == true)
            {
                dataGridView1.DataSource = customerDbConn.qry("SELECT * FROM `tblcustomer`").Tables[0];
            }
            customerDbConn.connClose();
        }

        public bool dbConfig()
        {
            try
            {
                customerDbConn.varConfigServer = "janasekm.cucstudents.org";
                customerDbConn.varConfigDatabase = "BT_Airlines_Database";
                customerDbConn.varConfigUser = "ac8453_CUEsys";
                customerDbConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (customerDbConn.connOpen() == true)
            {
                customerDbConn.InsertCustomer(custNationality.Text, custContact.Text, custEmail.Text, custTelephone.Text, AddressLane1.Text, AddressLane2.Text, townCity.Text, postcode.Text);
            }
            custNationality.Text = custContact.Text = custEmail.Text = custTelephone.Text = AddressLane1.Text = AddressLane2.Text = townCity.Text = postcode.Text = "";
            customerDbConn.connClose();
            MessageBox.Show("Adding customer successful");
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (customerDbConn.connOpen() == true)
            {
                customerDbConn.UpdateCustomer(dataGridView1.SelectedCells[0].Value.ToString(), custNationality.Text, custContact.Text, custEmail.Text, custTelephone.Text, AddressLane1.Text, AddressLane2.Text, townCity.Text, postcode.Text);//Selection for desired record
                dataGridView1.DataSource = customerDbConn.qry("SELECT * FROM `tblcustomer`").Tables[0];
            }
            customerDbConn.connClose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))//Confirmation window
            {
                if (customerDbConn.connOpen() == true)
                {
                    customerDbConn.DeleteCustomer(dataGridView1.SelectedCells[0].Value.ToString());//Selection for desired record
                    dataGridView1.DataSource = customerDbConn.qry("SELECT * FROM `tblcustomer`").Tables[0];
                }
                customerDbConn.connClose();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
