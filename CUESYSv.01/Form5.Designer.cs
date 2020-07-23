namespace CUESYSv._01
{
    partial class Form5
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
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadBookingButton = new System.Windows.Forms.Button();
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.custContact = new System.Windows.Forms.TextBox();
            this.flightNumber = new System.Windows.Forms.TextBox();
            this.departureTime = new System.Windows.Forms.TextBox();
            this.arrival = new System.Windows.Forms.TextBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.bookingRoom = new System.Windows.Forms.TextBox();
            this.bookingCostAdult = new System.Windows.Forms.TextBox();
            this.bookingCostChild = new System.Windows.Forms.TextBox();
            this.bookingCostInfant = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(147, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(148, 109);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Booking ID";
            // 
            // loadBookingButton
            // 
            this.loadBookingButton.Location = new System.Drawing.Point(148, 133);
            this.loadBookingButton.Name = "loadBookingButton";
            this.loadBookingButton.Size = new System.Drawing.Size(93, 23);
            this.loadBookingButton.TabIndex = 6;
            this.loadBookingButton.Text = "Load Booking ";
            this.loadBookingButton.UseVisualStyleBackColor = true;
            this.loadBookingButton.Click += new System.EventHandler(this.loadBookingButton_Click);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Location = new System.Drawing.Point(166, 92);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(75, 23);
            this.printPreviewButton.TabIndex = 7;
            this.printPreviewButton.Text = "Preview ";
            this.printPreviewButton.UseVisualStyleBackColor = true;
            this.printPreviewButton.Visible = false;
            this.printPreviewButton.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Location = new System.Drawing.Point(166, 121);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.printInvoiceButton.TabIndex = 8;
            this.printInvoiceButton.Text = "Print";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Visible = false;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(148, 106);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(75, 23);
            this.loadData.TabIndex = 9;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Visible = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.Visible = false;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // custContact
            // 
            this.custContact.Location = new System.Drawing.Point(462, 15);
            this.custContact.Name = "custContact";
            this.custContact.Size = new System.Drawing.Size(100, 20);
            this.custContact.TabIndex = 11;
            this.custContact.Visible = false;
            // 
            // flightNumber
            // 
            this.flightNumber.Location = new System.Drawing.Point(462, 41);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(100, 20);
            this.flightNumber.TabIndex = 12;
            this.flightNumber.Visible = false;
            // 
            // departureTime
            // 
            this.departureTime.Location = new System.Drawing.Point(462, 93);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(100, 20);
            this.departureTime.TabIndex = 14;
            this.departureTime.Visible = false;
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(462, 119);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(100, 20);
            this.arrival.TabIndex = 15;
            this.arrival.Visible = false;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(462, 171);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(100, 20);
            this.arrivalTime.TabIndex = 17;
            this.arrivalTime.Visible = false;
            this.arrivalTime.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // bookingRoom
            // 
            this.bookingRoom.Location = new System.Drawing.Point(462, 197);
            this.bookingRoom.Name = "bookingRoom";
            this.bookingRoom.Size = new System.Drawing.Size(100, 20);
            this.bookingRoom.TabIndex = 18;
            this.bookingRoom.Visible = false;
            // 
            // bookingCostAdult
            // 
            this.bookingCostAdult.Location = new System.Drawing.Point(632, 15);
            this.bookingCostAdult.Name = "bookingCostAdult";
            this.bookingCostAdult.Size = new System.Drawing.Size(100, 20);
            this.bookingCostAdult.TabIndex = 19;
            this.bookingCostAdult.Visible = false;
            // 
            // bookingCostChild
            // 
            this.bookingCostChild.Location = new System.Drawing.Point(632, 41);
            this.bookingCostChild.Name = "bookingCostChild";
            this.bookingCostChild.Size = new System.Drawing.Size(100, 20);
            this.bookingCostChild.TabIndex = 20;
            this.bookingCostChild.Visible = false;
            // 
            // bookingCostInfant
            // 
            this.bookingCostInfant.Location = new System.Drawing.Point(632, 67);
            this.bookingCostInfant.Name = "bookingCostInfant";
            this.bookingCostInfant.Size = new System.Drawing.Size(100, 20);
            this.bookingCostInfant.TabIndex = 21;
            this.bookingCostInfant.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(490, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 22;
            this.monthCalendar1.Visible = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(809, 18);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 23;
            this.monthCalendar2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(861, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(755, 207);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(100, 20);
            this.departure.TabIndex = 25;
            this.departure.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 239);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bookingCostInfant);
            this.Controls.Add(this.bookingCostChild);
            this.Controls.Add(this.bookingCostAdult);
            this.Controls.Add(this.bookingRoom);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.flightNumber);
            this.Controls.Add(this.custContact);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loadBookingButton);
            this.Controls.Add(this.printPreviewButton);
            this.Controls.Add(this.printInvoiceButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadBookingButton;
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.Button printInvoiceButton;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox custContact;
        private System.Windows.Forms.TextBox flightNumber;
        private System.Windows.Forms.TextBox departureTime;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox bookingRoom;
        private System.Windows.Forms.TextBox bookingCostAdult;
        private System.Windows.Forms.TextBox bookingCostChild;
        private System.Windows.Forms.TextBox bookingCostInfant;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox departure;
    }
}