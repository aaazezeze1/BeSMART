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

            // Change the color of the first cell
            previousNotes.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(114, 137, 218);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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

            // Let the user save the file to whatever directory they want as long as access is granted
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew);
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(NoteBox.Text);
                }
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

        private void ConverterButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        // Change color of the converter button on hover
        private void ConverterButton_MouseHover(object sender, EventArgs e)
        {
            ConverterButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        // Revert to default color of the converter button
        private void ConverterButton_OnMouseLeave(object sender, EventArgs e)
        {
            ConverterButton.ResetBackColor();
            ConverterButton.UseVisualStyleBackColor = true;
        }

        private void LoadButton_MouseHover(object sender, EventArgs e)
        {
            LoadButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void LoadButton_MouseLeave(object sender, EventArgs e)
        {
            LoadButton.ResetBackColor();
            LoadButton.UseVisualStyleBackColor = true;
        }

        private void NewButton_MouseHover(object sender, EventArgs e)
        {
            NewButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void NewButton_MouseLeave(object sender, EventArgs e)
        {
            NewButton.ResetBackColor();
            NewButton.UseVisualStyleBackColor = true;
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.ResetBackColor();
            DeleteButton.UseVisualStyleBackColor = true;
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            SaveButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.ResetBackColor();
            SaveButton.UseVisualStyleBackColor = true;
        }

        private void TimerButton_MouseHover(object sender, EventArgs e)
        {
            TimerButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void TimerButton_MouseLeave(object sender, EventArgs e)
        {
            TimerButton.ResetBackColor();
            TimerButton.UseVisualStyleBackColor = true;
        }

        private void ToDoListButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void ToDoListButton_MouseHover(object sender, EventArgs e)
        {
            ToDoListButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void ToDoListButton_MouseLeave(object sender, EventArgs e)
        {
            ToDoListButton.ResetBackColor();
            ToDoListButton.UseVisualStyleBackColor = true;
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
