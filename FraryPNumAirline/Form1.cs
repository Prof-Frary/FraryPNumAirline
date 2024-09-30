namespace FraryPNumAirline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtTicketPrice.Clear();
            lstOut.Items.Clear();
            // focus changes the active control.
            // So the line below changes the active control to txtCustomer name
            txtCustomerName.Focus();
        }


        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            // Variables should be declared at the beginning of the procedure
            double AirlineTaxRate = .0875;
            double FlightPrice, totalFlightPrice, AirlineTaxAmount;
            string AirlineCustName;

            //input
            // Parse converts string to double
            FlightPrice = double.Parse(txtTicketPrice.Text);
            // it is a good idea to save string input to a variable
            AirlineCustName = txtCustomerName.Text;


            // Processing
            AirlineTaxAmount = FlightPrice * AirlineTaxRate;
            totalFlightPrice = FlightPrice + AirlineTaxAmount;


            //Output
            lstOut.Items.Add("Customer Name is " + AirlineCustName);
            // toString will convert numbers to string C indicates currency (Money) N - number
            // P - Percentage - Later we will take about D, T & G ( date and time stuff)
            // a number after P, C and N indicate number of decimeal places
            lstOut.Items.Add("Price is " + FlightPrice.ToString("C2"));
            lstOut.Items.Add("Tax Rate is " + AirlineTaxRate.ToString("P2"));
            lstOut.Items.Add("Tax amount is " + AirlineTaxAmount.ToString("C2"));
            lstOut.Items.Add("Total Price is " + totalFlightPrice.ToString("C2"));


            btnClear.Focus();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // this will close the form and end the program..
            // Note closing a form doesn't always end the program
            this.Close();
        }
    }
}
