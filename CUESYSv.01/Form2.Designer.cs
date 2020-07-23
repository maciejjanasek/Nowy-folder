namespace CUESYSv._01
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.custContact = new System.Windows.Forms.TextBox();
            this.flightNumber = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.bookingCostAdult = new System.Windows.Forms.TextBox();
            this.bookingRoom = new System.Windows.Forms.TextBox();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.bookingButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.departureTime = new System.Windows.Forms.TextBox();
            this.bookingCostInfant = new System.Windows.Forms.TextBox();
            this.bookingCostChild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingUpdateButton = new System.Windows.Forms.Button();
            this.deleteBookingButton = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.arrival = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Booking Room";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Booking Cost Adult";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Booking Paid";
            // 
            // custContact
            // 
            this.custContact.Location = new System.Drawing.Point(138, 47);
            this.custContact.Name = "custContact";
            this.custContact.Size = new System.Drawing.Size(100, 20);
            this.custContact.TabIndex = 12;
            this.custContact.TextChanged += new System.EventHandler(this.custContact_TextChanged);
            // 
            // flightNumber
            // 
            this.flightNumber.Location = new System.Drawing.Point(138, 77);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(100, 20);
            this.flightNumber.TabIndex = 13;
            this.flightNumber.TextChanged += new System.EventHandler(this.flightNumber_TextChanged);
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(138, 108);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(100, 20);
            this.departure.TabIndex = 14;
            this.departure.TextChanged += new System.EventHandler(this.departure_TextChanged);
            // 
            // bookingCostAdult
            // 
            this.bookingCostAdult.Location = new System.Drawing.Point(138, 194);
            this.bookingCostAdult.Name = "bookingCostAdult";
            this.bookingCostAdult.Size = new System.Drawing.Size(100, 20);
            this.bookingCostAdult.TabIndex = 20;
            this.bookingCostAdult.TextChanged += new System.EventHandler(this.bookingCost_TextChanged);
            // 
            // bookingRoom
            // 
            this.bookingRoom.Location = new System.Drawing.Point(138, 168);
            this.bookingRoom.Name = "bookingRoom";
            this.bookingRoom.Size = new System.Drawing.Size(100, 20);
            this.bookingRoom.TabIndex = 21;
            this.bookingRoom.TextChanged += new System.EventHandler(this.bookingRoom_TextChanged);
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Location = new System.Drawing.Point(180, 272);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPaid.TabIndex = 24;
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            this.checkBoxPaid.CheckedChanged += new System.EventHandler(this.checkBoxPaid_CheckedChanged);
            // 
            // bookingButton
            // 
            this.bookingButton.Location = new System.Drawing.Point(129, 326);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(122, 23);
            this.bookingButton.TabIndex = 25;
            this.bookingButton.Text = "Add Booking";
            this.bookingButton.UseVisualStyleBackColor = true;
            this.bookingButton.Click += new System.EventHandler(this.bookingButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(280, 47);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(959, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 44;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(878, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 45;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // departureTime
            // 
            this.departureTime.Location = new System.Drawing.Point(368, 221);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(100, 20);
            this.departureTime.TabIndex = 46;
            // 
            // bookingCostInfant
            // 
            this.bookingCostInfant.Location = new System.Drawing.Point(138, 246);
            this.bookingCostInfant.Name = "bookingCostInfant";
            this.bookingCostInfant.Size = new System.Drawing.Size(100, 20);
            this.bookingCostInfant.TabIndex = 47;
            // 
            // bookingCostChild
            // 
            this.bookingCostChild.Location = new System.Drawing.Point(138, 220);
            this.bookingCostChild.Name = "bookingCostChild";
            this.bookingCostChild.Size = new System.Drawing.Size(100, 20);
            this.bookingCostChild.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Booking Cost Child";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Booking Cost Infant";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 177);
            this.dataGridView1.TabIndex = 51;
            // 
            // bookingUpdateButton
            // 
            this.bookingUpdateButton.Location = new System.Drawing.Point(129, 355);
            this.bookingUpdateButton.Name = "bookingUpdateButton";
            this.bookingUpdateButton.Size = new System.Drawing.Size(122, 23);
            this.bookingUpdateButton.TabIndex = 52;
            this.bookingUpdateButton.Text = "Update Booking";
            this.bookingUpdateButton.UseVisualStyleBackColor = true;
            this.bookingUpdateButton.Click += new System.EventHandler(this.bookingUpdateButton_Click);
            // 
            // deleteBookingButton
            // 
            this.deleteBookingButton.Location = new System.Drawing.Point(129, 384);
            this.deleteBookingButton.Name = "deleteBookingButton";
            this.deleteBookingButton.Size = new System.Drawing.Size(122, 23);
            this.deleteBookingButton.TabIndex = 53;
            this.deleteBookingButton.Text = "Delete Booking";
            this.deleteBookingButton.UseVisualStyleBackColor = true;
            this.deleteBookingButton.Click += new System.EventHandler(this.deleteBookingButton_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(567, 47);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Arrival Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Arrival Time";
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(655, 221);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(100, 20);
            this.arrivalTime.TabIndex = 57;
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(138, 139);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(100, 20);
            this.arrival.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Arrival";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 458);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.deleteBookingButton);
            this.Controls.Add(this.bookingUpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookingCostChild);
            this.Controls.Add(this.bookingCostInfant);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bookingButton);
            this.Controls.Add(this.checkBoxPaid);
            this.Controls.Add(this.bookingRoom);
            this.Controls.Add(this.bookingCostAdult);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.flightNumber);
            this.Controls.Add(this.custContact);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Arrival Time";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox custContact;
        private System.Windows.Forms.TextBox flightNumber;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox bookingCostAdult;
        private System.Windows.Forms.TextBox bookingRoom;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.Button bookingButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox departureTime;
        private System.Windows.Forms.TextBox bookingCostInfant;
        private System.Windows.Forms.TextBox bookingCostChild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bookingUpdateButton;
        private System.Windows.Forms.Button deleteBookingButton;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.Label label13;
    }
}