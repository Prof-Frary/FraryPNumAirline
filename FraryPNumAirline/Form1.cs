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

        private double airlineTaxRate;
        private double economyFee;
        private double economyPlusFee;
        private double businessFee;
        private double firstClassFee;
        //ica 8
        //declared the form2 object
        private Form2 settingForm;

        private string AirlineTrasactionLog = "AirlineTransLog.txt";
        // making public so that form2 can use it, but it should really be a read only property
        public string AirlineConfig = "AirlineConfig.txt";

        // ICA 8 Properties
        public double AirlineTaxRate
        {
            get { return airlineTaxRate; }
            set { airlineTaxRate = value; }
        }
        public double EconomyFee
        {
            get { return economyFee; }
            set { economyFee = value; }
        }
        public double EconomyPlusFee
        {
            get { return economyPlusFee; }
            set { economyPlusFee = value; }
        }
        public double BusinessFee
        {
            get { return businessFee; }
            set { businessFee = value; }
        }

        public double FirstClassFee
        {
            get { return firstClassFee; }
            set { firstClassFee = value; }
        }

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

            double FlightPrice, totalFlightPrice, AirlineTaxAmount, subTotal;
            string AirlineCustName;
            bool PriceValid, NumTickValid;
            int NumTickets;
            // declare the object sw which is an instance of the class StreamWrite
            StreamWriter sw;

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
                        SeatTypeFee = EconomyFee;
                        break;
                    case ECONOMY_PLUS:
                        SeatTypeFee = EconomyPlusFee;
                        break;
                    case BUSINESS_CLASS:
                        SeatTypeFee = BusinessFee;
                        break;
                    case FIRST_CLASS:
                        SeatTypeFee = FirstClassFee;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        break;
                }


                // it is a good idea to save string input to a variable
                AirlineCustName = txtCustomerName.Text;
                // Processing
                subTotal = (FlightPrice + SeatTypeFee) * NumTickets;
                AirlineTaxAmount = subTotal * AirlineTaxRate;
                totalFlightPrice = subTotal + AirlineTaxAmount;
                //Output
                lstOut.Items.Add("Customer Name is " + AirlineCustName);
                // updated output
                lstOut.Items.Add("Seat Type is " + SeatType);
                lstOut.Items.Add("Seat Type Fee is " + SeatTypeFee.ToString("C"));


                // toString will convert numbers to string C indicates currency (Money) N - number
                // P - Percentage - Later we will take about D, T & G ( date and time stuff)
                // a number after P, C and N indicate number of decimeal places
                lstOut.Items.Add("Price is " + FlightPrice.ToString("C2"));
                lstOut.Items.Add("Number of Tickets Bought is " + NumTickets.ToString("N0"));
                lstOut.Items.Add("Subtotal of Tickets is " + subTotal.ToString("C"));
                lstOut.Items.Add("Tax Rate is for each ticket is " + AirlineTaxRate.ToString("P2"));
                lstOut.Items.Add("Tax amount is for each seat " + AirlineTaxAmount.ToString("C2"));
                lstOut.Items.Add("Total Price is " + totalFlightPrice.ToString("C2"));
                sw = File.AppendText(AirlineTrasactionLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Customer Name is " + AirlineCustName);
                // updated output
                sw.WriteLine("Seat Type is " + SeatType);
                sw.WriteLine("Seat Type Fee is " + SeatTypeFee.ToString("C"));
                sw.WriteLine("Price is " + FlightPrice.ToString("C2"));
                sw.WriteLine("Number of Tickets Bought is " + NumTickets.ToString("N0"));
                sw.WriteLine("Tax Rate is " + AirlineTaxRate.ToString("P2"));
                sw.WriteLine("Tax amount is " + AirlineTaxAmount.ToString("C2"));
                sw.WriteLine("Total Price is " + totalFlightPrice.ToString("C2"));

                sw.Close();

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
            /*
            // THIS IS SAMPLE CODE DONOT PUT THIS PERMANENTLY IN YOU CODE
            // try it out and then comment it out
            lstOut.Items.Add(DateTime.Now.ToString("D"));
            lstOut.Items.Add(DateTime.Now.ToString("d"));
            lstOut.Items.Add(DateTime.Now.ToString("T"));
            lstOut.Items.Add(DateTime.Now.ToString("t"));
            lstOut.Items.Add(DateTime.Now.ToString("G"));
            */
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
            //ICA 8
            // here we are actualy creating the form2 object
            settingForm = new Form2(this);

            // this makes the checked changed procedure run ( it doesn't run if set in designer)
            rdoEconomy.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {
                    reader = File.OpenText(AirlineConfig);
                    fileBad = false;
                    double tempValue;
                    //skipping validity checks so as not to confuse the input
                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    // optional error checking could be done here
                    AirlineTaxRate = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    EconomyFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    EconomyPlusFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    BusinessFee = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    firstClassFee = tempValue;

                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuation file was not found. Please select a different file \n Error message was: " +
                        ex.Message
                        );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    //this takes the file the user slected and puts in the variable for the file we need
                    AirlineConfig = openFileDialog1.FileName;


                }
            } while (fileBad);


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //ica 8
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            setValuesOnSecondForm();
            settingForm.ShowDialog();
        }

        public void setValuesOnSecondForm()
        {
            settingForm.txtTaxRate.Text = AirlineTaxRate.ToString();
            settingForm.txtEconFee.Text = EconomyFee.ToString();
            settingForm.txtEconPlusFee.Text = EconomyPlusFee.ToString();
            settingForm.txtBusinessFee.Text = BusinessFee.ToString();
            settingForm.txtFirstClassFee.Text = FirstClassFee.ToString();
        }

        
        private void btnDisplayLog_Click(object sender, EventArgs e)
        {
            const int MAX_LOG_SIZE = 2000;
            string[] AirlineLogLines = new string[MAX_LOG_SIZE];
            int numLogLines = 0;
            StreamReader sr;
            sr = File.OpenText(AirlineTrasactionLog);
            while (!sr.EndOfStream)
            {
                AirlineLogLines[numLogLines] = sr.ReadLine();
                numLogLines++;
            }
            sr.Close();
            // keep track of begining & end of transaction relative to where
            // seat type is recorded (For most students this will be the variable
            // that references their radio button)
            int begTrans = -2;
            int endTrans = 6;

            for (int i=0; i < numLogLines; i++)
            {
                if (AirlineLogLines[i] == "Seat Type is " + SeatType) {
                    // Some of you could use  AirlineLogLines[i].Contains(SeatType)

                    for (int j=i+begTrans;  j<=i+endTrans; j++) {
                        lstOut.Items.Add(AirlineLogLines[j]);
                    
                    }


                }

            }



        }
    }
}
