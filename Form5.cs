using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form5 : Form
    {
        private Class1 mp3 = new Class1();

        public Form5()
        {
            InitializeComponent();
        }

        // Only show mp3 files
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
    }
}
