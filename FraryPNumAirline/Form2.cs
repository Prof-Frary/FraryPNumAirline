using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraryPNumAirline
{
    public partial class Form2 : Form
    {
        // this is the constructor
        private Form1 ff;
        public Form2(Form1 form1)
        {
            // need private variable so it can be accessed in other 
            // procedures
            ff = form1;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSetReturn_Click(object sender, EventArgs e)
        {
            //read values from text boxes
            bool taxValid, EconValid, EconPlusValid, busValid, fcValid;
            double trTempValue, eTempValue, epTempValue, bTempValue, fcTempValue;

            StreamWriter sw;

            taxValid = double.TryParse(txtTaxRate.Text, out trTempValue);
            // if tax rate is not a resonable then set tax valid to be false
            if (trTempValue >= 1 || trTempValue < 0)
            {
                taxValid = false;
            }
            EconValid = double.TryParse(txtEconFee.Text, out eTempValue);
            EconPlusValid = double.TryParse(txtEconPlusFee.Text, out epTempValue);
            busValid = double.TryParse(txtBusinessFee.Text, out bTempValue);
            fcValid = double.TryParse(txtFirstClassFee.Text, out fcTempValue);
            // check values
            if (taxValid && EconValid && EconPlusValid && busValid && fcValid)
            {
                // if values good
                // set properties
                ff.AirlineTaxRate = trTempValue;
                ff.EconomyFee = eTempValue;
                ff.EconomyPlusFee = epTempValue;
                ff.BusinessFee = bTempValue;
                ff.FirstClassFee = fcTempValue;
                // save values in file
                sw = File.CreateText(ff.AirlineConfig);
                sw.WriteLine(ff.AirlineTaxRate);
                sw.WriteLine(ff.EconomyFee);
                sw.WriteLine(ff.EconomyPlusFee);
                sw.WriteLine(ff.BusinessFee);
                sw.WriteLine(ff.FirstClassFee);

                sw.Close();

                // go back to Form 1 
                this.Hide();
            }
            else
            {
                // if values not good
                // replace all text box values with current values

                ff.setValuesOnSecondForm();
            }



            //??? is there another way to do this???
        }

        private void txtEconFee_TextChanged(object sender, EventArgs e)
        {

        }
        // this is to just demonstrate another way to do the error checking.
        // It is not complete - so it does not replace the set & return button

        private void txtTaxRate_Leave(object sender, EventArgs e)
        {
            bool taxValid = false;
            double trTempValue;
            taxValid = double.TryParse(txtTaxRate.Text, out trTempValue);
            if (!taxValid || trTempValue>=1 || trTempValue < 0)
            {
                txtTaxRate.Focus();
                lblErrorMsg.Text = "Tax Rate is not valid";
            } 
            else
            {
                lblErrorMsg.Text = "";

            }
        }
    }
}
