using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotesApp.ScheduleForm;

namespace NotesApp
{
    public partial class EventsSchedForm4 : Form
    {
        //private int day;
        //public event EventHandler<EventAddedEventArgs> EventAdded;

        public event EventHandler<EventAddedEventArgs> EventAdded;
        private DateTime eventDate;

        public EventsSchedForm4(DateTime date)
        {
            InitializeComponent();
            eventDate = date;
        }

        private void EventsSchedForm4_Load(object sender, EventArgs e)
        {

        }

        private void backToCalendarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {
            // Collect event details from form controls
            string eventTitle = txtBoxEventsTitle.Text;
            string eventTime = mTxtBoxEventTime.Text;

            var newEvent = new EventStorageClass2
            {
                Title = eventTitle,
                Time = eventTime,
                Date = eventDate
            };

            EventAdded?.Invoke(this, new EventAddedEventArgs(newEvent));
            this.Close();
        }

        private string GetSelectedEventType()
        {
            if (rdBtn1PersonalEvents.Checked)
                return "Personal";
            else if (rdBtn2SchoolEvents.Checked)
                return "School";
            else if (rdBtn3WorkEvents.Checked)
                return "Work";
            else
                return string.Empty;
        }
    }
}
