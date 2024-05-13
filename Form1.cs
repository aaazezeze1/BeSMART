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
        }
    }
}
