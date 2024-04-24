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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            previousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            NewButton = new Button();
            ConverterButton = new Button();
            TimerButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ToDoListButton = new Button();
            MP3Button = new Button();
            MP4Button = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.BackColor = Color.White;
            TitleBox.BorderStyle = BorderStyle.None;
            TitleBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleBox.ForeColor = Color.FromArgb(114, 137, 218);
            TitleBox.Location = new Point(196, 12);
            TitleBox.Name = "TitleBox";
            TitleBox.PlaceholderText = "Note Title";
            TitleBox.Size = new Size(592, 22);
            TitleBox.TabIndex = 0;
            // 
            // NoteBox
            // 
            NoteBox.BackColor = Color.White;
            NoteBox.BorderStyle = BorderStyle.None;
            NoteBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteBox.ForeColor = Color.FromArgb(54, 57, 62);
            NoteBox.Location = new Point(196, 40);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.PlaceholderText = "Write a note";
            NoteBox.ScrollBars = ScrollBars.Vertical;
            NoteBox.Size = new Size(592, 641);
            NoteBox.TabIndex = 1;
            // 
            // previousNotes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            previousNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            previousNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            previousNotes.DefaultCellStyle = dataGridViewCellStyle3;
            previousNotes.GridColor = Color.FromArgb(54, 57, 62);
            previousNotes.Location = new Point(15, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            previousNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            previousNotes.RowHeadersVisible = false;
            previousNotes.Size = new Size(175, 405);
            previousNotes.TabIndex = 2;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.BackColor = Color.FromArgb(54, 57, 62);
            LoadButton.FlatStyle = FlatStyle.Flat;
            LoadButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.ForeColor = Color.White;
            LoadButton.Location = new Point(15, 423);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(86, 31);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = false;
            LoadButton.Click += LoadButton_Click;
            LoadButton.MouseLeave += LoadButton_MouseLeave;
            LoadButton.MouseHover += LoadButton_MouseHover;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(54, 57, 62);
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(15, 460);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(86, 31);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            DeleteButton.MouseLeave += DeleteButton_MouseLeave;
            DeleteButton.MouseHover += DeleteButton_MouseHover;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(54, 57, 62);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(104, 460);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 31);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            SaveButton.MouseLeave += SaveButton_MouseLeave;
            SaveButton.MouseHover += SaveButton_MouseHover;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.FromArgb(54, 57, 62);
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewButton.ForeColor = Color.White;
            NewButton.Location = new Point(104, 423);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(86, 31);
            NewButton.TabIndex = 6;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            NewButton.MouseLeave += NewButton_MouseLeave;
            NewButton.MouseHover += NewButton_MouseHover;
            // 
            // ConverterButton
            // 
            ConverterButton.BackColor = Color.FromArgb(54, 57, 62);
            ConverterButton.FlatStyle = FlatStyle.Flat;
            ConverterButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConverterButton.ForeColor = Color.White;
            ConverterButton.Location = new Point(15, 497);
            ConverterButton.Name = "ConverterButton";
            ConverterButton.Size = new Size(175, 32);
            ConverterButton.TabIndex = 7;
            ConverterButton.Text = "Converter";
            ConverterButton.UseVisualStyleBackColor = false;
            ConverterButton.Click += ConverterButton_Click;
            ConverterButton.MouseLeave += ConverterButton_OnMouseLeave;
            ConverterButton.MouseHover += ConverterButton_MouseHover;
            // 
            // TimerButton
            // 
            TimerButton.BackColor = Color.FromArgb(54, 57, 62);
            TimerButton.FlatStyle = FlatStyle.Flat;
            TimerButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerButton.ForeColor = Color.White;
            TimerButton.Location = new Point(15, 535);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(175, 32);
            TimerButton.TabIndex = 8;
            TimerButton.Text = "Timer";
            TimerButton.UseVisualStyleBackColor = false;
            TimerButton.Click += TimerButton_Click;
            TimerButton.MouseLeave += TimerButton_MouseLeave;
            TimerButton.MouseHover += TimerButton_MouseHover;
            // 
            // ToDoListButton
            // 
            ToDoListButton.BackColor = Color.FromArgb(54, 57, 62);
            ToDoListButton.FlatStyle = FlatStyle.Flat;
            ToDoListButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToDoListButton.ForeColor = Color.White;
            ToDoListButton.Location = new Point(15, 573);
            ToDoListButton.Name = "ToDoListButton";
            ToDoListButton.Size = new Size(175, 32);
            ToDoListButton.TabIndex = 9;
            ToDoListButton.Text = "To Do List";
            ToDoListButton.UseVisualStyleBackColor = false;
            ToDoListButton.Click += ToDoListButton_Click;
            ToDoListButton.MouseLeave += ToDoListButton_MouseLeave;
            ToDoListButton.MouseHover += ToDoListButton_MouseHover;
            // 
            // MP3Button
            // 
            MP3Button.BackColor = Color.FromArgb(54, 57, 62);
            MP3Button.FlatStyle = FlatStyle.Flat;
            MP3Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MP3Button.ForeColor = Color.White;
            MP3Button.Location = new Point(15, 611);
            MP3Button.Name = "MP3Button";
            MP3Button.Size = new Size(175, 32);
            MP3Button.TabIndex = 11;
            MP3Button.Text = "Music Player";
            MP3Button.UseVisualStyleBackColor = false;
            MP3Button.Click += MP3Button_Click;
            // 
            // MP4Button
            // 
            MP4Button.BackColor = Color.FromArgb(54, 57, 62);
            MP4Button.FlatStyle = FlatStyle.Flat;
            MP4Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MP4Button.ForeColor = Color.White;
            MP4Button.Location = new Point(15, 649);
            MP4Button.Name = "MP4Button";
            MP4Button.Size = new Size(175, 32);
            MP4Button.TabIndex = 12;
            MP4Button.Text = "Video Player";
            MP4Button.UseVisualStyleBackColor = false;
            // 
            // NotesApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(800, 692);
            Controls.Add(MP4Button);
            Controls.Add(MP3Button);
            Controls.Add(ToDoListButton);
            Controls.Add(TimerButton);
            Controls.Add(ConverterButton);
            Controls.Add(NewButton);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(previousNotes);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NotesApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotesApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private DataGridView previousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button SaveButton;
        private Button NewButton;
        private Button ConverterButton;
        private Button TimerButton;
        private SaveFileDialog saveFileDialog1;
        private Button ToDoListButton;
        private Button MP3Button;
        private Button MP4Button;
    }
}
