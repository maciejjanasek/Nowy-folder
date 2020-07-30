using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CUESYSv._01
{
    public partial class Form3 : Form
    {
        dbConn searchDbConn = new dbConn();
        public Form3()
        {
            InitializeComponent();
            dbConfig();//databse connection
            searchDbConn.connect();
            if (searchDbConn.connOpen() == true)
            {
                dataGridView1.DataSource = searchDbConn.qry("SELECT * FROM `tblflights`").Tables[0];
            }
            searchDbConn.connClose();
        }


        public bool dbConfig()
        {
            try
            {
                searchDbConn.varConfigServer = "janasekm.cucstudents.org";
                searchDbConn.varConfigDatabase = "BT_Airlines_Database";
                searchDbConn.varConfigUser = "ac8453_CUEsys";
                searchDbConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchFlightButton_Click(object sender, EventArgs e) 
        { 
            if (searchDbConn.connOpen() == true)
            { 
                searchDbConn.SearchFlight(departureTextBox.Text, arrivalTextBox.Text); 
                dataGridView1.DataSource = searchDbConn.qry("SELECT * FROM `tblflights` WHERE departure='" + departureTextBox.Text + "' AND arrival='" + arrivalTextBox.Text + "'").Tables[0];
            } 
            searchDbConn.connClose();
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

