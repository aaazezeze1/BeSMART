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

// Import for Media Player
using System.IO;
using AxWMPLib;

namespace NotesApp
{
    public partial class NotesForm : Form
    {
        // Notes App
        DataTable notes = new DataTable();
        bool editing = false;
        private ColorDialog colorDialog;

        // Media Player
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        // Pomodoro Timer
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

        private void ToggleButtonColor(Button button, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = Color.LightGray;
            }
            else
            {
                button.BackColor = Color.SeaGreen;
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
                ToggleButtonColor((Button)sender, newFont.Bold);
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
                ToggleButtonColor((Button)sender, newFont.Italic);
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
                ToggleButtonColor((Button)sender, newFont.Underline);
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
            rTxtBoxNotes.SelectionIndent = 20;
        }
        private void btnClearTextFormat_Click(object sender, EventArgs e)
        {
            // Save the current selection
            int start = rTxtBoxNotes.SelectionStart;
            int length = rTxtBoxNotes.SelectionLength;

            // Select the entire text if nothing is selected
            if (length == 0)
            {
                rTxtBoxNotes.SelectAll();
            }

            // Remove formatting from the selected text
            rTxtBoxNotes.SelectionFont = new Font(rTxtBoxNotes.Font, FontStyle.Regular);
            rTxtBoxNotes.SelectionColor = rTxtBoxNotes.ForeColor;
            rTxtBoxNotes.SelectionBackColor = rTxtBoxNotes.BackColor;
            rTxtBoxNotes.SelectionBullet = false;
            rTxtBoxNotes.SelectionIndent = 0;

            // Clear the selection and reset the cursor position
            rTxtBoxNotes.SelectionLength = 0;
            rTxtBoxNotes.SelectionStart = start;

            // Clear formatting toggles for buttons (if applicable)
            ToggleButtonColor(btn5Bold, false);
            ToggleButtonColor(btn6Italic, false);
            ToggleButtonColor(btn3Underline, false);
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

        // Media Player

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            VidMedia.Ctlcontrols.stop();

            if (filteredFiles.Count > 1)
            {
                filteredFiles.Clear();
                filteredFiles = null;

                Playlist.Items.Clear();
                currentFile = 0;
            }

            DialogResult result = browser.ShowDialog();

            // Only show the following file types
            if (result == DialogResult.OK)
            {
                filteredFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where
                    (file => file.ToLower().EndsWith("webm") || file.ToLower().EndsWith("mp3") ||
                    file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("wmv")
                    || file.ToLower().EndsWith("mkv") || file.ToLower().EndsWith("avi")).ToList();

                LoadPlayList();
            }
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Media Player Status
            if (e.newState == 0)
            {
                // Load Media Player
                durationLbl.Text = "Media Player is Ready";
            }
            else if (e.newState == 1)
            {
                // Stop media
                durationLbl.Text = "Media Player Stopped";
            }
            else if (e.newState == 3)
            {
                // Play media
                durationLbl.Text = "Duration: " + VidMedia.currentMedia.durationString;
            }
            else if (e.newState == 8)
            {
                // Loop media
                if (currentFile >= filteredFiles.Count - 1)
                {
                    currentFile = 0;
                }
                else
                {
                    currentFile += 1;
                }
                Playlist.SelectedIndex = currentFile;

                ShowFileName(FileName);
            }
            else if (e.newState == 9)
            {
                // Load new media
                durationLbl.Text = "Loading Media";
            }
            else if (e.newState == 10)
            {
                timer1.Start();
            }
        }

        private void PlayListChanged(object sender, EventArgs e)
        {
            currentFile = Playlist.SelectedIndex;
            PlayFile(Playlist.SelectedItem.ToString());
            ShowFileName(FileName);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            VidMedia.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlayList()
        {
            VidMedia.currentPlaylist = VidMedia.newPlaylist("Playlist", " ");

            foreach (string videos in filteredFiles)
            {
                VidMedia.currentPlaylist.appendItem(VidMedia.newMedia(videos));
                Playlist.Items.Add(videos);
            }

            if (filteredFiles.Count > 0)
            {
                FileName.Text = "Files Found " + filteredFiles.Count;
                Playlist.SelectedIndex = currentFile;
                PlayFile(Playlist.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No Video Files Found in this Folder");
            }
        }

        private void PlayFile(string url)
        {
            VidMedia.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
