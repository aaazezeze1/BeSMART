using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace NotesApp
{
    public partial class UserControlDays : UserControl
    {
        public int Day { get; private set; }
        public DateTime Date { get; private set; }
        
        public event EventHandler<DateTime> DayClicked;


        public UserControlDays()
        {
            InitializeComponent();
            this.DoubleClick += UserControlDays_DoubleClick;
        }


        public void days(int numday)
        {
            // lblDays.Text = numday + "";
            lblDays.Text = numday.ToString();
            Day = numday;
            //Date = date;
        }

        public void SetDay(int day)
        {
            Day = day;
            lblDays.Text = Day.ToString();
        }

        private void UserControlDays_DoubleClick(object sender, EventArgs e)
        {
            DayClicked?.Invoke(this, Date);
        }
    }
}
