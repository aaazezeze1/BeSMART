﻿using iText.Kernel.Pdf.Canvas.Parser.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class MakeEventsForm : Form
    {

        //Form for making events in the calendar
        //storage of the user input data
        public string EventTitle { get; private set; }
        public string EventDescription { get; private set; }
        public Color EventColor { get; private set; }
        public string EventType { get; private set; }
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        public string StartTimePeriod { get; private set; }
        public string EndTimePeriod { get; private set; }

        public MakeEventsForm()
        {
            InitializeComponent();
            // Initialize properties with default values to remove warning
            EventTitle = string.Empty;
            EventDescription = string.Empty;
            EventType = string.Empty;
            StartTime = string.Empty;
            EndTime = string.Empty;
            StartTimePeriod = string.Empty;
            EndTimePeriod = string.Empty;
        }
        private void saveEventButton_Click(object sender, EventArgs e)
        {
            if (rdBtn1PersonalEvents.Checked)
            {
                EventColor = Color.IndianRed;
                EventType = "Personal";
            }
            else if (rdBtn2SchoolEvents.Checked)
            {
                EventColor = Color.MidnightBlue;
                EventType = "School";
            }
            else if (rdBtn3WorkEvents.Checked)
            {
                EventColor = Color.Sienna;
                EventType = "Work";
            }
            else
            {
                //default color of the event, if the user didn't choose a radio button
                //should be included to the choices, but forgot to do so
                EventColor = Color.Gray;
                EventType = "Other";
            }

            EventTitle = txtBoxEventsTitle.Text;
            EventDescription = txtBoxEventDescription.Text;
            StartTime = maskedTextBoxStartTime.Text;
            EndTime = maskedTextBoxEndTime.Text;

            if (comboBoxStartTimePeriod.SelectedItem != null)
            {
                StartTimePeriod = comboBoxStartTimePeriod.SelectedItem.ToString();
            }
            else
            {
                StartTimePeriod = string.Empty; // or handle as needed
            }

            if (comboBoxEndTimePeriod.SelectedItem != null)
            {
                EndTimePeriod = comboBoxEndTimePeriod.SelectedItem.ToString();
            }
            else
            {
                EndTimePeriod = string.Empty; // or handle as needed
            }

            if (string.IsNullOrEmpty(EventTitle) || string.IsNullOrEmpty(EventDescription) ||
                string.IsNullOrEmpty(StartTime) || string.IsNullOrEmpty(EndTime))
            {
                MessageBox.Show("Please fill in all the details.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Close the form and set DialogResult to OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void backToCalendarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public void SetEventData(UserControlDay.Event eventItem)
        {
            //

            txtBoxEventsTitle.Text = eventItem.Title;
            txtBoxEventDescription.Text = eventItem.Description;
            maskedTextBoxStartTime.Text = eventItem.StartTime;
            maskedTextBoxEndTime.Text = eventItem.EndTime;

            switch (eventItem.EventType)
            {
                case "Personal":
                    rdBtn1PersonalEvents.Checked = true;
                    break;
                case "School":
                    rdBtn2SchoolEvents.Checked = true;
                    break;
                case "Work":
                    rdBtn3WorkEvents.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void EventsSchedForm4_Load(object sender, EventArgs e)
        {
            comboBoxStartTimePeriod.Items.AddRange(new object[] { "AM", "PM" });
            comboBoxEndTimePeriod.Items.AddRange(new object[] { "AM", "PM" });

            comboBoxStartTimePeriod.SelectedIndex = 0; // Set default to "AM"
            comboBoxEndTimePeriod.SelectedIndex = 0;   // Set default to "AM"
        }

        private void saveEventButton_MouseHover(object sender, EventArgs e)
        {
            saveEventButton.BackColor = Color.DarkSlateGray;
        }

        private void saveEventButton_MouseLeave(object sender, EventArgs e)
        {
            saveEventButton.ResetBackColor();
            saveEventButton.BackColor = Color.DimGray;
        }

        private void backToCalendarButton_MouseHover(object sender, EventArgs e)
        {
            backToCalendarButton.BackColor = Color.DarkSlateGray;
        }

        private void backToCalendarButton_MouseLeave(object sender, EventArgs e)
        {
            backToCalendarButton.ResetBackColor();
            backToCalendarButton.BackColor = Color.DimGray;
        }
    }
}
