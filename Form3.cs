using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace NotesApp
{
    public partial class Form3 : Form
    {
        int month, year;
        //private List<EventStorageClass2> events = new List<EventStorageClass2>();

        public class EventAddedEventArgs : EventArgs
        {
            public EventStorageClass2 Event { get; set; }

            public EventAddedEventArgs(EventStorageClass2 @event)
            {
                Event = @event;
            }
        }


        public Form3()
        {
            InitializeComponent();
           // LoadEventsForCurrentMonth();
        }

        bool sidebarExpand = false; //collapsed sidebar
        private void timer1SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) //expanding sidebar
            {
                if (fLP1Sidebar.Width < 190)
                {
                    fLP1Sidebar.Width += 10;
                    //fLP1CalendarContent.Width -= 10;
                    //fLP1CalendarContent.Left += 10;

                    //fLP2Days.Width -= 10;
                    //fLP2Days.Left += 10;
                }
                else
                {
                    //make sure sidebar does not go below min width
                    fLP1Sidebar.Width = 190;
                    sidebarExpand = false;
                    timer1SidebarTransition.Stop();
                }
            }
            else //collapse seidebar
            {
                if (fLP1Sidebar.Width > 72)
                {
                    fLP1Sidebar.Width -= 10;
                    //fLP1CalendarContent.Width += 10;
                    //fLP1CalendarContent.Left -= 10;

                    //fLP2Days.Width += 10;
                    //fLP2Days.Left -= 10;
                }
                else
                {
                    //make sure sidebar does not exceed the max width
                    fLP1Sidebar.Width = 72;
                    sidebarExpand = true;
                    timer1SidebarTransition.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1SidebarTransition.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + "" + year;


            //get the first days of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControl1Week ucWeek = new UserControl1Week();
                fLP1CalendarContent.Controls.Add(ucWeek);
            }
            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                fLP1CalendarContent.Controls.Add(ucdays);
            }

            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

           // LoadEventsForCurrentMonth();
        }

        private void btn2Next_Click(object sender, EventArgs e)
        {
            //clear container
            fLP1CalendarContent.Controls.Clear();

            //increment month to go to the next month
            month++;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControl1Week ucWeek = new UserControl1Week();
                fLP1CalendarContent.Controls.Add(ucWeek);
            }
            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                fLP1CalendarContent.Controls.Add(ucdays);
            }
        }

        private void btn1Previous_Click(object sender, EventArgs e)
        {
            fLP1CalendarContent.Controls.Clear();

            //decrement month to go to the previous month
            month--;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //usercontrol
            for (int i = 1; i <= dayoftheweek; i++)
            {
                UserControl1Week ucWeek = new UserControl1Week();
                fLP1CalendarContent.Controls.Add(ucWeek);
            }
            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                fLP1CalendarContent.Controls.Add(ucdays);
            }

            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            //LoadEventsForCurrentMonth();
        }

        //// Call this method when an event is added or modified
        //private void UpdateCalendarUI()
        //{
        //    foreach (System.Windows.Forms.Control ctrl in fLP1CalendarContent.Controls)
        //    {
        //        if (ctrl is UserControlDays)
        //        {
        //            UserControlDays dayControl = (UserControlDays)ctrl;
        //            int day = dayControl.Day;

        //            //try
        //            //{
        //            //    DateTime date = new DateTime(year, month, day);
        //            //    var eventsOnDay = events.FindAll(e => e.Date.Date == date.Date);

        //            //    if (eventsOnDay.Count > 0)
        //            //    {
        //            //        dayControl.BackColor = eventsOnDay[0].GetColor(); // Use color of the first event for simplicity
        //            //                                                          // Optionally, you can show a marker or some indication that there are multiple events on this day
        //            //    }
        //            //    else
        //            //    {
        //            //        dayControl.BackColor = System.Drawing.Color.White; // Reset to default color
        //            //    }
        //            //}
        //            //catch (ArgumentOutOfRangeException ex)
        //            //{
        //            //    // Handle the exception (e.g., log it, display an error message)
        //            //    // In case the year, month, or day values are invalid
        //            //    Console.WriteLine("Error creating DateTime object: " + ex.Message);
        //            //    dayControl.BackColor = System.Drawing.Color.White; // Reset to default color
        //            //}
        //        }
        //    }
        //}


        //// Call this method to load events for the current month
        //private void LoadEventsForCurrentMonth()
        //{
        //    DateTime now = DateTime.Now;
        //    month = now.Month;
        //    year = now.Year;

        //    DateTime startDate = new DateTime(year, month, 1);
        //    DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

        //    // Retrieve events for the current month
        //    // Placeholder implementation, replace it with actual logic to retrieve events
        //    //events = GetEventsForMonth(startDate, endDate);

        //    // Update the UI
        //    UpdateCalendarUI();
        //}

        //// Placeholder method to retrieve events for a given month
        //private List<EventStorageClass2> GetEventsForMonth(DateTime startDate, DateTime endDate)
        //{
        //    // Placeholder implementation, replace it with actual logic to retrieve events
        //    return new List<EventStorageClass2>();
        //}

        //// Event handler for when an event is added in the event form
        //private void EventForm_EventAdded(object sender, EventAddedEventArgs e)
        //{
        //    //events.Add(e.Event);
        //    UpdateCalendarUI();
        //}
    }
}
