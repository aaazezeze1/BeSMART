namespace NotesApp
{
    partial class MediaPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerForm));
            Playlist = new ListBox();
            FileName = new Label();
            durationLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            fLP1Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labl1BeSMART = new Label();
            panel2 = new Panel();
            btn1Schedule = new Button();
            panel3 = new Panel();
            btn2ToDoList = new Button();
            panel5 = new Panel();
            btn4Formula = new Button();
            panel4 = new Panel();
            btn3Converter = new Button();
            panel6 = new Panel();
            btn5MediaPlayer = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            loadFolderToolStripMenuItem1 = new ToolStripMenuItem();
            VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panel7 = new Panel();
            fLP1Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VideoPlayer).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // Playlist
            // 
            Playlist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Playlist.FormattingEnabled = true;
            Playlist.ItemHeight = 28;
            Playlist.Location = new Point(-1, 0);
            Playlist.Margin = new Padding(3, 4, 3, 4);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(208, 536);
            Playlist.TabIndex = 2;
            Playlist.SelectedIndexChanged += PlayListChanged;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(216, 554);
            FileName.Name = "FileName";
            FileName.Size = new Size(64, 28);
            FileName.TabIndex = 3;
            FileName.Text = "Name";
            // 
            // durationLbl
            // 
            durationLbl.AutoSize = true;
            durationLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationLbl.ForeColor = Color.White;
            durationLbl.Location = new Point(3, 554);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(109, 28);
            durationLbl.TabIndex = 4;
            durationLbl.Text = "Duration: 0";
            // 
            // timer1
            // 
            timer1.Tick += TimerEvent;
            // 
            // fLP1Sidebar
            // 
            fLP1Sidebar.BackColor = Color.DarkSlateGray;
            fLP1Sidebar.Controls.Add(panel1);
            fLP1Sidebar.Controls.Add(panel2);
            fLP1Sidebar.Controls.Add(panel3);
            fLP1Sidebar.Controls.Add(panel5);
            fLP1Sidebar.Controls.Add(panel4);
            fLP1Sidebar.Controls.Add(panel6);
            fLP1Sidebar.Dock = DockStyle.Left;
            fLP1Sidebar.Location = new Point(0, 0);
            fLP1Sidebar.Name = "fLP1Sidebar";
            fLP1Sidebar.Size = new Size(187, 636);
            fLP1Sidebar.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labl1BeSMART);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 87);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labl1BeSMART
            // 
            labl1BeSMART.AutoSize = true;
            labl1BeSMART.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labl1BeSMART.ForeColor = Color.White;
            labl1BeSMART.Location = new Point(71, 35);
            labl1BeSMART.Name = "labl1BeSMART";
            labl1BeSMART.Size = new Size(105, 28);
            labl1BeSMART.TabIndex = 2;
            labl1BeSMART.Text = "BeSMART";
            labl1BeSMART.Click += labl1BeSMART_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(btn1Schedule);
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 99);
            panel2.TabIndex = 2;
            // 
            // btn1Schedule
            // 
            btn1Schedule.BackColor = Color.DarkSlateGray;
            btn1Schedule.FlatStyle = FlatStyle.Flat;
            btn1Schedule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1Schedule.ForeColor = Color.White;
            btn1Schedule.Image = (Image)resources.GetObject("btn1Schedule.Image");
            btn1Schedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn1Schedule.Location = new Point(-9, -12);
            btn1Schedule.Name = "btn1Schedule";
            btn1Schedule.Padding = new Padding(30, 0, 0, 0);
            btn1Schedule.Size = new Size(226, 121);
            btn1Schedule.TabIndex = 3;
            btn1Schedule.Text = "         Schedule";
            btn1Schedule.TextAlign = ContentAlignment.MiddleLeft;
            btn1Schedule.UseVisualStyleBackColor = false;
            btn1Schedule.Click += btn1Schedule_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(btn2ToDoList);
            panel3.Location = new Point(3, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 99);
            panel3.TabIndex = 3;
            // 
            // btn2ToDoList
            // 
            btn2ToDoList.BackColor = Color.DarkSlateGray;
            btn2ToDoList.FlatStyle = FlatStyle.Flat;
            btn2ToDoList.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2ToDoList.ForeColor = Color.White;
            btn2ToDoList.Image = (Image)resources.GetObject("btn2ToDoList.Image");
            btn2ToDoList.ImageAlign = ContentAlignment.MiddleLeft;
            btn2ToDoList.Location = new Point(-19, -11);
            btn2ToDoList.Name = "btn2ToDoList";
            btn2ToDoList.Padding = new Padding(35, 0, 0, 0);
            btn2ToDoList.Size = new Size(235, 121);
            btn2ToDoList.TabIndex = 3;
            btn2ToDoList.Text = "          To Do List";
            btn2ToDoList.TextAlign = ContentAlignment.MiddleLeft;
            btn2ToDoList.UseVisualStyleBackColor = false;
            btn2ToDoList.Click += btn2ToDoList_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(btn4Formula);
            panel5.Location = new Point(3, 306);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 99);
            panel5.TabIndex = 5;
            // 
            // btn4Formula
            // 
            btn4Formula.BackColor = Color.DarkSlateGray;
            btn4Formula.FlatStyle = FlatStyle.Flat;
            btn4Formula.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4Formula.ForeColor = Color.White;
            btn4Formula.Image = (Image)resources.GetObject("btn4Formula.Image");
            btn4Formula.ImageAlign = ContentAlignment.MiddleLeft;
            btn4Formula.Location = new Point(-9, -11);
            btn4Formula.Name = "btn4Formula";
            btn4Formula.Padding = new Padding(30, 0, 0, 0);
            btn4Formula.Size = new Size(226, 121);
            btn4Formula.TabIndex = 3;
            btn4Formula.Text = "         Formula";
            btn4Formula.TextAlign = ContentAlignment.MiddleLeft;
            btn4Formula.UseVisualStyleBackColor = false;
            btn4Formula.Click += btn4Formula_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(btn3Converter);
            panel4.Location = new Point(3, 411);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 99);
            panel4.TabIndex = 4;
            // 
            // btn3Converter
            // 
            btn3Converter.BackColor = Color.DarkSlateGray;
            btn3Converter.FlatStyle = FlatStyle.Flat;
            btn3Converter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3Converter.ForeColor = Color.White;
            btn3Converter.Image = (Image)resources.GetObject("btn3Converter.Image");
            btn3Converter.ImageAlign = ContentAlignment.MiddleLeft;
            btn3Converter.Location = new Point(-9, -13);
            btn3Converter.Name = "btn3Converter";
            btn3Converter.Padding = new Padding(30, 0, 0, 0);
            btn3Converter.Size = new Size(205, 121);
            btn3Converter.TabIndex = 3;
            btn3Converter.Text = "         Converter";
            btn3Converter.TextAlign = ContentAlignment.MiddleLeft;
            btn3Converter.UseVisualStyleBackColor = false;
            btn3Converter.Click += btn3Converter_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Controls.Add(btn5MediaPlayer);
            panel6.Location = new Point(3, 516);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 99);
            panel6.TabIndex = 6;
            // 
            // btn5MediaPlayer
            // 
            btn5MediaPlayer.BackColor = Color.DarkSlateGray;
            btn5MediaPlayer.FlatStyle = FlatStyle.Flat;
            btn5MediaPlayer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5MediaPlayer.ForeColor = Color.White;
            btn5MediaPlayer.Image = (Image)resources.GetObject("btn5MediaPlayer.Image");
            btn5MediaPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btn5MediaPlayer.Location = new Point(-8, -13);
            btn5MediaPlayer.Name = "btn5MediaPlayer";
            btn5MediaPlayer.Padding = new Padding(30, 0, 0, 0);
            btn5MediaPlayer.Size = new Size(225, 120);
            btn5MediaPlayer.TabIndex = 3;
            btn5MediaPlayer.Text = "         Media Player";
            btn5MediaPlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn5MediaPlayer.UseVisualStyleBackColor = false;
            btn5MediaPlayer.Click += btn5MediaPlayer_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip2.Location = new Point(187, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(1026, 38);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadFolderToolStripMenuItem1 });
            fileToolStripMenuItem1.Font = new Font("Segoe UI", 12F);
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(56, 32);
            fileToolStripMenuItem1.Text = "File";
            // 
            // loadFolderToolStripMenuItem1
            // 
            loadFolderToolStripMenuItem1.Name = "loadFolderToolStripMenuItem1";
            loadFolderToolStripMenuItem1.Size = new Size(202, 32);
            loadFolderToolStripMenuItem1.Text = "Load Folder";
            loadFolderToolStripMenuItem1.Click += LoadFolderEvent;
            // 
            // VideoPlayer
            // 
            VideoPlayer.Enabled = true;
            VideoPlayer.Location = new Point(207, 0);
            VideoPlayer.Margin = new Padding(3, 4, 3, 4);
            VideoPlayer.Name = "VideoPlayer";
            VideoPlayer.OcxState = (AxHost.State)resources.GetObject("VideoPlayer.OcxState");
            VideoPlayer.Size = new Size(809, 536);
            VideoPlayer.TabIndex = 9;
            VideoPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
            // 
            // panel7
            // 
            panel7.Controls.Add(Playlist);
            panel7.Controls.Add(VideoPlayer);
            panel7.Controls.Add(durationLbl);
            panel7.Controls.Add(FileName);
            panel7.Location = new Point(188, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(1023, 598);
            panel7.TabIndex = 10;
            // 
            // MediaPlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(1213, 636);
            Controls.Add(menuStrip2);
            Controls.Add(fLP1Sidebar);
            Controls.Add(panel7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MediaPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Player";
            fLP1Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VideoPlayer).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private ListBox Playlist;
        private Label FileName;
        private Label durationLbl;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel fLP1Sidebar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labl1BeSMART;
        private Panel panel2;
        private Button btn1Schedule;
        private Panel panel3;
        private Button btn2ToDoList;
        private Panel panel5;
        private Button btn4Formula;
        private Panel panel4;
        private Button btn3Converter;
        private Panel panel6;
        private Button btn5MediaPlayer;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem loadFolderToolStripMenuItem1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private Panel panel7;
    }
}