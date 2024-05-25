namespace NotesApp
{
    partial class NotesApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesApp));
            fLP2NotesContent = new FlowLayoutPanel();
            panel7 = new Panel();
            label1 = new Label();
            pbtn2AddNotes = new PictureBox();
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
            fLP2NotesContent.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbtn2AddNotes).BeginInit();
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
            // fLP2NotesContent
            // 
            fLP2NotesContent.BackColor = Color.WhiteSmoke;
            fLP2NotesContent.Controls.Add(panel7);
            fLP2NotesContent.Location = new Point(187, 0);
            fLP2NotesContent.Name = "fLP2NotesContent";
            fLP2NotesContent.Size = new Size(722, 639);
            fLP2NotesContent.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(label1);
            panel7.Controls.Add(pbtn2AddNotes);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.Yes;
            panel7.Size = new Size(715, 621);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(535, 581);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Create a Note";
            // 
            // pbtn2AddNotes
            // 
            pbtn2AddNotes.Image = (Image)resources.GetObject("pbtn2AddNotes.Image");
            pbtn2AddNotes.Location = new Point(658, 561);
            pbtn2AddNotes.Name = "pbtn2AddNotes";
            pbtn2AddNotes.Size = new Size(55, 60);
            pbtn2AddNotes.TabIndex = 0;
            pbtn2AddNotes.TabStop = false;
            pbtn2AddNotes.Click += pbtn2AddNotes_Click;
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
            fLP1Sidebar.TabIndex = 5;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(btn1Schedule);
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 99);
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
            panel3.Location = new Point(3, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 99);
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
            btn2ToDoList.Click += btn2ToDoList_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(btn4Formula);
            panel5.Location = new Point(3, 306);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 99);
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
            panel4.Location = new Point(3, 411);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 99);
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
            panel6.Controls.Add(btn5MediaPlayer);
            panel6.Location = new Point(3, 516);
            panel6.Name = "panel6";
            panel6.Size = new Size(187, 99);
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
            btn5MediaPlayer.Size = new Size(234, 120);
            btn5MediaPlayer.TabIndex = 3;
            btn5MediaPlayer.Text = "         Media Player";
            btn5MediaPlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn5MediaPlayer.UseVisualStyleBackColor = false;
            btn5MediaPlayer.Click += btn5MediaPlayer_Click;
            // 
            // NotesApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 636);
            Controls.Add(fLP1Sidebar);
            Controls.Add(fLP2NotesContent);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "NotesApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeSMART";
            fLP2NotesContent.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbtn2AddNotes).EndInit();
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
        }

        #endregion
        private Panel panel1;
        private Label labl1BeSMART;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel fLP1Sidebar;
        private Panel panel2;
        private Button btn1Schedule;
        private Panel panel3;
        private Button btn2ToDoList;
        private Panel panel4;
        private Button btn3Converter;
        private Panel panel5;
        private Button btn4Formula;
        private Panel panel6;
        private Button btn5MediaPlayer;
        private FlowLayoutPanel fLP2NotesContent;
        private PictureBox pbtn2AddNotes;
        private Panel panel7;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
    }
}
