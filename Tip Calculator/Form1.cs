using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // The following method provides validation for bill amount.
        private void enteredAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only floating point numbers and integers.
            // The following condition disregards strings or chars as input
            // and only allows decimal char and backspace key
            if(!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // The following method will select the default or existing value in the textbox
        // allowing easier input process.
        private void enteredAmt_Click(object sender, EventArgs e)
        {
            enteredAmt.SelectAll();
            enteredAmt.Focus();
        }

        // The calculate button click will execute the following code
        // and get the desired output.
        private void butCalTip_Click(object sender, EventArgs e)
        {
            try
            {
                // Gets the input values from bill, tip% and no of people.
                decimal billAmt = Convert.ToDecimal(enteredAmt.Text);
                decimal tipPercent = tipEntry.Value;
                int noOfPeople = Convert.ToInt32(peopleCountEntry.Value);

                // Calculate tip per person.
                decimal tipPerPerson = ((billAmt * tipPercent) / 100) / noOfPeople;
                // Round off the obtained amount in order to get 2 digits after decimal for simplification.
                tipPerPerson = Math.Round(tipPerPerson, 2, MidpointRounding.ToEven);

                // Calculate total per person.
                decimal totPerPerson = (billAmt / noOfPeople + Convert.ToDecimal(tipPerPerson));
                // Round off the obtained amount in order to get 2 digits after decimal for simplification.
                totPerPerson = Math.Round(totPerPerson, 2, MidpointRounding.ToEven);

                // Display the result on the labels on the UI.
                lTipAmt.Text = "$" + Convert.ToString(tipPerPerson);
                lTotTip.Text = "$" + Convert.ToString(totPerPerson);

                // Make the output labels visible
                lTipPerPers.Visible = true;
                lTotPerPers.Visible = true;
                lTipAmt.Visible = true;
                lTotTip.Visible = true;
            }
            catch(FormatException fe)
            {
                // If user clicks calculate without giving any input
                // then this catch block will save the application from failing
                // as null will be passed as input.
            }
            catch(ArithmeticException ae)
            {
                lTipAmt.Text = "$0.00";
                lTotTip.Text = "$0.00";
            }

        }
        
        // The following method will reset the input and output fields of the form
        private void butReset_Click(object sender, EventArgs e)
        {
            try
            {
                enteredAmt.Text = "0.00";
                tipEntry.Value = 0.00M;
                peopleCountEntry.Value = 1;
                lTipPerPers.Visible = false;
                lTotPerPers.Visible = false;
                lTipAmt.Visible = false;
                lTotTip.Visible = false;
            }
            catch {}
        }
    }
}
