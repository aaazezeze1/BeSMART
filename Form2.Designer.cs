namespace NotesApp
{
    partial class Form2
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
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ConvertTempButton = new Button();
            ToCurrencyCombo = new ComboBox();
            FromCurrencyCombo = new ComboBox();
            ConvertCurrencyButton = new Button();
            AmountTxtBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LblCurrencyResult = new Label();
            TempResultTxtBox = new TextBox();
            TempResetButton = new Button();
            label3 = new Label();
            FTCButton = new RadioButton();
            CTFButton = new RadioButton();
            label2 = new Label();
            TempTxtBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(ConvertTempButton);
            panel1.Controls.Add(ToCurrencyCombo);
            panel1.Controls.Add(FromCurrencyCombo);
            panel1.Controls.Add(ConvertCurrencyButton);
            panel1.Controls.Add(AmountTxtBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LblCurrencyResult);
            panel1.Controls.Add(TempResultTxtBox);
            panel1.Controls.Add(TempResetButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FTCButton);
            panel1.Controls.Add(CTFButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TempTxtBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 580);
            panel1.TabIndex = 0;
            // 
            // ConvertTempButton
            // 
            ConvertTempButton.FlatStyle = FlatStyle.Flat;
            ConvertTempButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConvertTempButton.ForeColor = Color.White;
            ConvertTempButton.Location = new Point(9, 204);
            ConvertTempButton.Name = "ConvertTempButton";
            ConvertTempButton.Size = new Size(75, 34);
            ConvertTempButton.TabIndex = 19;
            ConvertTempButton.Text = "Convert";
            ConvertTempButton.UseVisualStyleBackColor = true;
            ConvertTempButton.Click += ConvertTempButton_Click;
            // 
            // ToCurrencyCombo
            // 
            ToCurrencyCombo.FormattingEnabled = true;
            ToCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            ToCurrencyCombo.Location = new Point(23, 480);
            ToCurrencyCombo.Name = "ToCurrencyCombo";
            ToCurrencyCombo.Size = new Size(121, 23);
            ToCurrencyCombo.TabIndex = 18;
            // 
            // FromCurrencyCombo
            // 
            FromCurrencyCombo.FormattingEnabled = true;
            FromCurrencyCombo.Items.AddRange(new object[] { "AUD", "CAD", "EUR", "GBP", "JPY", "NZD", "PHP", "USD" });
            FromCurrencyCombo.Location = new Point(23, 415);
            FromCurrencyCombo.Name = "FromCurrencyCombo";
            FromCurrencyCombo.Size = new Size(121, 23);
            FromCurrencyCombo.TabIndex = 17;
            // 
            // ConvertCurrencyButton
            // 
            ConvertCurrencyButton.FlatStyle = FlatStyle.Flat;
            ConvertCurrencyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConvertCurrencyButton.ForeColor = Color.White;
            ConvertCurrencyButton.Location = new Point(45, 531);
            ConvertCurrencyButton.Name = "ConvertCurrencyButton";
            ConvertCurrencyButton.Size = new Size(75, 34);
            ConvertCurrencyButton.TabIndex = 16;
            ConvertCurrencyButton.Text = "Convert";
            ConvertCurrencyButton.UseVisualStyleBackColor = true;
            ConvertCurrencyButton.Click += ConvertCurrencyButton_Click;
            ConvertCurrencyButton.MouseLeave += ConvertCurrencyButton_MouseLeave;
            ConvertCurrencyButton.MouseHover += ConvertCurrencyButton_MouseHover;
            // 
            // AmountTxtBox
            // 
            AmountTxtBox.Location = new Point(32, 349);
            AmountTxtBox.Name = "AmountTxtBox";
            AmountTxtBox.Size = new Size(100, 23);
            AmountTxtBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 456);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 12;
            label7.Text = "To Currency";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 391);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 11;
            label6.Text = "From Currency";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 325);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 10;
            label5.Text = "Enter Amount";
            // 
            // LblCurrencyResult
            // 
            LblCurrencyResult.AutoSize = true;
            LblCurrencyResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCurrencyResult.ForeColor = Color.White;
            LblCurrencyResult.Location = new Point(0, 277);
            LblCurrencyResult.Name = "LblCurrencyResult";
            LblCurrencyResult.Size = new Size(163, 21);
            LblCurrencyResult.TabIndex = 9;
            LblCurrencyResult.Text = "Converted Amount: ";
            // 
            // TempResultTxtBox
            // 
            TempResultTxtBox.Location = new Point(36, 175);
            TempResultTxtBox.Name = "TempResultTxtBox";
            TempResultTxtBox.Size = new Size(84, 23);
            TempResultTxtBox.TabIndex = 8;
            // 
            // TempResetButton
            // 
            TempResetButton.FlatStyle = FlatStyle.Flat;
            TempResetButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TempResetButton.ForeColor = Color.White;
            TempResetButton.Location = new Point(90, 204);
            TempResetButton.Name = "TempResetButton";
            TempResetButton.Size = new Size(75, 34);
            TempResetButton.TabIndex = 7;
            TempResetButton.Text = "Reset";
            TempResetButton.UseVisualStyleBackColor = true;
            TempResetButton.Click += TempResetButton_Click;
            TempResetButton.MouseLeave += TempResetButton_MouseLeave;
            TempResetButton.MouseHover += TempResetButton_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 151);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // FTCButton
            // 
            FTCButton.AutoSize = true;
            FTCButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            FTCButton.ForeColor = Color.White;
            FTCButton.Location = new Point(28, 118);
            FTCButton.Name = "FTCButton";
            FTCButton.Size = new Size(137, 21);
            FTCButton.TabIndex = 5;
            FTCButton.TabStop = true;
            FTCButton.Text = "Farenheit To Celcius";
            FTCButton.UseVisualStyleBackColor = true;
            // 
            // CTFButton
            // 
            CTFButton.AutoSize = true;
            CTFButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            CTFButton.ForeColor = Color.White;
            CTFButton.Location = new Point(28, 93);
            CTFButton.Name = "CTFButton";
            CTFButton.Size = new Size(137, 21);
            CTFButton.TabIndex = 4;
            CTFButton.TabStop = true;
            CTFButton.Text = "Celcius To Farenheit";
            CTFButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 3;
            label2.Text = "Select Unit";
            // 
            // TempTxtBox
            // 
            TempTxtBox.Location = new Point(36, 32);
            TempTxtBox.Name = "TempTxtBox";
            TempTxtBox.Size = new Size(84, 23);
            TempTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Temperature";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 69, 73);
            ClientSize = new Size(800, 578);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TempTxtBox;
        private TextBox TempResultTxtBox;
        private Button TempResetButton;
        private Label label3;
        private RadioButton FTCButton;
        private RadioButton CTFButton;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label LblCurrencyResult;
        private Button ConvertCurrencyButton;
        private TextBox AmountTxtBox;
        private ComboBox ToCurrencyCombo;
        private ComboBox FromCurrencyCombo;
        private Button ConvertTempButton;
    }
}