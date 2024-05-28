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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static NotesApp.UserControlDay;

namespace NotesApp
{
    public partial class CalendarForm : Form
    {
        int month, year;
        Dictionary<DateTime, List<UserControlDay.Event>> eventsDict = new Dictionary<DateTime, List<UserControlDay.Event>>();
       
        public CalendarForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            displayDays(month, year);
        }

        private void displayDays(int month, int year)
        {
            string monthname = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            // First date of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            // Count of the days of the month
            int days = DateTime.DaysInMonth(year, month);

            // Convert startoftthemonth to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            // UserControlBlank for the empty days at the start of the month
            flp1DayContainer.Controls.Clear();
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flp1DayContainer.Controls.Add(ucBlank);
            }
            // UserControlDay for the days in the calendar
            DateTime today = DateTime.Now;
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucDay = new UserControlDay(new DateTime(year, month, i));
                ucDay.SetDay(i);

                DateTime currentDate = new DateTime(year, month, i);
                if (eventsDict.ContainsKey(currentDate))
                {
                    foreach (var eventItem in eventsDict[currentDate])
                    {
                        ucDay.AddEvent(eventItem); // Add events to the day
                    }
                }

                if (year == today.Year && month == today.Month && i == today.Day)
                {
                    ucDay.HighlightToday(); // Highlight today's date
                }

                ucDay.DayClicked += (s, e) => ShowEventForm(currentDate, ucDay); // Event handler for day click
                flp1DayContainer.Controls.Add(ucDay);
            }

        }

        private void btn2Next_Click(object sender, EventArgs e)
        {
            // Increment month
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            displayDays(month, year);
        }
        private void btn1Previous_Click(object sender, EventArgs e)
        {
            // Decrement month
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            displayDays(month, year);
        }
        public void ShowEventForm(DateTime date, UserControlDay ucDay)
        {
            // Check if the event count is already at the limit
            if (eventsDict.ContainsKey(date) && eventsDict[date].Count >= 3)
            {
                MessageBox.Show("You can only add up to 3 events for this day.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MakeEventsForm eventForm = new MakeEventsForm())
            {
                // Show the event form
                if (eventForm.ShowDialog() == DialogResult.OK)
                {
                    // Add the event only if all conditions are met
                    UserControlDay.Event newEvent = new UserControlDay.Event
                    {
                        Title = eventForm.EventTitle,
                        Description = eventForm.EventDescription,
                        EventColor = eventForm.EventColor,
                        EventType = eventForm.EventType,
                        StartTime = eventForm.StartTime,
                        EndTime = eventForm.EndTime,
                        StartTimePeriod = eventForm.StartTimePeriod,
                        EndTimePeriod = eventForm.EndTimePeriod,
                    };

                    if (!eventsDict.ContainsKey(date))
                    {
                        eventsDict[date] = new List<UserControlDay.Event>();
                    }
                    eventsDict[date].Add(newEvent);
                    ucDay.AddEvent(newEvent);
                }
            }
        }
        public void EditEvent(DateTime date, UserControlDay.Event eventItem, UserControlDay ucDay)
        {
            using (MakeEventsForm eventForm = new MakeEventsForm())
            {
                eventForm.SetEventData(eventItem);

                if (eventForm.ShowDialog() == DialogResult.OK)
                {
                    eventItem.Title = eventForm.EventTitle;
                    eventItem.Description = eventForm.EventDescription;
                    eventItem.EventColor = eventForm.EventColor;
                    eventItem.EventType = eventForm.EventType;

                    ucDay.UpdateEvent(eventItem);
                }
            }
        }

        public void DeleteEvent(DateTime date, UserControlDay.Event eventItem, UserControlDay ucDay)
        {
            if (eventsDict.ContainsKey(date))
            {
                eventsDict[date].Remove(eventItem);
                ucDay.RemoveEvent(eventItem);
            }
        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            //var SchedForm3 = new Form3();
            //SchedForm3.Show();
            //SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new ToDoForm();
            ToDoListForm5.Show();
            this.Hide();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new FormulaForm();
            FormulaForm4.Show();
            this.Hide();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void labl1BeSMART_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
        }
    }
}
