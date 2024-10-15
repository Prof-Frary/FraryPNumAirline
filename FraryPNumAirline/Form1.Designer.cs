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
            groupBox1 = new GroupBox();
            rdoFirstClass = new RadioButton();
            rdoBusinessClass = new RadioButton();
            rdoEconPlus = new RadioButton();
            rdoEconomy = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Airline Ticket Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 126);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Airline Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(241, 126);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(229, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 155);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Ticket Price";
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(241, 155);
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
            label4.Location = new Point(65, 179);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 9;
            label4.Text = "Number of Tickets";
            // 
            // txtNumTickets
            // 
            txtNumTickets.Location = new Point(241, 182);
            txtNumTickets.Name = "txtNumTickets";
            txtNumTickets.Size = new Size(100, 23);
            txtNumTickets.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoFirstClass);
            groupBox1.Controls.Add(rdoBusinessClass);
            groupBox1.Controls.Add(rdoEconPlus);
            groupBox1.Controls.Add(rdoEconomy);
            groupBox1.Location = new Point(52, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 55);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seat Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoFirstClass
            // 
            rdoFirstClass.AutoSize = true;
            rdoFirstClass.Location = new Point(479, 19);
            rdoFirstClass.Name = "rdoFirstClass";
            rdoFirstClass.Size = new Size(77, 19);
            rdoFirstClass.TabIndex = 3;
            rdoFirstClass.TabStop = true;
            rdoFirstClass.Text = "First Class";
            rdoFirstClass.UseVisualStyleBackColor = true;
            rdoFirstClass.CheckedChanged += rdoFirstClass_CheckedChanged;
            // 
            // rdoBusinessClass
            // 
            rdoBusinessClass.AutoSize = true;
            rdoBusinessClass.Location = new Point(297, 19);
            rdoBusinessClass.Name = "rdoBusinessClass";
            rdoBusinessClass.Size = new Size(100, 19);
            rdoBusinessClass.TabIndex = 2;
            rdoBusinessClass.TabStop = true;
            rdoBusinessClass.Text = "Business Class";
            rdoBusinessClass.UseVisualStyleBackColor = true;
            rdoBusinessClass.CheckedChanged += rdoBusinessClass_CheckedChanged;
            // 
            // rdoEconPlus
            // 
            rdoEconPlus.AutoSize = true;
            rdoEconPlus.Location = new Point(145, 19);
            rdoEconPlus.Name = "rdoEconPlus";
            rdoEconPlus.Size = new Size(86, 19);
            rdoEconPlus.TabIndex = 1;
            rdoEconPlus.TabStop = true;
            rdoEconPlus.Text = "Economy +";
            rdoEconPlus.UseVisualStyleBackColor = true;
            rdoEconPlus.CheckedChanged += rdoEconPlus_CheckedChanged;
            // 
            // rdoEconomy
            // 
            rdoEconomy.AutoSize = true;
            rdoEconomy.Location = new Point(3, 19);
            rdoEconomy.Name = "rdoEconomy";
            rdoEconomy.Size = new Size(75, 19);
            rdoEconomy.TabIndex = 0;
            rdoEconomy.Text = "Economy";
            rdoEconomy.UseVisualStyleBackColor = true;
            rdoEconomy.CheckedChanged += rdoEconomy_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
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
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton rdoFirstClass;
        private RadioButton rdoBusinessClass;
        private RadioButton rdoEconPlus;
        private RadioButton rdoEconomy;
    }
}
