using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import Net and Newtonsoft for currency conversion
using System.Net;
using Newtonsoft.Json.Linq;

namespace NotesApp
{
    public partial class ConverterForm : Form
    {
        private const int HUNDRED = 100;
        private const int THOUSAND = 1000;
        private const double CMFT = 30.48;

        public ConverterForm()
        {
            InitializeComponent();
        }

        // Temperature Converter Code
        private void ConvertTempButton_Click(object sender, EventArgs e)
        {
            double celcius, farenheit;
            if (CTFButton.Checked)
            {
                celcius = Double.Parse(TempTxtBox.Text);
                farenheit = (celcius * 9 / 5) + 32;
                Math.Round(Convert.ToDouble(farenheit), 2);
                // Convert until 2 decimal places
                double result = Math.Round(Convert.ToDouble(farenheit), 2);
                TempResultTxtBox.Text = Convert.ToString(result);
            }
            else if (FTCButton.Checked)
            {
                farenheit = Double.Parse(TempTxtBox.Text);
                celcius = (farenheit - 32) * 5 / 9;
                double result = Math.Round(Convert.ToDouble(celcius), 2);
                TempResultTxtBox.Text = Convert.ToString(result);
            }
        }

        // Clear the text box field if reset button is pressed
        private void TempResetButton_Click(object sender, EventArgs e)
        {
            TempResultTxtBox.Text = "";
            TempTxtBox.Text = "";
        }

        // Change button color on hover or leave
        private void ConvertTempButton_MouseHover(object sender, EventArgs e)
        {
            ConvertTempButton.BackColor = Color.FromArgb(66, 69, 73);
        }

        private void ConvertTempButton_MouseLeave(object sender, EventArgs e)
        {
            ConvertTempButton.ResetBackColor();
            ConvertTempButton.UseVisualStyleBackColor = true;
        }

        private void TempResetButton_MouseHover(object sender, EventArgs e)
        {
            TempResetButton.BackColor = Color.FromArgb(66, 69, 73);
        }

        private void TempResetButton_MouseLeave(object sender, EventArgs e)
        {
            TempResetButton.ResetBackColor();
            TempResetButton.UseVisualStyleBackColor = true;
        }

        // Currency Converter Code
        private void Form2_Load(object sender, EventArgs e)
        {
            // Upon load the default item selected is the PHP
            ToCurrencyCombo.SelectedItem = "PHP";

            // Upon load the default text selected is Select Unit
            FromUnitCmb.Text = "Select Unit";
            ToUnitCmb.Text = "Select Unit";
        }

        private double GetExchangeRate(string FromCurrencyCombo, string ToCurrencyCombo)
        {
            string json;
            using (var client = new WebClient())
            {
                // Fetch the exchange rate data using the API with the parameter from the Currency Combo Box
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{FromCurrencyCombo}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["rates"][ToCurrencyCombo];

            return rate;
        }

        private void ConvertCurrencyButton_Click(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyCombo.SelectedItem.ToString();
            string toCurrency = ToCurrencyCombo.SelectedItem.ToString();
            double amount;

            // Parse to double and if its not double then show an error
            if (!double.TryParse(AmountTxtBox.Text, out amount))
            {
                MessageBox.Show("Invalid Input. Please Try Again.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("An error has occurred.", "API Error", MessageBoxButtons.OK);
                return;
            }
            double convertedAmount = amount * exchangeRate;

            // Show the converted amount with two decimal places
            LblCurrencyResult.Text = "Converted Amount: " + toCurrency + convertedAmount.ToString("F2");
        }

        private void ConvertCurrencyButton_MouseHover(object sender, EventArgs e)
        {
            ConvertCurrencyButton.BackColor = Color.FromArgb(66, 69, 73);
        }

        private void ConvertCurrencyButton_MouseLeave(object sender, EventArgs e)
        {
            ConvertCurrencyButton.ResetBackColor();
            ConvertCurrencyButton.UseVisualStyleBackColor = true;
        }

        // Unit Conversion Code
        private void ConvertUnitButton_Click(object sender, EventArgs e)
        {
            if (FromUnitCmb.Text == "Select Unit" || ToUnitCmb.Text == "Select Unit")
            {
                MessageBox.Show("Please Select a Unit");
            }
            else
            {
                if (FromUnitCmb.Text == "Kilometer" && ToUnitCmb.Text == "Meter")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) * THOUSAND);
                }
                if (FromUnitCmb.Text == "Meter" && ToUnitCmb.Text == "Kilometer")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) / THOUSAND);
                }
                if (FromUnitCmb.Text == "Centimeter" && ToUnitCmb.Text == "Meter")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) / HUNDRED);
                }
                if (FromUnitCmb.Text == "Meter" && ToUnitCmb.Text == "Centimeter")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) * HUNDRED);
                }
                if (FromUnitCmb.Text == "Centimeter" && ToUnitCmb.Text == "Feet")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) / CMFT);
                }
                if (FromUnitCmb.Text == "Feet" && ToUnitCmb.Text == "Centimeter")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) * CMFT);
                }
                if (FromUnitCmb.Text == "Kilograms" && ToUnitCmb.Text == "Grams")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) * THOUSAND);
                }
                if (FromUnitCmb.Text == "Grams" && ToUnitCmb.Text == "Kilograms")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) / THOUSAND);
                }
                if (FromUnitCmb.Text == "Miligrams" && ToUnitCmb.Text == "Grams")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) / THOUSAND);
                }
                if (FromUnitCmb.Text == "Grams" && ToUnitCmb.Text == "Miligrams")
                {
                    UnitResultTxtBox.Text = Convert.ToString(Convert.ToDouble(UnitAmountTxtBox.Text) * THOUSAND);
                }
            }
        }

        private void ConvertUnitButton_MouseHover(object sender, EventArgs e)
        {
            ConvertUnitButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void ConvertUnitButton_MouseLeave(object sender, EventArgs e)
        {
            ConvertUnitButton.ResetBackColor();
            ConvertUnitButton.UseVisualStyleBackColor = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
