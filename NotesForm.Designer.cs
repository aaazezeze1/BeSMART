﻿namespace NotesApp
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            rTxtBoxNotes = new RichTextBox();
            panel7 = new Panel();
            btn10BulletList = new Button();
            label8 = new Label();
            btn9TextBackColor = new Button();
            btn8TextColor = new Button();
            label7 = new Label();
            comboBox1FontSize = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            comboBox1Font = new ComboBox();
            btn3Underline = new Button();
            btn6Italic = new Button();
            btn5Bold = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxTitle = new TextBox();
            dGR1previousNotes = new DataGridView();
            label3 = new Label();
            btn1Load = new Button();
            btn3NewNote = new Button();
            btn4Save = new Button();
            btn2Delete = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label9 = new Label();
            minsLbl = new Label();
            label10 = new Label();
            secLbl = new Label();
            timer2Pomodoro = new System.Windows.Forms.Timer(components);
            shortBreakButton = new Button();
            longBreakButton = new Button();
            stopButon = new Button();
            label11 = new Label();
            startButton = new Button();
            pomodoroButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn1Schedule = new Button();
            btn2ToDoList = new Button();
            btn4Formula = new Button();
            btn3Converter = new Button();
            btn5MediaPlayer = new Button();
            btnSearch = new Button();
            btn2Play = new Button();
            btn3Stop = new Button();
            labl1BeSMART = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGR1previousNotes).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rTxtBoxNotes
            // 
            rTxtBoxNotes.BorderStyle = BorderStyle.None;
            rTxtBoxNotes.Location = new Point(16, 103);
            rTxtBoxNotes.Name = "rTxtBoxNotes";
            rTxtBoxNotes.Size = new Size(779, 537);
            rTxtBoxNotes.TabIndex = 0;
            rTxtBoxNotes.Text = "";
            // 
            // panel7
            // 
            panel7.Controls.Add(btn10BulletList);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(btn9TextBackColor);
            panel7.Controls.Add(btn8TextColor);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(comboBox1FontSize);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(comboBox1Font);
            panel7.Controls.Add(btn3Underline);
            panel7.Controls.Add(btn6Italic);
            panel7.Controls.Add(btn5Bold);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(txtBoxTitle);
            panel7.Controls.Add(rTxtBoxNotes);
            panel7.Location = new Point(209, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(807, 721);
            panel7.TabIndex = 6;
            // 
            // btn10BulletList
            // 
            btn10BulletList.BackColor = Color.SeaGreen;
            btn10BulletList.FlatAppearance.BorderSize = 0;
            btn10BulletList.FlatStyle = FlatStyle.Flat;
            btn10BulletList.Image = (Image)resources.GetObject("btn10BulletList.Image");
            btn10BulletList.Location = new Point(685, 673);
            btn10BulletList.Name = "btn10BulletList";
            btn10BulletList.Size = new Size(37, 33);
            btn10BulletList.TabIndex = 18;
            btn10BulletList.UseVisualStyleBackColor = false;
            btn10BulletList.Click += btn10BulletList_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(685, 643);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 17;
            label8.Text = "List Style";
            // 
            // btn9TextBackColor
            // 
            btn9TextBackColor.BackColor = Color.SeaGreen;
            btn9TextBackColor.FlatAppearance.BorderSize = 0;
            btn9TextBackColor.FlatStyle = FlatStyle.Flat;
            btn9TextBackColor.Image = (Image)resources.GetObject("btn9TextBackColor.Image");
            btn9TextBackColor.Location = new Point(610, 673);
            btn9TextBackColor.Name = "btn9TextBackColor";
            btn9TextBackColor.Size = new Size(37, 33);
            btn9TextBackColor.TabIndex = 16;
            btn9TextBackColor.UseVisualStyleBackColor = false;
            btn9TextBackColor.Click += btn9TextBackColor_Click;
            // 
            // btn8TextColor
            // 
            btn8TextColor.BackColor = Color.SeaGreen;
            btn8TextColor.FlatAppearance.BorderSize = 0;
            btn8TextColor.FlatStyle = FlatStyle.Flat;
            btn8TextColor.Image = (Image)resources.GetObject("btn8TextColor.Image");
            btn8TextColor.Location = new Point(568, 673);
            btn8TextColor.Name = "btn8TextColor";
            btn8TextColor.Size = new Size(37, 33);
            btn8TextColor.TabIndex = 15;
            btn8TextColor.UseVisualStyleBackColor = false;
            btn8TextColor.Click += btn8TextColor_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(568, 643);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 15;
            label7.Text = "Font Color";
            // 
            // comboBox1FontSize
            // 
            comboBox1FontSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1FontSize.FormattingEnabled = true;
            comboBox1FontSize.Location = new Point(392, 673);
            comboBox1FontSize.Name = "comboBox1FontSize";
            comboBox1FontSize.Size = new Size(155, 31);
            comboBox1FontSize.TabIndex = 11;
            comboBox1FontSize.SelectedIndexChanged += comboBox1FontSize_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(392, 643);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 10;
            label6.Text = "Font Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 643);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 9;
            label5.Text = "Font";
            // 
            // comboBox1Font
            // 
            comboBox1Font.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1Font.FormattingEnabled = true;
            comboBox1Font.Location = new Point(177, 673);
            comboBox1Font.Name = "comboBox1Font";
            comboBox1Font.Size = new Size(193, 31);
            comboBox1Font.TabIndex = 8;
            comboBox1Font.SelectedIndexChanged += comboBox1Font_SelectedIndexChanged;
            // 
            // btn3Underline
            // 
            btn3Underline.BackColor = Color.SeaGreen;
            btn3Underline.FlatAppearance.BorderSize = 0;
            btn3Underline.FlatStyle = FlatStyle.Flat;
            btn3Underline.Image = (Image)resources.GetObject("btn3Underline.Image");
            btn3Underline.Location = new Point(117, 673);
            btn3Underline.Name = "btn3Underline";
            btn3Underline.Size = new Size(37, 33);
            btn3Underline.TabIndex = 7;
            btn3Underline.UseVisualStyleBackColor = false;
            btn3Underline.Click += btn3Underline_Click;
            // 
            // btn6Italic
            // 
            btn6Italic.BackColor = Color.SeaGreen;
            btn6Italic.FlatAppearance.BorderSize = 0;
            btn6Italic.FlatStyle = FlatStyle.Flat;
            btn6Italic.Image = (Image)resources.GetObject("btn6Italic.Image");
            btn6Italic.Location = new Point(69, 673);
            btn6Italic.Name = "btn6Italic";
            btn6Italic.Size = new Size(37, 33);
            btn6Italic.TabIndex = 6;
            btn6Italic.UseVisualStyleBackColor = false;
            btn6Italic.Click += btn6Italic_Click;
            // 
            // btn5Bold
            // 
            btn5Bold.BackColor = Color.SeaGreen;
            btn5Bold.FlatAppearance.BorderSize = 0;
            btn5Bold.FlatStyle = FlatStyle.Flat;
            btn5Bold.ForeColor = Color.White;
            btn5Bold.Image = (Image)resources.GetObject("btn5Bold.Image");
            btn5Bold.Location = new Point(21, 673);
            btn5Bold.Name = "btn5Bold";
            btn5Bold.Size = new Size(37, 33);
            btn5Bold.TabIndex = 5;
            btn5Bold.UseVisualStyleBackColor = false;
            btn5Bold.Click += btn5Bold_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 643);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 4;
            label4.Text = "Text Style";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 3;
            label2.Text = "Notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.None;
            txtBoxTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxTitle.Location = new Point(16, 36);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(779, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // dGR1previousNotes
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dGR1previousNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dGR1previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGR1previousNotes.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.SeaGreen;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dGR1previousNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dGR1previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dGR1previousNotes.DefaultCellStyle = dataGridViewCellStyle12;
            dGR1previousNotes.GridColor = Color.FromArgb(66, 69, 73);
            dGR1previousNotes.Location = new Point(1034, 35);
            dGR1previousNotes.Name = "dGR1previousNotes";
            dGR1previousNotes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGR1previousNotes.RowHeadersVisible = false;
            dGR1previousNotes.RowHeadersWidth = 51;
            dGR1previousNotes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dGR1previousNotes.Size = new Size(185, 293);
            dGR1previousNotes.TabIndex = 6;
            dGR1previousNotes.CellDoubleClick += dGR1previousNotes_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1034, 7);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 4;
            label3.Text = "My Notes";
            // 
            // btn1Load
            // 
            btn1Load.BackColor = Color.DarkSlateGray;
            btn1Load.FlatStyle = FlatStyle.Flat;
            btn1Load.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1Load.ForeColor = Color.White;
            btn1Load.Location = new Point(1034, 333);
            btn1Load.Name = "btn1Load";
            btn1Load.Size = new Size(87, 35);
            btn1Load.TabIndex = 10;
            btn1Load.Text = "Load";
            btn1Load.UseVisualStyleBackColor = false;
            btn1Load.Click += btn1Load_Click;
            // 
            // btn3NewNote
            // 
            btn3NewNote.BackColor = Color.DarkSlateGray;
            btn3NewNote.FlatStyle = FlatStyle.Flat;
            btn3NewNote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3NewNote.ForeColor = Color.White;
            btn3NewNote.Location = new Point(1034, 373);
            btn3NewNote.Name = "btn3NewNote";
            btn3NewNote.Size = new Size(89, 35);
            btn3NewNote.TabIndex = 12;
            btn3NewNote.Text = "New Note";
            btn3NewNote.UseVisualStyleBackColor = false;
            btn3NewNote.Click += btn3NewNote_Click;
            // 
            // btn4Save
            // 
            btn4Save.BackColor = Color.DarkSlateGray;
            btn4Save.FlatStyle = FlatStyle.Flat;
            btn4Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4Save.ForeColor = Color.White;
            btn4Save.Location = new Point(1133, 373);
            btn4Save.Name = "btn4Save";
            btn4Save.Size = new Size(87, 35);
            btn4Save.TabIndex = 14;
            btn4Save.Text = "Save";
            btn4Save.UseVisualStyleBackColor = false;
            btn4Save.Click += btn4Save_Click;
            // 
            // btn2Delete
            // 
            btn2Delete.BackColor = Color.DarkSlateGray;
            btn2Delete.FlatStyle = FlatStyle.Flat;
            btn2Delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2Delete.ForeColor = Color.White;
            btn2Delete.Location = new Point(1133, 333);
            btn2Delete.Name = "btn2Delete";
            btn2Delete.Size = new Size(87, 35);
            btn2Delete.TabIndex = 13;
            btn2Delete.Text = "Delete";
            btn2Delete.UseVisualStyleBackColor = false;
            btn2Delete.Click += btn2Delete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1065, 411);
            label9.Name = "label9";
            label9.Size = new Size(138, 23);
            label9.TabIndex = 15;
            label9.Text = "Pomodoro Timer";
            // 
            // minsLbl
            // 
            minsLbl.AutoSize = true;
            minsLbl.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minsLbl.Location = new Point(1065, 436);
            minsLbl.Name = "minsLbl";
            minsLbl.Size = new Size(66, 51);
            minsLbl.TabIndex = 16;
            minsLbl.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1118, 436);
            label10.Name = "label10";
            label10.Size = new Size(32, 51);
            label10.TabIndex = 17;
            label10.Text = ":";
            // 
            // secLbl
            // 
            secLbl.AutoSize = true;
            secLbl.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secLbl.Location = new Point(1137, 436);
            secLbl.Name = "secLbl";
            secLbl.Size = new Size(66, 51);
            secLbl.TabIndex = 18;
            secLbl.Text = "00";
            // 
            // timer2Pomodoro
            // 
            timer2Pomodoro.Interval = 1000;
            timer2Pomodoro.Tick += timer2Pomodoro_Tick;
            // 
            // shortBreakButton
            // 
            shortBreakButton.BackColor = Color.DarkSlateGray;
            shortBreakButton.FlatStyle = FlatStyle.Flat;
            shortBreakButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shortBreakButton.ForeColor = Color.White;
            shortBreakButton.Location = new Point(1134, 535);
            shortBreakButton.Name = "shortBreakButton";
            shortBreakButton.Size = new Size(96, 33);
            shortBreakButton.TabIndex = 23;
            shortBreakButton.Text = "Short";
            shortBreakButton.UseVisualStyleBackColor = false;
            shortBreakButton.Click += shortBreakButton_Click;
            // 
            // longBreakButton
            // 
            longBreakButton.BackColor = Color.DarkSlateGray;
            longBreakButton.FlatStyle = FlatStyle.Flat;
            longBreakButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            longBreakButton.ForeColor = Color.White;
            longBreakButton.Location = new Point(1024, 535);
            longBreakButton.Name = "longBreakButton";
            longBreakButton.Size = new Size(104, 33);
            longBreakButton.TabIndex = 22;
            longBreakButton.Text = "Long Break";
            longBreakButton.UseVisualStyleBackColor = false;
            longBreakButton.Click += longBreakButton_Click;
            // 
            // stopButon
            // 
            stopButon.BackColor = Color.DarkSlateGray;
            stopButon.FlatStyle = FlatStyle.Flat;
            stopButon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopButon.ForeColor = Color.White;
            stopButon.Location = new Point(1178, 493);
            stopButon.Name = "stopButon";
            stopButon.Size = new Size(51, 33);
            stopButon.TabIndex = 21;
            stopButon.Text = "Stop";
            stopButon.UseVisualStyleBackColor = false;
            stopButon.Click += stopButon_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(1031, 576);
            label11.Name = "label11";
            label11.Size = new Size(188, 51);
            label11.TabIndex = 24;
            label11.Text = "Pomodoro Timer = 25 minutes\r\nLong Break = 15 minutes\r\nShort Break = 5 minutes";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.DarkSlateGray;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(1024, 493);
            startButton.Name = "startButton";
            startButton.Size = new Size(51, 33);
            startButton.TabIndex = 19;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // pomodoroButton
            // 
            pomodoroButton.BackColor = Color.DarkSlateGray;
            pomodoroButton.FlatStyle = FlatStyle.Flat;
            pomodoroButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pomodoroButton.ForeColor = Color.White;
            pomodoroButton.Location = new Point(1080, 493);
            pomodoroButton.Name = "pomodoroButton";
            pomodoroButton.Size = new Size(91, 33);
            pomodoroButton.TabIndex = 20;
            pomodoroButton.Text = "Pomodoro";
            pomodoroButton.UseVisualStyleBackColor = false;
            pomodoroButton.Click += pomodoroButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.DarkSlateGray;
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(btn1Schedule);
            flowLayoutPanel2.Controls.Add(btn2ToDoList);
            flowLayoutPanel2.Controls.Add(btn4Formula);
            flowLayoutPanel2.Controls.Add(btn3Converter);
            flowLayoutPanel2.Controls.Add(btn5MediaPlayer);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(-3, -4);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(187, 741);
            flowLayoutPanel2.TabIndex = 25;
            // 
            // btn1Schedule
            // 
            btn1Schedule.BackColor = Color.DarkSlateGray;
            btn1Schedule.FlatAppearance.BorderSize = 0;
            btn1Schedule.FlatStyle = FlatStyle.Flat;
            btn1Schedule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1Schedule.ForeColor = Color.White;
            btn1Schedule.Image = (Image)resources.GetObject("btn1Schedule.Image");
            btn1Schedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn1Schedule.Location = new Point(3, 96);
            btn1Schedule.Name = "btn1Schedule";
            btn1Schedule.Padding = new Padding(30, 0, 0, 0);
            btn1Schedule.Size = new Size(226, 121);
            btn1Schedule.TabIndex = 17;
            btn1Schedule.Text = "         Schedule";
            btn1Schedule.TextAlign = ContentAlignment.MiddleLeft;
            btn1Schedule.UseVisualStyleBackColor = false;
            btn1Schedule.Click += btn1Schedule_Click;
            // 
            // btn2ToDoList
            // 
            btn2ToDoList.BackColor = Color.DarkSlateGray;
            btn2ToDoList.FlatAppearance.BorderSize = 0;
            btn2ToDoList.FlatStyle = FlatStyle.Flat;
            btn2ToDoList.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2ToDoList.ForeColor = Color.White;
            btn2ToDoList.Image = (Image)resources.GetObject("btn2ToDoList.Image");
            btn2ToDoList.ImageAlign = ContentAlignment.MiddleLeft;
            btn2ToDoList.Location = new Point(3, 223);
            btn2ToDoList.Name = "btn2ToDoList";
            btn2ToDoList.Padding = new Padding(35, 0, 0, 0);
            btn2ToDoList.Size = new Size(235, 121);
            btn2ToDoList.TabIndex = 18;
            btn2ToDoList.Text = "          To Do List";
            btn2ToDoList.TextAlign = ContentAlignment.MiddleLeft;
            btn2ToDoList.UseVisualStyleBackColor = false;
            btn2ToDoList.Click += btn2ToDoList_Click;
            // 
            // btn4Formula
            // 
            btn4Formula.BackColor = Color.DarkSlateGray;
            btn4Formula.FlatAppearance.BorderSize = 0;
            btn4Formula.FlatStyle = FlatStyle.Flat;
            btn4Formula.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4Formula.ForeColor = Color.White;
            btn4Formula.Image = (Image)resources.GetObject("btn4Formula.Image");
            btn4Formula.ImageAlign = ContentAlignment.MiddleLeft;
            btn4Formula.Location = new Point(3, 350);
            btn4Formula.Name = "btn4Formula";
            btn4Formula.Padding = new Padding(30, 0, 0, 0);
            btn4Formula.Size = new Size(226, 121);
            btn4Formula.TabIndex = 19;
            btn4Formula.Text = "         Formula";
            btn4Formula.TextAlign = ContentAlignment.MiddleLeft;
            btn4Formula.UseVisualStyleBackColor = false;
            btn4Formula.Click += btn4Formula_Click;
            // 
            // btn3Converter
            // 
            btn3Converter.BackColor = Color.DarkSlateGray;
            btn3Converter.FlatAppearance.BorderSize = 0;
            btn3Converter.FlatStyle = FlatStyle.Flat;
            btn3Converter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3Converter.ForeColor = Color.White;
            btn3Converter.Image = (Image)resources.GetObject("btn3Converter.Image");
            btn3Converter.ImageAlign = ContentAlignment.MiddleLeft;
            btn3Converter.Location = new Point(3, 477);
            btn3Converter.Name = "btn3Converter";
            btn3Converter.Padding = new Padding(30, 0, 0, 0);
            btn3Converter.Size = new Size(207, 121);
            btn3Converter.TabIndex = 20;
            btn3Converter.Text = "         Converter";
            btn3Converter.TextAlign = ContentAlignment.MiddleLeft;
            btn3Converter.UseVisualStyleBackColor = false;
            btn3Converter.Click += btn3Converter_Click;
            // 
            // btn5MediaPlayer
            // 
            btn5MediaPlayer.BackColor = Color.DarkSlateGray;
            btn5MediaPlayer.FlatAppearance.BorderSize = 0;
            btn5MediaPlayer.FlatStyle = FlatStyle.Flat;
            btn5MediaPlayer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5MediaPlayer.ForeColor = Color.White;
            btn5MediaPlayer.Image = (Image)resources.GetObject("btn5MediaPlayer.Image");
            btn5MediaPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btn5MediaPlayer.Location = new Point(3, 604);
            btn5MediaPlayer.Name = "btn5MediaPlayer";
            btn5MediaPlayer.Padding = new Padding(30, 0, 0, 0);
            btn5MediaPlayer.Size = new Size(234, 120);
            btn5MediaPlayer.TabIndex = 21;
            btn5MediaPlayer.Text = "         Media Player";
            btn5MediaPlayer.TextAlign = ContentAlignment.MiddleLeft;
            btn5MediaPlayer.UseVisualStyleBackColor = false;
            btn5MediaPlayer.Click += btn5MediaPlayer_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1034, 641);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(182, 35);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Song Files";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += FSearchButton_Click;
            // 
            // btn2Play
            // 
            btn2Play.BackColor = Color.DarkSlateGray;
            btn2Play.FlatAppearance.BorderSize = 0;
            btn2Play.FlatStyle = FlatStyle.Flat;
            btn2Play.ForeColor = Color.White;
            btn2Play.Location = new Point(1034, 684);
            btn2Play.Margin = new Padding(3, 4, 3, 4);
            btn2Play.Name = "btn2Play";
            btn2Play.Size = new Size(86, 35);
            btn2Play.TabIndex = 27;
            btn2Play.Text = "Play";
            btn2Play.UseVisualStyleBackColor = false;
            btn2Play.Click += PlayButton_Click;
            // 
            // btn3Stop
            // 
            btn3Stop.BackColor = Color.DarkSlateGray;
            btn3Stop.FlatAppearance.BorderSize = 0;
            btn3Stop.FlatStyle = FlatStyle.Flat;
            btn3Stop.ForeColor = Color.White;
            btn3Stop.Location = new Point(1130, 683);
            btn3Stop.Margin = new Padding(3, 4, 3, 4);
            btn3Stop.Name = "btn3Stop";
            btn3Stop.Size = new Size(86, 35);
            btn3Stop.TabIndex = 28;
            btn3Stop.Text = "Stop";
            btn3Stop.UseVisualStyleBackColor = false;
            btn3Stop.Click += StopButton_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labl1BeSMART);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 87);
            panel1.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 730);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(226, 121);
            button1.TabIndex = 22;
            button1.Text = "         Schedule";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 735);
            Controls.Add(btn3Stop);
            Controls.Add(btn2Play);
            Controls.Add(btnSearch);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label11);
            Controls.Add(shortBreakButton);
            Controls.Add(stopButon);
            Controls.Add(pomodoroButton);
            Controls.Add(secLbl);
            Controls.Add(label10);
            Controls.Add(minsLbl);
            Controls.Add(btn4Save);
            Controls.Add(btn2Delete);
            Controls.Add(btn1Load);
            Controls.Add(btn3NewNote);
            Controls.Add(dGR1previousNotes);
            Controls.Add(panel7);
            Controls.Add(longBreakButton);
            Controls.Add(startButton);
            Controls.Add(label9);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write Notes";
            Load += Form2_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGR1previousNotes).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rTxtBoxNotes;
        private Panel panel7;
        private Label label1;
        private TextBox txtBoxTitle;
        private Label label2;
        private DataGridView dGR1previousNotes;
        private Label label3;
        private Button btn1Load;
        private Button btn3NewNote;
        private Button btn4Save;
        private Button btn2Delete;
        private SaveFileDialog saveFileDialog1;
        private Button btn5Bold;
        private Label label4;
        private Button btn3Underline;
        private Button btn6Italic;
        private ComboBox comboBox1FontSize;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1Font;
        private Button btn9TextBackColor;
        private Button btn8TextColor;
        private Label label7;
        private Label label8;
        private Button btn10BulletList;
        private Label label9;
        private Label minsLbl;
        private Label label10;
        private Label secLbl;
        private System.Windows.Forms.Timer timer2Pomodoro;
        private Button shortBreakButton;
        private Button longBreakButton;
        private Button stopButon;
        private Label label11;
        private Button startButton;
        private Button pomodoroButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn1Schedule;
        private Button btn2ToDoList;
        private Button btn4Formula;
        private Button btn3Converter;
        private Button btn5MediaPlayer;
        private Button btnSearch;
        private Button btn2Play;
        private Button btn3Stop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labl1BeSMART;
        private Button button1;
    }
}