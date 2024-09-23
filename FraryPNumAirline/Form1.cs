namespace FraryPNumAirline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double taxRate = .0875;
            double price, totalPrice, taxAmount;
            string AirlineCustName;

            //input
            price = double.Parse(txtTicketPrice.Text);
            AirlineCustName = txtCustomerName.Text;


            // Processing
            taxAmount = price * taxRate;
            totalPrice = price + taxAmount;


            //Output
            lstOut.Items.Add("Customer Name is " + AirlineCustName);
            lstOut.Items.Add("Price is " + price.ToString("C2"));
            lstOut.Items.Add("Tax Rate is " + taxRate.ToString("P2"));
            lstOut.Items.Add("Tax amount is " + taxAmount.ToString("C2"));
            lstOut.Items.Add("Total Price is " + totalPrice.ToString("C2"));


            btnClear.Focus();   

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtTicketPrice.Clear();
            lstOut.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
