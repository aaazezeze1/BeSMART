using System.Windows.Forms;
// import data table library
using System.Data;

namespace NotesApp
{
    public partial class NotesApp : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public NotesApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            previousNotes.DataSource = notes;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            // Create a new note with an empty string title and note content
            TitleBox.Text = "";
            NoteBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception error)
            {
                Console.WriteLine("Invalid Operation");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = NoteBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text);
            }

            // Clear the text when saved
            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false;
        }

        // Double click to open notes
        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
