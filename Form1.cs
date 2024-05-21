using System.Windows.Forms;
// Import the data table library
using System.Data;

// Import for File Saving 
using System.IO;

using static System.Net.Mime.MediaTypeNames;

namespace NotesApp
{
    public partial class NotesApp : Form
    {
        public NotesApp()
        {
            InitializeComponent();
        }

        private void pbtn2AddNotes_Click(object sender, EventArgs e)
        {
            var NotesForm2 = new Form2();
            NotesForm2.Show();
            this.Hide();
        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new Form3();
            SchedForm3.Show();
            this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDolistForm5 = new Form5();
            ToDolistForm5.Show();
            this.Hide();
            ToDolistForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new Form4();
            FormulaForm4.Show();
            this.Hide();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new Form7();
            ConverterForm7.Show();
            this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new Form6();
            MediaPlayerForm6.Show();
            this.Hide();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }
    }
}
