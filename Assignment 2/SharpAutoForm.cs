using Assignment_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Application Name: Sharp Auto Form
 * Author: Bradley Girard
 * Student ID: 200247921
 * Application Creation Date: August 5th, 2016
 * Application Description: A car configuration tool that allows the user to add options, colours and special coatings
 *                          to their brand new car. Calculates the total price, including trade-in.
 */

namespace Assignment_2
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        // Changes the font of the Amount Due and Base Price text boxes to what is selected.
        private void ArialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Arial", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void comicSansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font font = new Font("Comic Sans", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void LucidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Helvetica", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void lucidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font font = new Font("Lucida", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        // Shows a message box stating what the program does.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program will calculate how much a Toyota 86 will cost.", "About This Program", MessageBoxButtons.OK);
        }

        // Closes the program when exit is selected.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Changes the picture inside the picture box to the corresponding colour.
        private void ColoursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imageString = Regex.Replace(ColoursListBox.Text, @"\s+", "");
            CarPictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }

        // Closes the program when Exit is clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clears the form.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            AdditionalOptionsTextBox.Text = "0";
            SubtotalTextBox.Text = null;
            TotalTextBox.Text = null;
            AmountDueTextBox.Text = null;
            TradeInTextBox.Text = "0";

        }

        // Adds the respective amounts to Additional Options text boxes depending if they are checked or not.
        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(StereoSystemCheckBox.Checked)
            {
                double _stereoPrice;

                _stereoPrice = Convert.ToDouble(AdditionalOptionsTextBox.Text) + 425.75;
                AdditionalOptionsTextBox.Text = _stereoPrice.ToString();
            }
            else
            {
                double _stereoPriceSubtract;

                _stereoPriceSubtract = Convert.ToDouble(AdditionalOptionsTextBox.Text) - 425.75;
                AdditionalOptionsTextBox.Text = _stereoPriceSubtract.ToString();
            }
            
        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(LeatherInteriorCheckBox.Checked)
            {
                double _leatherInterior;

                _leatherInterior = Convert.ToDouble(AdditionalOptionsTextBox.Text) + 987.41;
                AdditionalOptionsTextBox.Text = _leatherInterior.ToString();
            }
            else
            {
                double _leatherInteriorSubtract;

                _leatherInteriorSubtract = Convert.ToDouble(AdditionalOptionsTextBox.Text) - 987.41;
                AdditionalOptionsTextBox.Text = _leatherInteriorSubtract.ToString();
            }
            
        }

        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ComputerNavigationCheckBox.Checked)
            {
                double _computerNavigation;

                _computerNavigation = Convert.ToDouble(AdditionalOptionsTextBox.Text) + 1741.23;
                AdditionalOptionsTextBox.Text = _computerNavigation.ToString();
            }
            else
            {
                double _computerNavigationSubtract;

                _computerNavigationSubtract = Convert.ToDouble(AdditionalOptionsTextBox.Text) - 1741.23;
                AdditionalOptionsTextBox.Text = _computerNavigationSubtract.ToString();
            }
            
        }

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PearlizedRadioButton.Checked)
            {
                double _pearlized;

                _pearlized = Convert.ToDouble(AdditionalOptionsTextBox.Text) + 345.72;
                AdditionalOptionsTextBox.Text = _pearlized.ToString();
            }
            else
            {
                double _pearlizedSubtract;

                _pearlizedSubtract = Convert.ToDouble(AdditionalOptionsTextBox.Text) - 345.72;
                AdditionalOptionsTextBox.Text = _pearlizedSubtract.ToString();
            }
        }

        private void CustomDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomDetailingRadioButton.Checked)
            {
                double _customDetailing;

                _customDetailing = Convert.ToDouble(AdditionalOptionsTextBox.Text) + 599.99;
                AdditionalOptionsTextBox.Text = _customDetailing.ToString();
            }
            else
            {
                double _customDetailingSubtract;

                _customDetailingSubtract = Convert.ToDouble(AdditionalOptionsTextBox.Text) - 599.99;
                AdditionalOptionsTextBox.Text = _customDetailingSubtract.ToString();
            }
        }

        /**
         *  Adds up the Base Price and Additional Options to create a subtotal
         *  Adds tax to Subtotal
         *  Takes trade in cost and subtracts from total.
         *  Converts all doubles to strings and places them in respective text boxes
         */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double _basePrice, _additionalOptions, _subtotal, _total, _tradeIn, _amountDue;

            try
            {
                _basePrice = Convert.ToDouble(BasePriceTextBox.Text);
                _additionalOptions = Convert.ToDouble(AdditionalOptionsTextBox.Text);
                _subtotal = _basePrice + _additionalOptions;

                SubtotalTextBox.Text = _subtotal.ToString();

                _subtotal = Convert.ToDouble(SubtotalTextBox.Text) * 1.13;

                TotalTextBox.Text = _subtotal.ToString("#.##");

                _total = Convert.ToDouble(TotalTextBox.Text);
                _tradeIn = Convert.ToDouble(TradeInTextBox.Text);
                _amountDue = _total - _tradeIn;

                AmountDueTextBox.Text = _amountDue.ToString("C2");
                

            }
            catch(Exception exception)
            {
                MessageBox.Show("Invalid Data.", "Input Error.");
                Debug.WriteLine(exception.Message);
            }
            
        }
    }
}
