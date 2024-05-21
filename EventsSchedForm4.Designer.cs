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
            label1.Location = new Point(36, 62);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 89);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 140);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 2;
            label3.Text = "Event";
            // 
            // mTxtBoxDate
            // 
            mTxtBoxDate.BackColor = SystemColors.Control;
            mTxtBoxDate.BorderStyle = BorderStyle.None;
            mTxtBoxDate.Location = new Point(88, 62);
            mTxtBoxDate.Mask = "00/00/0000";
            mTxtBoxDate.Name = "mTxtBoxDate";
            mTxtBoxDate.Size = new Size(84, 20);
            mTxtBoxDate.TabIndex = 3;
            mTxtBoxDate.ValidatingType = typeof(DateTime);
            // 
            // mTxtBoxEventTime
            // 
            mTxtBoxEventTime.BackColor = SystemColors.Control;
            mTxtBoxEventTime.BorderStyle = BorderStyle.None;
            mTxtBoxEventTime.Cursor = Cursors.IBeam;
            mTxtBoxEventTime.Location = new Point(88, 88);
            mTxtBoxEventTime.Mask = "90:00";
            mTxtBoxEventTime.Name = "mTxtBoxEventTime";
            mTxtBoxEventTime.Size = new Size(37, 20);
            mTxtBoxEventTime.TabIndex = 4;
            // 
            // txtBoxEventsTitle
            // 
            txtBoxEventsTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEventsTitle.Location = new Point(86, 140);
            txtBoxEventsTitle.Name = "txtBoxEventsTitle";
            txtBoxEventsTitle.Size = new Size(421, 27);
            txtBoxEventsTitle.TabIndex = 5;
            // 
            // saveEventButton
            // 
            saveEventButton.BackColor = Color.DimGray;
            saveEventButton.FlatStyle = FlatStyle.Flat;
            saveEventButton.ForeColor = Color.White;
            saveEventButton.Location = new Point(160, 243);
            saveEventButton.Name = "saveEventButton";
            saveEventButton.Size = new Size(94, 29);
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
            backToCalendarButton.Location = new Point(278, 243);
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
            rdBtn1PersonalEvents.Location = new Point(35, 187);
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
            rdBtn2SchoolEvents.Location = new Point(218, 187);
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
            rdBtn3WorkEvents.Location = new Point(384, 187);
            rdBtn3WorkEvents.Name = "rdBtn3WorkEvents";
            rdBtn3WorkEvents.Size = new Size(115, 24);
            rdBtn3WorkEvents.TabIndex = 10;
            rdBtn3WorkEvents.TabStop = true;
            rdBtn3WorkEvents.Text = "Work Events";
            rdBtn3WorkEvents.UseVisualStyleBackColor = true;
            // 
            // EventsSchedForm4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 307);
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
            Name = "EventsSchedForm4";
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