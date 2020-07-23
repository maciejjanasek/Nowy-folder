namespace CUESYSv._01
{
    partial class Form6
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flightNumber = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.departureTime = new System.Windows.Forms.TextBox();
            this.arrival = new System.Windows.Forms.TextBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.updateFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Arrival Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departure Time";
            // 
            // flightNumber
            // 
            this.flightNumber.Location = new System.Drawing.Point(105, 61);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(100, 20);
            this.flightNumber.TabIndex = 8;
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(105, 87);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(100, 20);
            this.departure.TabIndex = 9;
            // 
            // departureTime
            // 
            this.departureTime.Location = new System.Drawing.Point(105, 113);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(100, 20);
            this.departureTime.TabIndex = 11;
            // 
            // arrival
            // 
            this.arrival.Location = new System.Drawing.Point(105, 139);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(100, 20);
            this.arrival.TabIndex = 12;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(105, 165);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(100, 20);
            this.arrivalTime.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 160);
            this.dataGridView1.TabIndex = 14;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(115, 191);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(75, 23);
            this.addFlightButton.TabIndex = 15;
            this.addFlightButton.Text = "Add";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // updateFlightButton
            // 
            this.updateFlightButton.Location = new System.Drawing.Point(115, 220);
            this.updateFlightButton.Name = "updateFlightButton";
            this.updateFlightButton.Size = new System.Drawing.Size(75, 23);
            this.updateFlightButton.TabIndex = 16;
            this.updateFlightButton.Text = "Update";
            this.updateFlightButton.UseVisualStyleBackColor = true;
            this.updateFlightButton.Click += new System.EventHandler(this.updateFlightButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(115, 249);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFlightButton.TabIndex = 17;
            this.deleteFlightButton.Text = "Delete";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(632, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(217, 47);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(504, 47);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 21;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.updateFlightButton);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.departureTime);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.flightNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox flightNumber;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox departureTime;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Button updateFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}