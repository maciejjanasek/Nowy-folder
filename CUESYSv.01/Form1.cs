using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CUESYSv._01
{
    public partial class Form1 : Form
    {
        ///// NOTES START //////////////////////////////////////////////////////////
        // Should include log items stored on database
        // Bookings only in single hour "slots", would be better to custom set
        // Cannot search for booking (by room, date or customer)
        // Only view and edit upcoming x days
        // User+Pass check, insecure - later versions should use a database lookup
        // formatting odd on maximize/resize/different screen resolutions
        // menu is shown when software ran, this allows modification of customer entries before login - not secure
        // devlog out of sync with actions
        // autoscroll devlogs
        // need to hide menu bar on start (good for debug though)
        ///// NOTES END ////////////////////////////////////////////////////////////


        ///// VARIABLES START //////////////////////////////////////////////////////
        dbConn mysqlConn = new dbConn();
        ///// VARIABLES END ////////////////////////////////////////////////////////

        ///// METHODS START ////////////////////////////////////////////////////////
        public void devLogs(string logItem)
        {//Write development log to DevLog
            using (StreamWriter devlog = new StreamWriter("DevLog.txt", append: true))
            { devlog.WriteLine(DateTime.Now + " --- " + logItem); }//Concat current time and logItem and write to DevLog file
        }
        public bool dbConfig()
        {
            try
            {
                mysqlConn.varConfigServer = "janasekm.cucstudents.org";
                mysqlConn.varConfigDatabase = "BT_Airlines_Database";
                mysqlConn.varConfigUser = "ac8453_CUEsys";
                mysqlConn.varConfigPass = "Password123!";
                return true;
            }
            catch { return false; }
        }

        public void resetControls(string newFocus)
        {//Hide all controls and only show those needed
            devLogs("resetControls triggered");
            foreach (Control control in this.Controls) { control.Visible = false; }//Hide all controls
            lbCueSys.Visible = true;//Show logo
            panClock.Visible = true;//Show clock panel
            mainMenu.Visible = true;//Show menu
            foreach (var clockLbl in panClock.Controls.OfType<Label>()){ clockLbl.Visible = true; };//Show clock in panel
            switch (newFocus)//Use control statement to selectively show controls based on newFocus argument
            {
                case "Program started":
                    lbUserName.Visible = lbUserPass.Visible = tbUserName.Visible = tbUserPass.Visible = btLogin.Visible = true;//make login controls visible
                    searchFlightToolStripMenuItem.Visible = roomsToolStripMenuItem.Visible = customerToolStripMenuItem.Visible = printInvoiceToolStripMenuItem.Visible = fileToolStripMenuItem.Visible = manageFlightsToolStripMenuItem.Visible = false;
                        devLogs("Login controls visible, options hidden");
                    break;
                case "landing":
                    welcomeLabel.Visible = true;
                    break;
                case "Exit":
                    Application.Exit();
                    break;
                case "search flight": 
                    searchFlightToolStripMenuItem.Visible = true;
                    break;
                default:
                    devLogs("resetControls default case triggered, no controls visible");
                    break;
            }
            devLogs("Focus changed to " + newFocus);
        }
        ///// METHODS END //////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("DevLog.txt", String.Empty);//Clear contents of DevLog
            this.ActiveControl = tbUserName;
            dbConfig();
            mysqlConn.connect();
            resetControls("Program started");
            devLogs("Program started");
        }

        ///// EVENTS START /////////////////////////////////////////////////////////
        private void timeClock_Tick(object sender, EventArgs e)
        {//Timer to control clock
            lbClockTime.Text = DateTime.Now.ToString("HH:mm");
            lbClockSeconds.Text = DateTime.Now.ToString("ss");
            lbClockDate.Text = DateTime.Now.ToString("ddd")+"  "+DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            devLogs("Login button clicked");
            if (tbUserName.Text == "admin" && tbUserPass.Text == "admin" )
            { 
                resetControls("landing"); devLogs("Login success for user " + tbUserName.Text);
                searchFlightToolStripMenuItem.Visible = roomsToolStripMenuItem.Visible = customerToolStripMenuItem.Visible = fileToolStripMenuItem.Visible = printInvoiceToolStripMenuItem.Visible = manageFlightsToolStripMenuItem.Visible = true;
            }//Login success
            else
            { MessageBox.Show("Sorry, wrong password/user combo!"); devLogs("Login failure for user " + tbUserName.Text); }//Login failure
            tbUserName.Text = ""; tbUserPass.Text = ""; //Clear logon credentials
           
        }
        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//Change focus to password box on enter key
                this.ActiveControl = tbUserPass;
                devLogs("enter key detected in tbUserName");
            }
        }
        private void tbUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//Trigger login button on enter key
                btLogin_Click(this, new EventArgs());
                devLogs("enter key detected in tbUserPass");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {//Generic keyboard shortcuts
            if (keyData == (Keys.Alt | Keys.L))
            {
                devLogs("alt-l shortcut intercepted");
                resetControls("Program started");
                return true;
            }
            if (keyData == (Keys.Alt | Keys.X))
            {
                devLogs("alt-x shortcut intercepted");
                resetControls("Exit");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void viewDevLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form devForm = new Form();
            devForm.Text = "DevLogs";
            RichTextBox rtbDevLogs = new RichTextBox();
            Timer timerRefreshDevLogs = new Timer();
            timerRefreshDevLogs.Interval = 2500;
            timerRefreshDevLogs.Tick += new EventHandler(devRefreshTimer_Tick);
            timerRefreshDevLogs.Start();
            rtbDevLogs.Location = new Point(0, 0);
            rtbDevLogs.Size = new Size(300, 380);
            rtbDevLogs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            devForm.Size = new Size(300, 400);
            devForm.Controls.Add(rtbDevLogs);
            devLogs("devlogs viewed");
            void devRefreshTimer_Tick(object timer, EventArgs args)
            {
                rtbDevLogs.Text = "";
                string line;
                try
                {
                    StreamReader sr = new StreamReader("DevLog.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        rtbDevLogs.Text += line + "\r\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex) { devLogs("error reading devlogs"); }
            }
            devForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControls("Program started");
            devLogs("user logged out");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetControls("Exit"); 
            devLogs("application exit request");
        }

        private void searchFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Visible = true;
            devLogs("Search flight initiated");
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            devLogs("book room request");
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Visible = true;
            devLogs("create customer initiated");
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Visible = true;
            devLogs(("print invoice initaited"));
        }

        private void manageFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Visible = true;
            devLogs("flights managing initiated");
        }
    }
}
