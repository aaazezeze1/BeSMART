using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import library for playing music
using System.Media;

namespace NotesApp
{
    public partial class Form4 : Form
    {
        private int timeLeft;

        private const int SECONDS = 60;
        private const int POMODORO = 25;
        private const int SHORTB = 1;
        private const int LONGB = 15;

        // Import sound player
        SoundPlayer player = new SoundPlayer();

        public Form4()
        {
            InitializeComponent();
        }

        private void UpdateLabel()
        {
            // Convert time then update the timer
            minsLbl.Text = (this.timeLeft / SECONDS).ToString("00");
            secLbl.Text = (this.timeLeft % SECONDS).ToString("00");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            player.Stop();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Stop();
        }

        // 25 minutes
        private void PomodoroButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = POMODORO * SECONDS;
            UpdateLabel();
            timer1.Start();
        }

        // Notify user once timer is 0
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft == 0)
            {
                timer1.Stop();

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

        // 5 minutes
        private void ShortBButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = SHORTB * SECONDS;
            UpdateLabel();
            timer1.Start();
        }

        // 15 minutes
        private void LongBButton_Click(object sender, EventArgs e)
        {
            this.timeLeft = LONGB * SECONDS;
            UpdateLabel();
            timer1.Start();
        }

        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            StartButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            StartButton.ResetBackColor();
            StartButton.UseVisualStyleBackColor = true;
        }

        private void PomodoroButton_MouseHover(object sender, EventArgs e)
        {
            PomodoroButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void PomodoroButton_MouseLeave(object sender, EventArgs e)
        {
            PomodoroButton.ResetBackColor();
            PomodoroButton.UseVisualStyleBackColor = true;
        }

        private void StopButton_MouseHover(object sender, EventArgs e)
        {
            StopButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            StopButton.ResetBackColor();
            StopButton.UseVisualStyleBackColor = true;
        }

        private void LongBButton_MouseHover(object sender, EventArgs e)
        {
            LongBButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void LongBButton_MouseLeave(object sender, EventArgs e)
        {
            LongBButton.ResetBackColor();
            LongBButton.UseVisualStyleBackColor = true;
        }

        private void ShortBButton_MouseHover(object sender, EventArgs e)
        {
            ShortBButton.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void ShortBButton_MouseLeave(object sender, EventArgs e)
        {
            ShortBButton.ResetBackColor();
            ShortBButton.UseVisualStyleBackColor = true;
        }
    }
}
