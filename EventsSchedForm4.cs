using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotesApp.Form3;

namespace NotesApp
{
    public partial class EventsSchedForm4 : Form
    {
        private int day;
        public event EventHandler<EventAddedEventArgs> EventAdded;
        public EventsSchedForm4(DateTime date)
        {
            InitializeComponent();
        }

        private void EventsSchedForm4_Load(object sender, EventArgs e)
        {

        }
    }
}
