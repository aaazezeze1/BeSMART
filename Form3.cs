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
            //for (int i = 1; i <= days; i++)
            //{
            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    fLP1CalendarContent.Controls.Add(ucdays);
            //}
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                DateTime date = new DateTime(year, month, i);
                //ucdays.SetDay(i, date);
                ucdays.DayClicked += Ucdays_DayClicked;
                fLP1CalendarContent.Controls.Add(ucdays);
            }

            //month--;
            //if (month < 1)
            //{
            //    month = 12;
            //    year--;
            //}

            // LoadEventsForCurrentMonth();
        }

        private void Ucdays_DayClicked(object sender, DateTime e)
        {
            EventsSchedForm4 eventForm = new EventsSchedForm4(e);
            eventForm.EventAdded += EventForm_EventAdded;
            eventForm.ShowDialog();
        }

        private void EventForm_EventAdded(object sender, EventAddedEventArgs e)
        {
            //foreach (UserControlDays ucd in fLP1CalendarContent.Controls.OfType<UserControlDays>())
            //{
            //    if (ucd.Date == e.Event.Date)
            //    {
            //        ucd.BackColor = Color.LightBlue; // Change to distinguish days with events
            //        ucd.ToolTipText = $"{e.Event.Title} at {e.Event.Time}"; // Or any other way to display event
            //    }
            //}

            //foreach (UserControlDays ucd in fLP1CalendarContent.Controls.OfType<UserControlDays>())
            //{
            //    if (ucd.Date == e.Event.Date)
            //    {
            //        ucd.BackColor = System.Drawing.Color.LightBlue; // Change to distinguish days with events
            //        ToolTip toolTip = new ToolTip();
            //        toolTip.SetToolTip(ucd, $"{e.Event.Title} at {e.Event.Time}"); // Display event info
            //    }
            //}

            foreach (UserControlDays ucd in fLP1CalendarContent.Controls.OfType<UserControlDays>())
            {
                if (ucd.Date == e.Event.Date)
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(ucd, $"{e.Event.Title} at {e.Event.Time}");

                    switch (e.Event.EventType)
                    {
                        case "Personal":
                            ucd.BackColor = System.Drawing.Color.Pink;
                            break;
                        case "School":
                            ucd.BackColor = System.Drawing.Color.Blue;
                            break;
                        case "Work":
                            ucd.BackColor = System.Drawing.Color.Yellow;
                            break;
                        default:
                            ucd.BackColor = System.Drawing.Color.LightGray;
                            break;
                    }
                }
            }
        }

        private void btn2Next_Click(object sender, EventArgs e)
        {
            ////clear container
            //fLP1CalendarContent.Controls.Clear();

            ////increment month to go to the next month
            //month++;

            //DateTime startofthemonth = new DateTime(year, month, 1);
            ////get the count of days of the month
            //int days = DateTime.DaysInMonth(year, month);
            ////convert the startofthemonth to int
            //int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            ////usercontrol
            //for (int i = 1; i <= dayoftheweek; i++)
            //{
            //    UserControl1Week ucWeek = new UserControl1Week();
            //    fLP1CalendarContent.Controls.Add(ucWeek);
            //}
            ////usercontrol for days
            //for (int i = 1; i <= days; i++)
            //{
            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    fLP1CalendarContent.Controls.Add(ucdays);
            //}

            fLP1CalendarContent.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            displayDays();
        }

        private void btn1Previous_Click(object sender, EventArgs e)
        {
            //fLP1CalendarContent.Controls.Clear();

            ////decrement month to go to the previous month
            //month--;

            //DateTime startofthemonth = new DateTime(year, month, 1);
            ////get the count of days of the month
            //int days = DateTime.DaysInMonth(year, month);
            ////convert the startofthemonth to int
            //int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            ////usercontrol
            //for (int i = 1; i <= dayoftheweek; i++)
            //{
            //    UserControl1Week ucWeek = new UserControl1Week();
            //    fLP1CalendarContent.Controls.Add(ucWeek);
            //}
            ////usercontrol for days
            //for (int i = 1; i <= days; i++)
            //{
            //    UserControlDays ucdays = new UserControlDays();
            //    ucdays.days(i);
            //    fLP1CalendarContent.Controls.Add(ucdays);
            //}

            //month--;
            //if (month < 1)
            //{
            //    month = 12;
            //    year--;
            //}

            //LoadEventsForCurrentMonth();

            fLP1CalendarContent.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            displayDays();
        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            //var SchedForm3 = new Form3();
            //SchedForm3.Show();
            //SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new Form5();
            ToDoListForm5.Show();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new Form4();
            FormulaForm4.Show();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new Form7();
            ConverterForm7.Show();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new Form6();
            MediaPlayerForm6.Show();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }
    }
}
