namespace FraryPNumAirline
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
            label1 = new Label();
            label2 = new Label();
            txtTaxRate = new TextBox();
            txtEconFee = new TextBox();
            label3 = new Label();
            txtEconPlusFee = new TextBox();
            label4 = new Label();
            txtBusinessFee = new TextBox();
            label5 = new Label();
            btnSetReturn = new Button();
            txtFirstClassFee = new TextBox();
            label6 = new Label();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Configuration Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Tax Rate";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(135, 49);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(100, 23);
            txtTaxRate.TabIndex = 2;
            txtTaxRate.Leave += txtTaxRate_Leave;
            // 
            // txtEconFee
            // 
            txtEconFee.Location = new Point(135, 75);
            txtEconFee.Name = "txtEconFee";
            txtEconFee.Size = new Size(100, 23);
            txtEconFee.TabIndex = 4;
            txtEconFee.TextChanged += txtEconFee_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 78);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Economy Fee";
            // 
            // txtEconPlusFee
            // 
            txtEconPlusFee.Location = new Point(135, 104);
            txtEconPlusFee.Name = "txtEconPlusFee";
            txtEconPlusFee.Size = new Size(100, 23);
            txtEconPlusFee.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 103);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Economy Plus Fee";
            label4.Click += label4_Click;
            // 
            // txtBusinessFee
            // 
            txtBusinessFee.Location = new Point(135, 133);
            txtBusinessFee.Name = "txtBusinessFee";
            txtBusinessFee.Size = new Size(100, 23);
            txtBusinessFee.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 7;
            label5.Text = "Business Class Fee";
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(95, 205);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(108, 23);
            btnSetReturn.TabIndex = 9;
            btnSetReturn.Text = "&Set && Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += btnSetReturn_Click;
            // 
            // txtFirstClassFee
            // 
            txtFirstClassFee.Location = new Point(135, 165);
            txtFirstClassFee.Name = "txtFirstClassFee";
            txtFirstClassFee.Size = new Size(100, 23);
            txtFirstClassFee.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 168);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "First Class Fee";
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(69, 259);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 15);
            lblErrorMsg.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 317);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtFirstClassFee);
            Controls.Add(label6);
            Controls.Add(btnSetReturn);
            Controls.Add(txtBusinessFee);
            Controls.Add(label5);
            Controls.Add(txtEconPlusFee);
            Controls.Add(label4);
            Controls.Add(txtEconFee);
            Controls.Add(label3);
            Controls.Add(txtTaxRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Airline Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSetReturn;
        private Label label6;
        public TextBox txtTaxRate;
        public TextBox txtEconFee;
        public TextBox txtEconPlusFee;
        public TextBox txtBusinessFee;
        public TextBox txtFirstClassFee;
        private Label lblErrorMsg;
    }
}