﻿using System;
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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponents();
        }

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

        private void ConvertTempButton_MouseHover(object sender, EventArgs e)
        {
            ConvertTempButton.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void ConvertTempButton_MouseLeave(object sender, EventArgs e)
        {
            ConvertTempButton.ResetBackColor();
            ConvertTempButton.UseVisualStyleBackColor = true;
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            // Upon load the default item selected is the PHP
            ToCurrencyCombo.SelectedItem = "PHP";
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

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Converter
            // 
            ClientSize = new Size(284, 261);
            Name = "Converter";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        private void ConvertCurrencyButton_Click(object sender, EventArgs e)
        {
            string fromCurrency = FromCurrencyCombo.SelectedItem.ToString();
            string toCurrency = ToCurrencyCombo.SelectedItem.ToString();

            double amount;

<<<<<<< Updated upstream
            if (!double.TryParse(AmountTxtBox.Text, out amount))
=======
            // Parse to double and if its not double then show an error
            if(!double.TryParse(AmountTxtBox.Text, out amount))
>>>>>>> Stashed changes
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
    }
}