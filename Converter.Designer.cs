namespace NotesApp
{
    partial class Converter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponents()
        {
            LblTemp = new Label();
            LblTempResult = new Label();
            LblTempUnit = new Label();
            TempTxtBox = new TextBox();
            TempResultTxtBox = new TextBox();
            CTFButton = new RadioButton();
            FTCButton = new RadioButton();
            ConvertTempButton = new Button();
            TempResetButton = new Button();
            panel1 = new Panel();
            LblCurrencyResult = new Label();
            AmountTxtBox = new TextBox();
            LblCurrencyAmount = new Label();
            ConvertCurrencyButton = new Button();
            ToCurrencyCombo = new ComboBox();
            LblToCurrency = new Label();
            LblFromCurrency = new Label();
            FromCurrencyCombo = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblTemp
            // 
            LblTemp.AutoSize = true;
            LblTemp.BackColor = Color.FromArgb(114, 137, 218);
            LblTemp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTemp.ForeColor = Color.White;
            LblTemp.Location = new Point(47, 22);
            LblTemp.Name = "LblTemp";
            LblTemp.Size = new Size(145, 21);
            LblTemp.TabIndex = 3;
            LblTemp.Text = "Enter Temperature";
            // 
            // LblTempResult
            // 
            LblTempResult.AutoSize = true;
            LblTempResult.BackColor = Color.FromArgb(114, 137, 218);
            LblTempResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTempResult.ForeColor = Color.White;
            LblTempResult.Location = new Point(91, 178);
            LblTempResult.Name = "LblTempResult";
            LblTempResult.Size = new Size(55, 21);
            LblTempResult.TabIndex = 4;
            LblTempResult.Text = "Result";
            // 
            // LblTempUnit
            // 
            LblTempUnit.AutoSize = true;
            LblTempUnit.BackColor = Color.FromArgb(114, 137, 218);
            LblTempUnit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTempUnit.ForeColor = Color.White;
            LblTempUnit.Location = new Point(70, 81);
            LblTempUnit.Name = "LblTempUnit";
            LblTempUnit.Size = new Size(89, 21);
            LblTempUnit.TabIndex = 5;
            LblTempUnit.Text = "Select Unit";
            // 
            // TempTxtBox
            // 
            TempTxtBox.Location = new Point(70, 46);
            TempTxtBox.Name = "TempTxtBox";
            TempTxtBox.Size = new Size(96, 23);
            TempTxtBox.TabIndex = 6;
            // 
            // TempResultTxtBox
            // 
            TempResultTxtBox.Location = new Point(70, 202);
            TempResultTxtBox.Name = "TempResultTxtBox";
            TempResultTxtBox.Size = new Size(96, 23);
            TempResultTxtBox.TabIndex = 8;
            // 
            // CTFButton
            // 
            CTFButton.AutoSize = true;
            CTFButton.BackColor = Color.FromArgb(114, 137, 218);
            CTFButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CTFButton.ForeColor = Color.White;
            CTFButton.Location = new Point(55, 114);
            CTFButton.Name = "CTFButton";
            CTFButton.Size = new Size(137, 21);
            CTFButton.TabIndex = 9;
            CTFButton.TabStop = true;
            CTFButton.Text = "Celcius To Farenheit";
            CTFButton.UseVisualStyleBackColor = false;
            // 
            // FTCButton
            // 
            FTCButton.AutoSize = true;
            FTCButton.BackColor = Color.FromArgb(114, 137, 218);
            FTCButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FTCButton.ForeColor = Color.White;
            FTCButton.Location = new Point(55, 141);
            FTCButton.Name = "FTCButton";
            FTCButton.Size = new Size(141, 21);
            FTCButton.TabIndex = 10;
            FTCButton.TabStop = true;
            FTCButton.Text = " Farenheit To Celcius";
            FTCButton.UseVisualStyleBackColor = false;
            // 
            // ConvertTempButton
            // 
            ConvertTempButton.BackColor = Color.FromArgb(114, 137, 218);
            ConvertTempButton.FlatStyle = FlatStyle.Flat;
            ConvertTempButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertTempButton.ForeColor = Color.White;
            ConvertTempButton.Location = new Point(36, 231);
            ConvertTempButton.Name = "ConvertTempButton";
            ConvertTempButton.Size = new Size(88, 31);
            ConvertTempButton.TabIndex = 11;
            ConvertTempButton.Text = "Convert";
            ConvertTempButton.UseVisualStyleBackColor = false;
            ConvertTempButton.Click += ConvertTempButton_Click;
            // 
            // TempResetButton
            // 
            TempResetButton.BackColor = Color.FromArgb(114, 137, 218);
            TempResetButton.FlatStyle = FlatStyle.Flat;
            TempResetButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TempResetButton.ForeColor = Color.White;
            TempResetButton.Location = new Point(130, 231);
            TempResetButton.Name = "TempResetButton";
            TempResetButton.Size = new Size(88, 31);
            TempResetButton.TabIndex = 12;
            TempResetButton.Text = "Reset";
            TempResetButton.UseVisualStyleBackColor = false;
            TempResetButton.Click += TempResetButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(LblTemp);
            panel1.Controls.Add(TempTxtBox);
            panel1.Controls.Add(CTFButton);
            panel1.Controls.Add(LblTempUnit);
            panel1.Controls.Add(FTCButton);
            panel1.Controls.Add(ConvertTempButton);
            panel1.Controls.Add(TempResetButton);
            panel1.Controls.Add(TempResultTxtBox);
            panel1.Controls.Add(LblCurrencyResult);
            panel1.Controls.Add(LblTempResult);
            panel1.Controls.Add(AmountTxtBox);
            panel1.Controls.Add(LblCurrencyAmount);
            panel1.Controls.Add(ConvertCurrencyButton);
            panel1.Controls.Add(ToCurrencyCombo);
            panel1.Controls.Add(LblToCurrency);
            panel1.Controls.Add(LblFromCurrency);
            panel1.Controls.Add(FromCurrencyCombo);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 667);
            panel1.TabIndex = 13;
            // 
            // LblCurrencyResult
            // 
            LblCurrencyResult.AutoSize = true;
            LblCurrencyResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCurrencyResult.ForeColor = Color.White;
            LblCurrencyResult.Location = new Point(8, 286);
            LblCurrencyResult.Name = "LblCurrencyResult";
            LblCurrencyResult.Size = new Size(158, 21);
            LblCurrencyResult.TabIndex = 20;
            LblCurrencyResult.Text = "Converted Amount: ";
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTxtBox.Location = new Point(13, 363);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(96, 29);
            AmountTxtBox.TabIndex = 19;
            // 
            // LblCurrencyAmount
            // 
            LblCurrencyAmount.AutoSize = true;
            LblCurrencyAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCurrencyAmount.ForeColor = Color.White;
            LblCurrencyAmount.Location = new Point(13, 329);
            LblCurrencyAmount.Name = "LblCurrencyAmount";
            LblCurrencyAmount.Size = new Size(111, 21);
            LblCurrencyAmount.TabIndex = 18;
            LblCurrencyAmount.Text = "Enter Amount";
            // 
            // ConvertCurrencyButton
            // 
            ConvertCurrencyButton.BackColor = Color.FromArgb(114, 137, 218);
            ConvertCurrencyButton.FlatStyle = FlatStyle.Flat;
            ConvertCurrencyButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertCurrencyButton.ForeColor = Color.White;
            ConvertCurrencyButton.Location = new Point(13, 563);
            ConvertCurrencyButton.Name = "ConvertCurrencyButton";
            ConvertCurrencyButton.Size = new Size(88, 31);
            ConvertCurrencyButton.TabIndex = 14;
            ConvertCurrencyButton.Text = "Convert";
            ConvertCurrencyButton.UseVisualStyleBackColor = false;
            ConvertCurrencyButton.Click += ConvertCurrencyButton_Click;
            // 
            // ToCurrencyCombo
            // 
            ToCurrencyCombo.FormattingEnabled = true;
            ToCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            ToCurrencyCombo.Location = new Point(13, 521);
            ToCurrencyCombo.Name = "ToCurrencyCombo";
            ToCurrencyCombo.Size = new Size(121, 23);
            ToCurrencyCombo.TabIndex = 17;
            // 
            // LblToCurrency
            // 
            LblToCurrency.AutoSize = true;
            LblToCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblToCurrency.ForeColor = Color.White;
            LblToCurrency.Location = new Point(13, 485);
            LblToCurrency.Name = "LblToCurrency";
            LblToCurrency.Size = new Size(96, 21);
            LblToCurrency.TabIndex = 16;
            LblToCurrency.Text = "To Currency";
            // 
            // LblFromCurrency
            // 
            LblFromCurrency.AutoSize = true;
            LblFromCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFromCurrency.ForeColor = Color.White;
            LblFromCurrency.Location = new Point(13, 409);
            LblFromCurrency.Name = "LblFromCurrency";
            LblFromCurrency.Size = new Size(117, 21);
            LblFromCurrency.TabIndex = 15;
            LblFromCurrency.Text = "From Currency";
            // 
            // FromCurrencyCombo
            // 
            FromCurrencyCombo.FormattingEnabled = true;
            FromCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            FromCurrencyCombo.Location = new Point(13, 445);
            FromCurrencyCombo.Name = "FromCurrencyCombo";
            FromCurrencyCombo.Size = new Size(121, 23);
            FromCurrencyCombo.TabIndex = 14;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(870, 663);
            Controls.Add(panel1);
            Name = "Converter";
            Text = "Converter";
            Load += Converter_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Label LblTemp;
        private Label LblTempResult;
        private Label LblTempUnit;
        private TextBox TempTxtBox;
        private TextBox TempResultTxtBox;
        private RadioButton CTFButton;
        private RadioButton FTCButton;
        private Button ConvertTempButton;
        private Button TempResetButton;
        private Panel panel1;
        private ComboBox FromCurrencyCombo;
        private ComboBox ToCurrencyCombo;
        private Label LblToCurrency;
        private Label LblFromCurrency;
        private Label LblCurrencyResult;
        private TextBox AmountTxtBox;
        private Label LblCurrencyAmount;
        private Button ConvertCurrencyButton;
    }
}