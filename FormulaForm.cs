using Newtonsoft.Json.Linq;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class FormulaForm : Form
    {

        public FormulaForm()
        {
            InitializeComponent();
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

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new ScheduleForm();
            SchedForm3.Show();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new ToDoForm();
            ToDoListForm5.Show();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            //var FormulaForm4 = new Form4();
            //FormulaForm4.Show();
            //FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn1Schedule_Click_1(object sender, EventArgs e)
        {
            var SchedForm3 = new ScheduleForm();
            SchedForm3.Show();
            this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click_1(object sender, EventArgs e)
        {
            var ToDolistForm5 = new ToDoForm();
            ToDolistForm5.Show();
            this.Hide();
            ToDolistForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click_1(object sender, EventArgs e)
        {
            //var FormulaForm4 = new FormulaForm();
            //FormulaForm4.Show();
            //this.Hide();
            //FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click_1(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5MediaPlayer_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            this.Hide();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }
    }
}
