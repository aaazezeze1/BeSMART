using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import for Media Player
using System.IO;
using AxWMPLib;

namespace NotesApp
{
    public partial class MediaPlayerForm : Form
    {
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        public MediaPlayerForm()
        {
            InitializeComponent();
        }

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.stop();

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
                    (file => file.ToLower().EndsWith("webm") ||
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
                durationLbl.Text = "Duration: " + VideoPlayer.currentMedia.durationString;
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
            VideoPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlayList()
        {
            VideoPlayer.currentPlaylist = VideoPlayer.newPlaylist("Playlist", " ");

            foreach (string videos in filteredFiles)
            {
                VideoPlayer.currentPlaylist.appendItem(VideoPlayer.newMedia(videos));
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
            VideoPlayer.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
            var FormulaForm4 = new FormulaForm();
            FormulaForm4.Show();
            this.Hide();
            FormulaForm4.FormClosed += (s, args) => this.Show();
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
            //var MediaPlayerForm6 = new MediaPlayerForm();
            //MediaPlayerForm6.Show();
            //this.Hide();
            //MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var NotesApp = new NotesApp();
            NotesApp.Show();
            this.Hide();
            NotesApp.FormClosed += (s, args) => this.Show();
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
