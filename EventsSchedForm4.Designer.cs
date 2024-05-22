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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mTxtBoxDate = new MaskedTextBox();
            mTxtBoxEventTime = new MaskedTextBox();
            txtBoxEventsTitle = new TextBox();
            saveEventButton = new Button();
            backToCalendarButton = new Button();
            rdBtn1PersonalEvents = new RadioButton();
            rdBtn2SchoolEvents = new RadioButton();
            rdBtn3WorkEvents = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 105);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 2;
            label3.Text = "Event";
            // 
            // mTxtBoxDate
            // 
            mTxtBoxDate.BackColor = SystemColors.Control;
            mTxtBoxDate.BorderStyle = BorderStyle.None;
            mTxtBoxDate.Location = new Point(77, 46);
            mTxtBoxDate.Margin = new Padding(3, 2, 3, 2);
            mTxtBoxDate.Mask = "00/00/0000";
            mTxtBoxDate.Name = "mTxtBoxDate";
            mTxtBoxDate.Size = new Size(74, 16);
            mTxtBoxDate.TabIndex = 3;
            mTxtBoxDate.ValidatingType = typeof(DateTime);
            // 
            // mTxtBoxEventTime
            // 
            mTxtBoxEventTime.BackColor = SystemColors.Control;
            mTxtBoxEventTime.BorderStyle = BorderStyle.None;
            mTxtBoxEventTime.Cursor = Cursors.IBeam;
            mTxtBoxEventTime.Location = new Point(77, 66);
            mTxtBoxEventTime.Margin = new Padding(3, 2, 3, 2);
            mTxtBoxEventTime.Mask = "90:00";
            mTxtBoxEventTime.Name = "mTxtBoxEventTime";
            mTxtBoxEventTime.Size = new Size(32, 16);
            mTxtBoxEventTime.TabIndex = 4;
            // 
            // txtBoxEventsTitle
            // 
            txtBoxEventsTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEventsTitle.Location = new Point(75, 105);
            txtBoxEventsTitle.Margin = new Padding(3, 2, 3, 2);
            txtBoxEventsTitle.Name = "txtBoxEventsTitle";
            txtBoxEventsTitle.Size = new Size(369, 23);
            txtBoxEventsTitle.TabIndex = 5;
            // 
            // saveEventButton
            // 
            saveEventButton.BackColor = Color.DimGray;
            saveEventButton.FlatStyle = FlatStyle.Flat;
            saveEventButton.ForeColor = Color.White;
            saveEventButton.Location = new Point(140, 182);
            saveEventButton.Margin = new Padding(3, 2, 3, 2);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(82, 22);
            saveEventButton.TabIndex = 6;
            saveEventButton.Text = "Save Event";
            saveEventButton.UseVisualStyleBackColor = false;
            saveEventButton.Click += saveEventButton_Click;
            // 
            // backToCalendarButton
            // 
            backToCalendarButton.BackColor = Color.DimGray;
            backToCalendarButton.FlatStyle = FlatStyle.Flat;
            backToCalendarButton.ForeColor = Color.White;
            backToCalendarButton.Location = new Point(243, 182);
            backToCalendarButton.Margin = new Padding(3, 2, 3, 2);
            backToCalendarButton.Name = "backToCalendarButton";
            backToCalendarButton.Size = new Size(82, 22);
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
            rdBtn1PersonalEvents.Location = new Point(31, 140);
            rdBtn1PersonalEvents.Margin = new Padding(3, 2, 3, 2);
            rdBtn1PersonalEvents.Name = "rdBtn1PersonalEvents";
            rdBtn1PersonalEvents.Size = new Size(107, 19);
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
            rdBtn2SchoolEvents.Location = new Point(191, 140);
            rdBtn2SchoolEvents.Margin = new Padding(3, 2, 3, 2);
            rdBtn2SchoolEvents.Name = "rdBtn2SchoolEvents";
            rdBtn2SchoolEvents.Size = new Size(99, 19);
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
            rdBtn3WorkEvents.Location = new Point(336, 140);
            rdBtn3WorkEvents.Margin = new Padding(3, 2, 3, 2);
            rdBtn3WorkEvents.Name = "rdBtn3WorkEvents";
            rdBtn3WorkEvents.Size = new Size(91, 19);
            rdBtn3WorkEvents.TabIndex = 10;
            rdBtn3WorkEvents.TabStop = true;
            rdBtn3WorkEvents.Text = "Work Events";
            rdBtn3WorkEvents.UseVisualStyleBackColor = true;
            // 
            // EventsSchedForm4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 230);
            Controls.Add(rdBtn3WorkEvents);
            Controls.Add(rdBtn2SchoolEvents);
            Controls.Add(rdBtn1PersonalEvents);
            Controls.Add(backToCalendarButton);
            Controls.Add(saveEventButton);
            Controls.Add(txtBoxEventsTitle);
            Controls.Add(mTxtBoxEventTime);
            Controls.Add(mTxtBoxDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventsSchedForm4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Make Events";
            Load += EventsSchedForm4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox mTxtBoxDate;
        private MaskedTextBox mTxtBoxEventTime;
        private TextBox txtBoxEventsTitle;
        private Button saveEventButton;
        private Button backToCalendarButton;
        private RadioButton rdBtn1PersonalEvents;
        private RadioButton rdBtn2SchoolEvents;
        private RadioButton rdBtn3WorkEvents;
    }
}