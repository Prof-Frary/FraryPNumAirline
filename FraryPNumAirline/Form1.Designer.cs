namespace FraryPNumAirline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtTicketPrice = new TextBox();
            lstOut = new ListBox();
            btnCalculatePrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            label4 = new Label();
            txtNumTickets = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(291, 31);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Airline Ticket Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 87);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Airline Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(243, 84);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(229, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 128);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Ticket Price";
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(243, 128);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(229, 23);
            txtTicketPrice.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(52, 208);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(697, 154);
            lstOut.TabIndex = 5;
            lstOut.TabStop = false;
            // 
            // btnCalculatePrice
            // 
            btnCalculatePrice.Location = new Point(65, 368);
            btnCalculatePrice.Name = "btnCalculatePrice";
            btnCalculatePrice.Size = new Size(75, 70);
            btnCalculatePrice.TabIndex = 6;
            btnCalculatePrice.Text = "Calculate Total Ticket &Price";
            btnCalculatePrice.UseVisualStyleBackColor = true;
            btnCalculatePrice.Click += btnCalculatePrice_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(310, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 70);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(547, 368);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 70);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 166);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 9;
            label4.Text = "Number of Tickets";
            // 
            // txtNumTickets
            // 
            txtNumTickets.Location = new Point(247, 169);
            txtNumTickets.Name = "txtNumTickets";
            txtNumTickets.Size = new Size(100, 23);
            txtNumTickets.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumTickets);
            Controls.Add(label4);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculatePrice);
            Controls.Add(lstOut);
            Controls.Add(txtTicketPrice);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Your Name Here";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtTicketPrice;
        private ListBox lstOut;
        private Button btnCalculatePrice;
        private Button btnClear;
        private Button btnQuit;
        private Label label4;
        private TextBox txtNumTickets;
    }
}
