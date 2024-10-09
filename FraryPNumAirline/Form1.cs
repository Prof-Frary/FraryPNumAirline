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
            double AirlineTaxRate = .08875;
            double FlightPrice, totalFlightPrice, AirlineTaxAmount;
            string AirlineCustName;
            bool PriceValid, NumTickValid;
            int NumTickets;
            //input
            // Parse converts string to double
            // FlightPrice = double.Parse(txtTicketPrice.Text);
            // convert parse to tryparse
            PriceValid = double.TryParse(txtTicketPrice.Text, out FlightPrice);
            NumTickValid = int.TryParse(txtNumTickets.Text, out NumTickets);
            if (PriceValid && NumTickValid)
            {
                // it is a good idea to save string input to a variable
                AirlineCustName = txtCustomerName.Text;
                // Processing
                AirlineTaxAmount = FlightPrice  * AirlineTaxRate;
                totalFlightPrice = (FlightPrice + AirlineTaxAmount) * NumTickets;
                //Output
                lstOut.Items.Add("Customer Name is " + AirlineCustName);
                // toString will convert numbers to string C indicates currency (Money) N - number
                // P - Percentage - Later we will take about D, T & G ( date and time stuff)
                // a number after P, C and N indicate number of decimeal places
                lstOut.Items.Add("Price is " + FlightPrice.ToString("C2"));
                lstOut.Items.Add("Number of Tickets Bought is " + NumTickets.ToString("N0"));
                lstOut.Items.Add("Tax Rate is for each ticket is " + AirlineTaxRate.ToString("P2"));
                lstOut.Items.Add("Tax amount is " + AirlineTaxAmount.ToString("C2"));
                lstOut.Items.Add("Total Price is " + totalFlightPrice.ToString("C2"));
                btnClear.Focus();
            } 
            else
            {
                if (!PriceValid)
                {
                    lstOut.Items.Add("Please enter a numeric entry for price");
                }
                if (!NumTickValid)
                {
                    lstOut.Items.Add("Please enter a numeric entry for number of tickets");
                }
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                // this will close the form and end the program..
                // Note closing a form doesn't always end the program
                this.Close();
            }
        }
    }
}
