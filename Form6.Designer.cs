namespace NotesApp
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadFolderToolStripMenuItem = new ToolStripMenuItem();
            MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            Playlist = new ListBox();
            FileName = new Label();
            durationLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1146, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadFolderToolStripMenuItem
            // 
            loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            loadFolderToolStripMenuItem.Size = new Size(136, 22);
            loadFolderToolStripMenuItem.Text = "Load Folder";
            loadFolderToolStripMenuItem.Click += LoadFolderEvent;
            // 
            // MediaPlayer
            // 
            MediaPlayer.Enabled = true;
            MediaPlayer.Location = new Point(228, 27);
            MediaPlayer.Name = "MediaPlayer";
            MediaPlayer.OcxState = (AxHost.State)resources.GetObject("MediaPlayer.OcxState");
            MediaPlayer.Size = new Size(906, 543);
            MediaPlayer.TabIndex = 1;
            MediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
            // 
            // Playlist
            // 
            Playlist.FormattingEnabled = true;
            Playlist.ItemHeight = 15;
            Playlist.Location = new Point(12, 27);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(202, 544);
            Playlist.TabIndex = 2;
            Playlist.SelectedIndexChanged += PlayListChanged;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(228, 580);
            FileName.Name = "FileName";
            FileName.Size = new Size(52, 21);
            FileName.TabIndex = 3;
            FileName.Text = "Name";
            // 
            // durationLbl
            // 
            durationLbl.AutoSize = true;
            durationLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationLbl.ForeColor = Color.White;
            durationLbl.Location = new Point(12, 580);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(87, 21);
            durationLbl.TabIndex = 4;
            durationLbl.Text = "Duration: 0";
            // 
            // timer1
            // 
            timer1.Tick += TimerEvent;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(1146, 610);
            Controls.Add(menuStrip1);
            Controls.Add(durationLbl);
            Controls.Add(FileName);
            Controls.Add(Playlist);
            Controls.Add(MediaPlayer);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MP4 Player";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadFolderToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private ListBox Playlist;
        private Label FileName;
        private Label durationLbl;
        private System.Windows.Forms.Timer timer1;
    }
}