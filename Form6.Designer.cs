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
            aboutToolStripMenuItem = new ToolStripMenuItem();
            MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            Playlist = new ListBox();
            FileName = new Label();
            durationLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer1SidebarTransition = new System.Windows.Forms.Timer(components);
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
            btn5Settings = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).BeginInit();
            fLP1Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(303, 22);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(65, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFolderToolStripMenuItem, aboutToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(56, 32);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadFolderToolStripMenuItem
            // 
            loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            loadFolderToolStripMenuItem.Size = new Size(202, 32);
            loadFolderToolStripMenuItem.Text = "Load Folder";
            loadFolderToolStripMenuItem.Click += LoadFolderEvent;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(202, 32);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MediaPlayer
            // 
            MediaPlayer.Enabled = true;
            MediaPlayer.Location = new Point(303, 64);
            MediaPlayer.Margin = new Padding(3, 4, 3, 4);
            MediaPlayer.Name = "MediaPlayer";
            MediaPlayer.OcxState = (AxHost.State)resources.GetObject("MediaPlayer.OcxState");
            MediaPlayer.Size = new Size(548, 377);
            MediaPlayer.TabIndex = 1;
            MediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;
            // 
            // Playlist
            // 
            Playlist.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Playlist.FormattingEnabled = true;
            Playlist.ItemHeight = 28;
            Playlist.Location = new Point(110, 64);
            Playlist.Margin = new Padding(3, 4, 3, 4);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(167, 368);
            Playlist.TabIndex = 2;
            Playlist.SelectedIndexChanged += PlayListChanged;
            // 
            // FileName
            // 
            FileName.AutoSize = true;
            FileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(493, 466);
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
            durationLbl.Location = new Point(303, 466);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(109, 28);
            durationLbl.TabIndex = 4;
            durationLbl.Text = "Duration: 0";
            // 
            // timer1
            // 
            timer1.Tick += TimerEvent;
            // 
            // timer1SidebarTransition
            // 
            timer1SidebarTransition.Interval = 10;
            timer1SidebarTransition.Tick += timer1SidebarTransition_Tick;
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
            fLP1Sidebar.Size = new Size(71, 636);
            fLP1Sidebar.TabIndex = 10;
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
            labl1BeSMART.Location = new Point(71, 34);
            labl1BeSMART.Name = "labl1BeSMART";
            labl1BeSMART.Size = new Size(105, 28);
            labl1BeSMART.TabIndex = 2;
            labl1BeSMART.Text = "BeSMART";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(btn1Schedule);
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 98);
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
            btn1Schedule.Click += btn1Schedule_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(btn2ToDoList);
            panel3.Location = new Point(3, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 98);
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
            btn2ToDoList.Size = new Size(236, 121);
            btn2ToDoList.TabIndex = 3;
            btn2ToDoList.Text = "          To Do List";
            btn2ToDoList.TextAlign = ContentAlignment.MiddleLeft;
            btn2ToDoList.UseVisualStyleBackColor = false;
            btn2ToDoList.Click += btn2ToDoList_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(btn4Formula);
            panel5.Location = new Point(3, 304);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 98);
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
            btn4Formula.Click += btn4Formula_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSlateGray;
            panel4.Controls.Add(btn3Converter);
            panel4.Location = new Point(3, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 98);
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
            btn3Converter.Location = new Point(-9, -14);
            btn3Converter.Name = "btn3Converter";
            btn3Converter.Padding = new Padding(30, 0, 0, 0);
            btn3Converter.Size = new Size(207, 121);
            btn3Converter.TabIndex = 3;
            btn3Converter.Text = "         Converter";
            btn3Converter.TextAlign = ContentAlignment.MiddleLeft;
            btn3Converter.UseVisualStyleBackColor = false;
            btn3Converter.Click += btn3Converter_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateGray;
            panel6.Controls.Add(btn5Settings);
            panel6.Location = new Point(3, 512);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 98);
            panel6.TabIndex = 6;
            // 
            // btn5Settings
            // 
            btn5Settings.BackColor = Color.DarkSlateGray;
            btn5Settings.FlatStyle = FlatStyle.Flat;
            btn5Settings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5Settings.ForeColor = Color.White;
            btn5Settings.Image = (Image)resources.GetObject("btn5Settings.Image");
            btn5Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn5Settings.Location = new Point(-8, -13);
            btn5Settings.Name = "btn5Settings";
            btn5Settings.Padding = new Padding(30, 0, 0, 0);
            btn5Settings.Size = new Size(234, 120);
            btn5Settings.TabIndex = 3;
            btn5Settings.Text = "         Settings";
            btn5Settings.TextAlign = ContentAlignment.MiddleLeft;
            btn5Settings.UseVisualStyleBackColor = false;
            btn5Settings.Click += btn5Settings_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(1093, 636);
            Controls.Add(fLP1Sidebar);
            Controls.Add(menuStrip1);
            Controls.Add(durationLbl);
            Controls.Add(FileName);
            Controls.Add(Playlist);
            Controls.Add(MediaPlayer);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MP4 Player";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).EndInit();
            fLP1Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
        private ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1SidebarTransition;
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
        private Button btn5Settings;
    }
}