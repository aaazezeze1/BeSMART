using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Wp = DocumentFormat.OpenXml.Wordprocessing;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iTextLayout = iText.Layout;
using iTextElement = iText.Layout.Element;

namespace NotesApp
{
    public partial class NotesForm : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        private ColorDialog colorDialog;

        private Class1 mp3 = new Class1();

        // Pomodoro timer

        private int timeLeft;

        private const int SECONDS = 60;
        private const int POMODORO = 25;
        private const int SHORTB = 5;
        private const int LONGB = 15;

        // Import sound player
        SoundPlayer player = new SoundPlayer();

        public NotesForm()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            dGR1previousNotes.DataSource = notes;

            // Load the fonts into the combobox when the form loads
            // Get all the Font Family names from Graphics associated to richTextBox
            // Then load the font name to the combobox
            Graphics gr = rTxtBoxNotes.CreateGraphics();
            foreach (System.Drawing.FontFamily F_family in System.Drawing.FontFamily.GetFamilies(gr))
            {
                comboBox1Font.Items.Add(F_family.Name);
            }

            // Load font sizes
            for (int fsize = 7; fsize < 73; fsize++)
            {
                comboBox1FontSize.Items.Add(fsize);
            }
        }

        private void SetNewFont()
        {
            // Declarations that will feed Font 
            System.Drawing.Font old_font = null;
            System.Drawing.Font new_font;
            String Fname;
            float Fsize = 8;
            FontStyle style = 0;
            byte charset = 0;

            // Grab required information from UI
            Fname = comboBox1Font.Text;
            if (string.IsNullOrEmpty(comboBox1FontSize.Text))
            {
                Fsize = 8;
            }
            else
            {
                Fsize = float.Parse(comboBox1FontSize.Text);
                old_font = rTxtBoxNotes.SelectionFont;
            }

            // If no font / selection text then default 
            if (old_font == null)
            {
                style = FontStyle.Regular;
            }
            else
            {
                style = old_font.Style;
                charset = old_font.GdiCharSet;
            }

            // Construct the font
            new_font = new System.Drawing.Font(Fname, Fsize, style, GraphicsUnit.Point, charset);
            rTxtBoxNotes.SelectionFont = new_font;
        }

        private void btn1Load_Click(object sender, EventArgs e)
        {
            if (dGR1previousNotes.CurrentCell != null)
            {
                txtBoxTitle.Text = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                rTxtBoxNotes.Rtf = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
        }

        private void btn3NewNote_Click(object sender, EventArgs e)
        {
            // Clear input fields and reset editing flag
            txtBoxTitle.Clear();
            rTxtBoxNotes.Clear();
            editing = false;
            dGR1previousNotes.ClearSelection(); // Optionally clear selection to avoid confusion
        }

        private void btn2Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGR1previousNotes.CurrentCell != null && dGR1previousNotes.CurrentCell.RowIndex >= 0)
                {
                    // Confirm the deletion action
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Delete the selected note
                        notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].Delete();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid note to delete.", "Invalid Selection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to delete the note: " + ex.Message);
            }
        }

        private void btn4Save_Click(object sender, EventArgs e)
        {
            if (editing && dGR1previousNotes.CurrentCell != null)
            {
                // Update existing note
                notes.Rows[dGR1previousNotes.CurrentCell.RowIndex]["Title"] = txtBoxTitle.Text;
                notes.Rows[dGR1previousNotes.CurrentCell.RowIndex]["Note"] = rTxtBoxNotes.Rtf;
            }
            else
            {
                // Add new note
                notes.Rows.Add(txtBoxTitle.Text, rTxtBoxNotes.Rtf);
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document (*.docx)|*.docx|PDF file (*.pdf)|*.pdf|Rich Text Format (*.rtf)|*.rtf|Text file (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 4;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                string extension = Path.GetExtension(filename).ToLower();
                string rtfContent = rTxtBoxNotes.Rtf;

                switch (extension)
                {
                    case ".rtf":
                        rTxtBoxNotes.SaveFile(filename, RichTextBoxStreamType.RichText);
                        break;
                    case ".pdf":
                        SaveAsPdf(filename, rtfContent);
                        break;
                    case ".docx":
                        SaveAsDocx(filename, rtfContent);
                        break;
                    case ".txt":
                        File.WriteAllText(filename, rTxtBoxNotes.Text);
                        break;
                    default:
                        MessageBox.Show("Unsupported file type.");
                        break;
                }

                txtBoxTitle.Clear();
                rTxtBoxNotes.Clear();
                editing = false;
            }
        }

        private void SaveAsPdf(string filename, string rtfContent)
        {
            // Save as plain text, no styles
            using (FileStream writer = new FileStream(filename, FileMode.Create))
            {
                var pdfWriter = new PdfWriter(writer);
                var pdf = new PdfDocument(pdfWriter);
                var document = new iText.Layout.Document(pdf);

                // Convert RTF content to HTML
                string htmlContent = ConvertRtfToHtml(rtfContent);

                // Add HTML content to PDF
                document.Add(new iText.Layout.Element.Paragraph(htmlContent));

                document.Close();
            }
        }

        private void SaveAsDocx(string filename, string rtfContent)
        {
            // Save as plain text, no formatting
            string plainText = ConvertRtfToPlainText(rtfContent);

            using (var doc = WordprocessingDocument.Create(filename, WordprocessingDocumentType.Document))
            {
                var mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Wp.Document();
                var body = new Wp.Body();

                // Add plain text content to DOCX body
                var paragraph = new Wp.Paragraph(new Wp.Run(new Wp.Text(plainText)));
                body.Append(paragraph);
                mainPart.Document.Append(body);
                mainPart.Document.Save();
            }
        }

        private string ConvertRtfToPlainText(string rtfContent)
        {
            using (var rtb = new System.Windows.Forms.RichTextBox())
            {
                rtb.Rtf = rtfContent;
                return rtb.Text;
            }
        }

        private string ConvertRtfToHtml(string rtfContent)
        {
            using (var rtb = new System.Windows.Forms.RichTextBox())
            {
                rtb.Rtf = rtfContent;
                return rtb.Text;
            }
        }

        private void dGR1previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBoxTitle.Text = notes.Rows[e.RowIndex].ItemArray[0].ToString();
                rTxtBoxNotes.Rtf = notes.Rows[e.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
        }

        private void btn5Bold_Click(object sender, EventArgs e)
        {
            if (rTxtBoxNotes.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rTxtBoxNotes.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rTxtBoxNotes.SelectionFont = newFont;
            }
        }

        private void btn6Italic_Click(object sender, EventArgs e)
        {
            if (rTxtBoxNotes.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rTxtBoxNotes.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rTxtBoxNotes.SelectionFont = newFont;
            }
        }

        private void btn3Underline_Click(object sender, EventArgs e)
        {
            if (rTxtBoxNotes.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rTxtBoxNotes.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rTxtBoxNotes.SelectionFont = newFont;
            }
        }

        // Set the font and size
        private void comboBox1Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void comboBox1FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void btn8TextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rTxtBoxNotes.SelectionColor = colorDialog.Color;
            }
        }

        private void btn9TextBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rTxtBoxNotes.SelectionBackColor = colorDialog.Color;
            }
        }

        private void btn10BulletList_Click(object sender, EventArgs e)
        {
            rTxtBoxNotes.SelectionBullet = true;
            rTxtBoxNotes.SelectionIndent = 20;  // Optional: Sets indent for better visibility
        }

        // Timer code starts here
        private void UpdateLabel()
        {
            // Convert time then update the timer
            minsLbl.Text = (this.timeLeft / SECONDS).ToString("00");
            secLbl.Text = (this.timeLeft % SECONDS).ToString("00");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer2Pomodoro.Start();
            player.Stop();
        }

        private void stopButon_Click(object sender, EventArgs e)
        {
            timer2Pomodoro.Stop();
            player.Stop();
        }

        private void pomodoroButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = POMODORO * SECONDS;
            UpdateLabel();
            timer2Pomodoro.Start();
        }

        // Notify user once timer is 0
        private void timer2Pomodoro_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft == 0)
            {
                timer2Pomodoro.Stop();

                try
                {
                    // This sound file is installed by default in Windows
                    player.SoundLocation = @"C:\Windows\Media\Alarm05.wav";
                    player.PlayLooping();

                    // If the message box is closed or the user clicks on ok then stop the music from playing
                    DialogResult result = MessageBox.Show("Time is Up!", "Timer", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        player.Stop();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        player.Stop();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                // Decrease time per tick
                this.timeLeft--;
                UpdateLabel();
            }
        }

        private void longBreakButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = LONGB * SECONDS;
            UpdateLabel();
            timer2Pomodoro.Start();
        }

        private void shortBreakButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = SHORTB * SECONDS;
            UpdateLabel();
            timer2Pomodoro.Start();
        }

        // Sidebar
        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new CalendarForm();
            SchedForm3.Show();
            //this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new ToDoForm();
            ToDoListForm5.Show();
            //this.Hide();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new FormulaForm();
            FormulaForm4.Show();
            //this.Hide();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new ConverterForm();
            ConverterForm7.Show();
            //this.Hide();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5MediaPlayer_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            //this.Hide();
            MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }

        // Music Player
        private void FSearchButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Mp3 Files|*.mp3";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    mp3.open(fd.FileName);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mp3.play();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mp3.stop();
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
