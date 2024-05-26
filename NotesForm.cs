using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import for File Saving 
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Media;


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
            txtBoxTitle.Text = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            rTxtBoxNotes.Text = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void btn3NewNote_Click(object sender, EventArgs e)
        {
            txtBoxTitle.Text = "";
            rTxtBoxNotes.Text = "";
        }

        private void btn2Delete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception)
            {
                Console.WriteLine("Not a valid note.");
            }
        }

        private void btn4Save_Click(object sender, EventArgs e)
        {
            // Check if currently editing an existing note
            if (editing)
            {
                notes.Rows[dGR1previousNotes.CurrentCell.RowIndex]["Title"] = txtBoxTitle.Text;
                notes.Rows[dGR1previousNotes.CurrentCell.RowIndex]["Note"] = rTxtBoxNotes.Text;
            }
            else
            {
                notes.Rows.Add(txtBoxTitle.Text, rTxtBoxNotes.Text);
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document (*.docx)|*.docx|PDF file (*.pdf)|*.pdf|Text file (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 3;  // Default to text files

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                string extension = Path.GetExtension(filename).ToLower();

                switch (extension)
                {
                    // Ensure text content is passed
                    case ".txt":
                        File.WriteAllText(filename, rTxtBoxNotes.Text);
                        break;
                    case ".pdf":
                        SaveAsPdf(filename, rTxtBoxNotes.Text);
                        break;
                    case ".docx":
                        SaveAsDocx(filename, rTxtBoxNotes.Text);
                        break;
                    default:
                        MessageBox.Show("Unsupported file type.");
                        break;
                }

                // Clear the text fields and reset the editing state
                txtBoxTitle.Clear();
                rTxtBoxNotes.Clear();
                editing = false;
            }
        }

        private void SaveAsPdf(string filename, string textContent)
        {
            using (FileStream writer = new FileStream(filename, FileMode.Create))
            {
                iText.Kernel.Pdf.PdfWriter pdfWriter = new iText.Kernel.Pdf.PdfWriter(writer);
                iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(pdfWriter);
                iText.Layout.Document document = new iText.Layout.Document(pdf);
                document.Add(new iText.Layout.Element.Paragraph(textContent));
                document.Close();
            }
        }

        private void SaveAsDocx(string filename, string textContent)
        {
            using (DocumentFormat.OpenXml.Packaging.WordprocessingDocument doc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Create(filename, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                DocumentFormat.OpenXml.Packaging.MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                DocumentFormat.OpenXml.Wordprocessing.Body body = new DocumentFormat.OpenXml.Wordprocessing.Body();
                body.Append(new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new DocumentFormat.OpenXml.Wordprocessing.Text(textContent))));
                mainPart.Document.Append(body);
                mainPart.Document.Save();
            }
        }
        private void dGR1previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxTitle.Text = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            rTxtBoxNotes.Text = notes.Rows[dGR1previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            editing = true;
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
            var SchedForm3 = new ScheduleForm();
            SchedForm3.Show();
            this.Hide();
            SchedForm3.FormClosed += (s, args) => this.Show();
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

        private void btn5MediaPlayer_Click(object sender, EventArgs e)
        {
            var MediaPlayerForm6 = new MediaPlayerForm();
            MediaPlayerForm6.Show();
            this.Hide();
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
    }
}
