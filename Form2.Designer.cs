namespace NotesApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            timer1SidebarTransition = new System.Windows.Forms.Timer(components);
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
            startButton = new Button();
            pomodoroButton = new Button();
            stopButon = new Button();
            longBreakButton = new Button();
            shortBreakButton = new Button();
            label11 = new Label();
            timer2Pomodoro = new System.Windows.Forms.Timer(components);
            fLP1Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGR1previousNotes).BeginInit();
            SuspendLayout();
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
            fLP1Sidebar.Size = new Size(74, 636);
            fLP1Sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labl1BeSMART);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 87);
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
            // 
            // timer1SidebarTransition
            // 
            timer1SidebarTransition.Interval = 10;
            timer1SidebarTransition.Tick += timer1SidebarTransition_Tick;
            // 
            // rTxtBoxNotes
            // 
            rTxtBoxNotes.BorderStyle = BorderStyle.None;
            rTxtBoxNotes.Location = new Point(16, 103);
            rTxtBoxNotes.Name = "rTxtBoxNotes";
            rTxtBoxNotes.Size = new Size(780, 440);
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
            panel7.Location = new Point(74, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(807, 633);
            panel7.TabIndex = 6;
            panel7.Paint += panel7_Paint;
            // 
            // btn10BulletList
            // 
            btn10BulletList.BackColor = Color.LightGray;
            btn10BulletList.FlatStyle = FlatStyle.Popup;
            btn10BulletList.Image = (Image)resources.GetObject("btn10BulletList.Image");
            btn10BulletList.Location = new Point(681, 577);
            btn10BulletList.Name = "btn10BulletList";
            btn10BulletList.Size = new Size(36, 33);
            btn10BulletList.TabIndex = 18;
            btn10BulletList.UseVisualStyleBackColor = false;
            btn10BulletList.Click += btn10BulletList_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(681, 546);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 17;
            label8.Text = "List Style";
            // 
            // btn9TextBackColor
            // 
            btn9TextBackColor.BackColor = Color.LightGray;
            btn9TextBackColor.FlatStyle = FlatStyle.Popup;
            btn9TextBackColor.Image = (Image)resources.GetObject("btn9TextBackColor.Image");
            btn9TextBackColor.Location = new Point(607, 577);
            btn9TextBackColor.Name = "btn9TextBackColor";
            btn9TextBackColor.Size = new Size(36, 33);
            btn9TextBackColor.TabIndex = 16;
            btn9TextBackColor.UseVisualStyleBackColor = false;
            btn9TextBackColor.Click += btn9TextBackColor_Click;
            // 
            // btn8TextColor
            // 
            btn8TextColor.BackColor = Color.LightGray;
            btn8TextColor.FlatStyle = FlatStyle.Popup;
            btn8TextColor.Image = (Image)resources.GetObject("btn8TextColor.Image");
            btn8TextColor.Location = new Point(565, 577);
            btn8TextColor.Name = "btn8TextColor";
            btn8TextColor.Size = new Size(36, 33);
            btn8TextColor.TabIndex = 15;
            btn8TextColor.UseVisualStyleBackColor = false;
            btn8TextColor.Click += btn8TextColor_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(565, 546);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 15;
            label7.Text = "Font Color";
            // 
            // comboBox1FontSize
            // 
            comboBox1FontSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1FontSize.FormattingEnabled = true;
            comboBox1FontSize.Location = new Point(388, 577);
            comboBox1FontSize.Name = "comboBox1FontSize";
            comboBox1FontSize.Size = new Size(155, 31);
            comboBox1FontSize.TabIndex = 11;
            comboBox1FontSize.SelectedIndexChanged += comboBox1FontSize_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(388, 546);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 10;
            label6.Text = "Font Size";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 546);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 9;
            label5.Text = "Font";
            // 
            // comboBox1Font
            // 
            comboBox1Font.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1Font.FormattingEnabled = true;
            comboBox1Font.Location = new Point(174, 577);
            comboBox1Font.Name = "comboBox1Font";
            comboBox1Font.Size = new Size(193, 31);
            comboBox1Font.TabIndex = 8;
            comboBox1Font.SelectedIndexChanged += comboBox1Font_SelectedIndexChanged;
            // 
            // btn3Underline
            // 
            btn3Underline.BackColor = Color.LightGray;
            btn3Underline.FlatStyle = FlatStyle.Popup;
            btn3Underline.Image = (Image)resources.GetObject("btn3Underline.Image");
            btn3Underline.Location = new Point(113, 577);
            btn3Underline.Name = "btn3Underline";
            btn3Underline.Size = new Size(36, 33);
            btn3Underline.TabIndex = 7;
            btn3Underline.UseVisualStyleBackColor = false;
            btn3Underline.Click += btn3Underline_Click;
            // 
            // btn6Italic
            // 
            btn6Italic.BackColor = Color.LightGray;
            btn6Italic.FlatStyle = FlatStyle.Popup;
            btn6Italic.Image = (Image)resources.GetObject("btn6Italic.Image");
            btn6Italic.Location = new Point(65, 577);
            btn6Italic.Name = "btn6Italic";
            btn6Italic.Size = new Size(36, 33);
            btn6Italic.TabIndex = 6;
            btn6Italic.UseVisualStyleBackColor = false;
            btn6Italic.Click += btn6Italic_Click;
            // 
            // btn5Bold
            // 
            btn5Bold.BackColor = Color.LightGray;
            btn5Bold.FlatStyle = FlatStyle.Popup;
            btn5Bold.Image = (Image)resources.GetObject("btn5Bold.Image");
            btn5Bold.Location = new Point(17, 577);
            btn5Bold.Name = "btn5Bold";
            btn5Bold.Size = new Size(36, 33);
            btn5Bold.TabIndex = 5;
            btn5Bold.UseVisualStyleBackColor = false;
            btn5Bold.Click += btn5Bold_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 546);
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
            label1.Location = new Point(16, 10);
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
            txtBoxTitle.Size = new Size(780, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // dGR1previousNotes
            // 
            dGR1previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGR1previousNotes.BackgroundColor = Color.White;
            dGR1previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGR1previousNotes.GridColor = Color.Black;
            dGR1previousNotes.Location = new Point(896, 37);
            dGR1previousNotes.Name = "dGR1previousNotes";
            dGR1previousNotes.RowHeadersWidth = 51;
            dGR1previousNotes.Size = new Size(185, 293);
            dGR1previousNotes.TabIndex = 6;
            dGR1previousNotes.CellDoubleClick += dGR1previousNotes_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(887, 11);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 4;
            label3.Text = "My Notes";
            // 
            // btn1Load
            // 
            btn1Load.BackColor = Color.LightGray;
            btn1Load.FlatStyle = FlatStyle.Popup;
            btn1Load.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1Load.Location = new Point(896, 338);
            btn1Load.Name = "btn1Load";
            btn1Load.Size = new Size(87, 34);
            btn1Load.TabIndex = 10;
            btn1Load.Text = "Load";
            btn1Load.UseVisualStyleBackColor = false;
            btn1Load.Click += btn1Load_Click;
            // 
            // btn3NewNote
            // 
            btn3NewNote.BackColor = Color.LightGray;
            btn3NewNote.FlatStyle = FlatStyle.Popup;
            btn3NewNote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3NewNote.Location = new Point(896, 378);
            btn3NewNote.Name = "btn3NewNote";
            btn3NewNote.Size = new Size(89, 34);
            btn3NewNote.TabIndex = 12;
            btn3NewNote.Text = "New Note";
            btn3NewNote.UseVisualStyleBackColor = false;
            btn3NewNote.Click += btn3NewNote_Click;
            // 
            // btn4Save
            // 
            btn4Save.BackColor = Color.LightGray;
            btn4Save.FlatStyle = FlatStyle.Popup;
            btn4Save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4Save.Location = new Point(994, 378);
            btn4Save.Name = "btn4Save";
            btn4Save.Size = new Size(87, 34);
            btn4Save.TabIndex = 14;
            btn4Save.Text = "Save";
            btn4Save.UseVisualStyleBackColor = false;
            btn4Save.Click += btn4Save_Click;
            // 
            // btn2Delete
            // 
            btn2Delete.BackColor = Color.LightGray;
            btn2Delete.FlatStyle = FlatStyle.Popup;
            btn2Delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2Delete.Location = new Point(994, 338);
            btn2Delete.Name = "btn2Delete";
            btn2Delete.Size = new Size(87, 34);
            btn2Delete.TabIndex = 13;
            btn2Delete.Text = "Delete";
            btn2Delete.UseVisualStyleBackColor = false;
            btn2Delete.Click += btn2Delete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(887, 421);
            label9.Name = "label9";
            label9.Size = new Size(138, 23);
            label9.TabIndex = 15;
            label9.Text = "Pomodoro Timer";
            // 
            // minsLbl
            // 
            minsLbl.AutoSize = true;
            minsLbl.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minsLbl.Location = new Point(922, 444);
            minsLbl.Name = "minsLbl";
            minsLbl.Size = new Size(66, 51);
            minsLbl.TabIndex = 16;
            minsLbl.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(975, 444);
            label10.Name = "label10";
            label10.Size = new Size(32, 51);
            label10.TabIndex = 17;
            label10.Text = ":";
            // 
            // secLbl
            // 
            secLbl.AutoSize = true;
            secLbl.Font = new Font("Franklin Gothic Medium Cond", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secLbl.Location = new Point(994, 444);
            secLbl.Name = "secLbl";
            secLbl.Size = new Size(66, 51);
            secLbl.TabIndex = 18;
            secLbl.Text = "00";
            // 
            // startButton
            // 
            startButton.BackColor = Color.LightGray;
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(884, 498);
            startButton.Name = "startButton";
            startButton.Size = new Size(51, 33);
            startButton.TabIndex = 19;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // pomodoroButton
            // 
            pomodoroButton.BackColor = Color.LightGray;
            pomodoroButton.FlatStyle = FlatStyle.Popup;
            pomodoroButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pomodoroButton.Location = new Point(941, 498);
            pomodoroButton.Name = "pomodoroButton";
            pomodoroButton.Size = new Size(92, 33);
            pomodoroButton.TabIndex = 20;
            pomodoroButton.Text = "Pomodoro";
            pomodoroButton.UseVisualStyleBackColor = false;
            pomodoroButton.Click += pomodoroButton_Click;
            // 
            // stopButon
            // 
            stopButon.BackColor = Color.LightGray;
            stopButon.FlatStyle = FlatStyle.Popup;
            stopButon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopButon.Location = new Point(1039, 498);
            stopButon.Name = "stopButon";
            stopButon.Size = new Size(51, 33);
            stopButon.TabIndex = 21;
            stopButon.Text = "Stop";
            stopButon.UseVisualStyleBackColor = false;
            stopButon.Click += stopButon_Click;
            // 
            // longBreakButton
            // 
            longBreakButton.BackColor = Color.LightGray;
            longBreakButton.FlatStyle = FlatStyle.Popup;
            longBreakButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            longBreakButton.Location = new Point(884, 540);
            longBreakButton.Name = "longBreakButton";
            longBreakButton.Size = new Size(104, 33);
            longBreakButton.TabIndex = 22;
            longBreakButton.Text = "Long Break";
            longBreakButton.UseVisualStyleBackColor = false;
            longBreakButton.Click += longBreakButton_Click;
            // 
            // shortBreakButton
            // 
            shortBreakButton.BackColor = Color.LightGray;
            shortBreakButton.FlatStyle = FlatStyle.Popup;
            shortBreakButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shortBreakButton.Location = new Point(994, 540);
            shortBreakButton.Name = "shortBreakButton";
            shortBreakButton.Size = new Size(96, 33);
            shortBreakButton.TabIndex = 23;
            shortBreakButton.Text = "Short";
            shortBreakButton.UseVisualStyleBackColor = false;
            shortBreakButton.Click += shortBreakButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(896, 576);
            label11.Name = "label11";
            label11.Size = new Size(188, 51);
            label11.TabIndex = 24;
            label11.Text = "Pomodoro Timer = 25 minutes\r\nLong Break = 15 minutes\r\nShort Break = 5 minutes";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer2Pomodoro
            // 
            timer2Pomodoro.Interval = 1000;
            timer2Pomodoro.Tick += timer2Pomodoro_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 636);
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
            Controls.Add(fLP1Sidebar);
            Controls.Add(panel7);
            Controls.Add(longBreakButton);
            Controls.Add(startButton);
            Controls.Add(label9);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Write Notes";
            Load += Form2_Load;
            fLP1Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGR1previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel fLP1Sidebar;
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
        private Label labl1BeSMART;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1SidebarTransition;
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
        private Panel panel1;
        private Label label9;
        private Label minsLbl;
        private Label label10;
        private Label secLbl;
        private Button startButton;
        private Button pomodoroButton;
        private Button stopButon;
        private Button longBreakButton;
        private Button shortBreakButton;
        private Label label11;
        private System.Windows.Forms.Timer timer2Pomodoro;
    }
}