namespace NotesApp
{
    partial class EventsSchedForm4
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
            label3 = new Label();
            txtBoxEventsTitle = new TextBox();
            saveEventButton = new Button();
            backToCalendarButton = new Button();
            rdBtn1PersonalEvents = new RadioButton();
            rdBtn2SchoolEvents = new RadioButton();
            rdBtn3WorkEvents = new RadioButton();
            txtBoxEventDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBoxStartTime = new MaskedTextBox();
            label4 = new Label();
            comboBoxStartTimePeriod = new ComboBox();
            comboBoxEndTimePeriod = new ComboBox();
            maskedTextBoxEndTime = new MaskedTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 43);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 2;
            label3.Text = "Event";
            // 
            // txtBoxEventsTitle
            // 
            txtBoxEventsTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEventsTitle.Location = new Point(92, 39);
            txtBoxEventsTitle.Name = "txtBoxEventsTitle";
            txtBoxEventsTitle.Size = new Size(413, 27);
            txtBoxEventsTitle.TabIndex = 5;
            // 
            // saveEventButton
            // 
            saveEventButton.BackColor = Color.DimGray;
            saveEventButton.FlatStyle = FlatStyle.Flat;
            saveEventButton.ForeColor = Color.White;
            saveEventButton.Location = new Point(165, 324);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(94, 29);
            saveEventButton.TabIndex = 6;
            saveEventButton.Text = "Save";
            saveEventButton.UseVisualStyleBackColor = false;
            saveEventButton.Click += saveEventButton_Click;
            // 
            // backToCalendarButton
            // 
            backToCalendarButton.BackColor = Color.DimGray;
            backToCalendarButton.FlatStyle = FlatStyle.Flat;
            backToCalendarButton.ForeColor = Color.White;
            backToCalendarButton.Location = new Point(283, 324);
            backToCalendarButton.Name = "backToCalendarButton";
            backToCalendarButton.Size = new Size(94, 29);
            backToCalendarButton.TabIndex = 7;
            backToCalendarButton.Text = "Back";
            backToCalendarButton.UseVisualStyleBackColor = false;
            backToCalendarButton.Click += backToCalendarButton_Click;
            // 
            // rdBtn1PersonalEvents
            // 
            rdBtn1PersonalEvents.AutoSize = true;
            rdBtn1PersonalEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtn1PersonalEvents.ForeColor = Color.IndianRed;
            rdBtn1PersonalEvents.Location = new Point(40, 268);
            rdBtn1PersonalEvents.Name = "rdBtn1PersonalEvents";
            rdBtn1PersonalEvents.Size = new Size(136, 24);
            rdBtn1PersonalEvents.TabIndex = 8;
            rdBtn1PersonalEvents.TabStop = true;
            rdBtn1PersonalEvents.Text = "Personal Events";
            rdBtn1PersonalEvents.UseVisualStyleBackColor = true;
            // 
            // rdBtn2SchoolEvents
            // 
            rdBtn2SchoolEvents.AutoSize = true;
            rdBtn2SchoolEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtn2SchoolEvents.ForeColor = Color.MidnightBlue;
            rdBtn2SchoolEvents.Location = new Point(223, 268);
            rdBtn2SchoolEvents.Name = "rdBtn2SchoolEvents";
            rdBtn2SchoolEvents.Size = new Size(124, 24);
            rdBtn2SchoolEvents.TabIndex = 9;
            rdBtn2SchoolEvents.TabStop = true;
            rdBtn2SchoolEvents.Text = "School Events";
            rdBtn2SchoolEvents.UseVisualStyleBackColor = true;
            // 
            // rdBtn3WorkEvents
            // 
            rdBtn3WorkEvents.AutoSize = true;
            rdBtn3WorkEvents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdBtn3WorkEvents.ForeColor = Color.Sienna;
            rdBtn3WorkEvents.Location = new Point(389, 268);
            rdBtn3WorkEvents.Name = "rdBtn3WorkEvents";
            rdBtn3WorkEvents.Size = new Size(115, 24);
            rdBtn3WorkEvents.TabIndex = 10;
            rdBtn3WorkEvents.TabStop = true;
            rdBtn3WorkEvents.Text = "Work Events";
            rdBtn3WorkEvents.UseVisualStyleBackColor = true;
            // 
            // txtBoxEventDescription
            // 
            txtBoxEventDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEventDescription.Location = new Point(46, 117);
            txtBoxEventDescription.Multiline = true;
            txtBoxEventDescription.Name = "txtBoxEventDescription";
            txtBoxEventDescription.Size = new Size(459, 61);
            txtBoxEventDescription.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 91);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 12;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 211);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 14;
            label2.Text = "Time Start";
            // 
            // maskedTextBoxStartTime
            // 
            maskedTextBoxStartTime.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxStartTime.Location = new Point(129, 208);
            maskedTextBoxStartTime.Mask = "90:00";
            maskedTextBoxStartTime.Name = "maskedTextBoxStartTime";
            maskedTextBoxStartTime.Size = new Size(82, 27);
            maskedTextBoxStartTime.TabIndex = 15;
            maskedTextBoxStartTime.ValidatingType = typeof(DateTime);
            maskedTextBoxStartTime.MaskInputRejected += maskedTextBoxStartTime_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(287, 211);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 16;
            label4.Text = "Time End";
            // 
            // comboBoxStartTimePeriod
            // 
            comboBoxStartTimePeriod.FlatStyle = FlatStyle.System;
            comboBoxStartTimePeriod.FormattingEnabled = true;
            comboBoxStartTimePeriod.Location = new Point(213, 208);
            comboBoxStartTimePeriod.Name = "comboBoxStartTimePeriod";
            comboBoxStartTimePeriod.Size = new Size(50, 28);
            comboBoxStartTimePeriod.TabIndex = 18;
            comboBoxStartTimePeriod.SelectedIndexChanged += comboBoxStartTimePeriod_SelectedIndexChanged;
            // 
            // comboBoxEndTimePeriod
            // 
            comboBoxEndTimePeriod.FlatStyle = FlatStyle.System;
            comboBoxEndTimePeriod.FormattingEnabled = true;
            comboBoxEndTimePeriod.Location = new Point(455, 207);
            comboBoxEndTimePeriod.Name = "comboBoxEndTimePeriod";
            comboBoxEndTimePeriod.Size = new Size(50, 28);
            comboBoxEndTimePeriod.TabIndex = 20;
            // 
            // maskedTextBoxEndTime
            // 
            maskedTextBoxEndTime.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxEndTime.Location = new Point(371, 207);
            maskedTextBoxEndTime.Mask = "90:00";
            maskedTextBoxEndTime.Name = "maskedTextBoxEndTime";
            maskedTextBoxEndTime.Size = new Size(82, 27);
            maskedTextBoxEndTime.TabIndex = 19;
            maskedTextBoxEndTime.ValidatingType = typeof(DateTime);
            // 
            // EventsSchedForm4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 376);
            Controls.Add(comboBoxEndTimePeriod);
            Controls.Add(maskedTextBoxEndTime);
            Controls.Add(comboBoxStartTimePeriod);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxStartTime);
            Controls.Add(label2);
            Controls.Add(txtBoxEventDescription);
            Controls.Add(label1);
            Controls.Add(rdBtn3WorkEvents);
            Controls.Add(rdBtn2SchoolEvents);
            Controls.Add(rdBtn1PersonalEvents);
            Controls.Add(backToCalendarButton);
            Controls.Add(saveEventButton);
            Controls.Add(txtBoxEventsTitle);
            Controls.Add(label3);
            Name = "EventsSchedForm4";
            Text = "Make Events";
            Load += EventsSchedForm4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtBoxEventsTitle;
        private Button saveEventButton;
        private Button backToCalendarButton;
        private RadioButton rdBtn1PersonalEvents;
        private RadioButton rdBtn2SchoolEvents;
        private RadioButton rdBtn3WorkEvents;
        private TextBox txtBoxEventDescription;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBoxStartTime;
        private Label label4;
        private ComboBox comboBoxStartTimePeriod;
        private ComboBox comboBoxEndTimePeriod;
        private MaskedTextBox maskedTextBoxEndTime;
    }
}