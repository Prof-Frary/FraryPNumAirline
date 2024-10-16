using System.Configuration.Internal;
//Your Name here
namespace FraryPNumAirline
{
    public partial class Form1 : Form
    {
        private string SeatType;
        const string ECONOMY = "Economy";
        const string ECONOMY_PLUS = "Economy Plus";
        const string BUSINESS_CLASS = "Business Class";
        const string FIRST_CLASS = "First Class";

        public Form1()
        {
            InitializeComponent();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtTicketPrice.Clear();
            lstOut.Items.Clear();
            txtNumTickets.Clear();
            // focus changes the active control.
            // So the line below changes the active control to txtCustomer name
            //txtCustomerName.Focus();
            //  rdoEconomy.Focus(); or 
            rdoEconomy.Checked = true;
        }


        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            // Variables should be declared at the beginning of the procedure
            double AirlineTaxRate = .08875;
            double FlightPrice, totalFlightPrice, AirlineTaxAmount;
            string AirlineCustName;
            bool PriceValid, NumTickValid;
            int NumTickets;

            double SeatTypeFee = 0;
            //input
            // Parse converts string to double
            // FlightPrice = double.Parse(txtTicketPrice.Text);
            // convert parse to tryparse
            PriceValid = double.TryParse(txtTicketPrice.Text, out FlightPrice);
            NumTickValid = int.TryParse(txtNumTickets.Text, out NumTickets);
            if (PriceValid && NumTickValid)
            {
                switch (SeatType)
                {
                    case ECONOMY:
                        SeatTypeFee = 0;
                        break;
                    case ECONOMY_PLUS:
                        SeatTypeFee = 25;
                        break;
                    case BUSINESS_CLASS:
                        SeatTypeFee = 100;
                        break;
                    case FIRST_CLASS:
                        SeatTypeFee = 500;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        break;
                }
                // it is a good idea to save string input to a variable
                AirlineCustName = txtCustomerName.Text;
                // Processing
                AirlineTaxAmount = (FlightPrice + SeatTypeFee) * AirlineTaxRate;
                totalFlightPrice = (FlightPrice + SeatTypeFee + AirlineTaxAmount) * NumTickets;
                //Output
                lstOut.Items.Add("Customer Name is " + AirlineCustName);
                lstOut.Items.Add("Seat Type is " + SeatType);
                lstOut.Items.Add("Seat Type Fee is " + SeatTypeFee.ToString("C"));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this makes the checked changed procedure run ( it doesn't run if set in designer)
            rdoEconomy.Checked = true;


        }

        private void rdoEconomy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEconomy.Checked)
            {
                SeatType = ECONOMY;
            }
        }

        private void rdoEconPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEconPlus.Checked)
            {
                SeatType = ECONOMY_PLUS;
            }
        }

        private void rdoBusinessClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBusinessClass.Checked)
            {
                SeatType = BUSINESS_CLASS;
            }

        }

        private void rdoFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFirstClass.Checked)
            {
                SeatType = FIRST_CLASS;
            }
        }

        private void txtCustomerName_DragEnter(object sender, DragEventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;

        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }
    }
}
