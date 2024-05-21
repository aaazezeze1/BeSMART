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
    public partial class Form6 : Form
    {
        List<string> filteredFiles = new List<string>();
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentFile = 0;

        public Form6()
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

        private void LoadFolderEvent(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();

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
                durationLbl.Text = "Duration: " + MediaPlayer.currentMedia.durationString;
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
            MediaPlayer.Ctlcontrols.play();
            timer1.Stop();
        }

        private void LoadPlayList()
        {
            MediaPlayer.currentPlaylist = MediaPlayer.newPlaylist("Playlist", " ");

            foreach (string videos in filteredFiles)
            {
                MediaPlayer.currentPlaylist.appendItem(MediaPlayer.newMedia(videos));
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
            MediaPlayer.URL = url;
        }

        private void ShowFileName(Label name)
        {
            string file = Path.GetFileName(Playlist.SelectedItem.ToString());
            name.Text = "Currently Playing: " + file;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is made by Amazing Cabiles and Cyrelle Gapit");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn1Schedule_Click(object sender, EventArgs e)
        {
            var SchedForm3 = new Form3();
            SchedForm3.Show();
            SchedForm3.FormClosed += (s, args) => this.Show();
        }

        private void btn2ToDoList_Click(object sender, EventArgs e)
        {
            var ToDoListForm5 = new Form5();
            ToDoListForm5.Show();
            ToDoListForm5.FormClosed += (s, args) => this.Show();
        }

        private void btn4Formula_Click(object sender, EventArgs e)
        {
            var FormulaForm4 = new Form4();
            FormulaForm4.Show();
            FormulaForm4.FormClosed += (s, args) => this.Show();
        }

        private void btn3Converter_Click(object sender, EventArgs e)
        {
            var ConverterForm7 = new Form7();
            ConverterForm7.Show();
            ConverterForm7.FormClosed += (s, args) => this.Show();
        }

        private void btn5Settings_Click(object sender, EventArgs e)
        {
            //var MediaPlayerForm6 = new Form6();
            //MediaPlayerForm6.Show();
            //MediaPlayerForm6.FormClosed += (s, args) => this.Show();
        }
    }
}
