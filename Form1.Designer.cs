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
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            previousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            NewButton = new Button();
            ConverterButton = new Button();
            TimerButton = new Button();
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
            NoteBox.BackColor = Color.FromArgb(66, 69, 73);
            NoteBox.BorderStyle = BorderStyle.None;
            NoteBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteBox.ForeColor = Color.White;
            NoteBox.Location = new Point(196, 40);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(592, 529);
            NoteBox.TabIndex = 1;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.FromArgb(66, 69, 73);
            previousNotes.BorderStyle = BorderStyle.None;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(15, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            previousNotes.RowHeadersVisible = false;
            previousNotes.Size = new Size(175, 405);
            previousNotes.TabIndex = 2;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.FlatStyle = FlatStyle.Flat;
            LoadButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.ForeColor = Color.White;
            LoadButton.Location = new Point(15, 423);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(86, 31);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            LoadButton.MouseLeave += LoadButton_MouseLeave;
            LoadButton.MouseHover += LoadButton_MouseHover;
            // 
            // DeleteButton
            // 
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(15, 460);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(86, 31);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            DeleteButton.MouseLeave += DeleteButton_MouseLeave;
            DeleteButton.MouseHover += DeleteButton_MouseHover;
            // 
            // SaveButton
            // 
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(104, 460);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(86, 31);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            SaveButton.MouseLeave += SaveButton_MouseLeave;
            SaveButton.MouseHover += SaveButton_MouseHover;
            // 
            // NewButton
            // 
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewButton.ForeColor = Color.White;
            NewButton.Location = new Point(104, 423);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(86, 31);
            NewButton.TabIndex = 6;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            NewButton.MouseLeave += NewButton_MouseLeave;
            NewButton.MouseHover += NewButton_MouseHover;
            // 
            // ConverterButton
            // 
            ConverterButton.FlatStyle = FlatStyle.Flat;
            ConverterButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConverterButton.ForeColor = Color.White;
            ConverterButton.Location = new Point(15, 497);
            ConverterButton.Name = "ConverterButton";
            ConverterButton.Size = new Size(175, 32);
            ConverterButton.TabIndex = 7;
            ConverterButton.Text = "Converter";
            ConverterButton.UseVisualStyleBackColor = true;
            ConverterButton.Click += ConverterButton_Click;
            ConverterButton.MouseLeave += ConverterButton_OnMouseLeave;
            ConverterButton.MouseHover += ConverterButton_MouseHover;
            // 
            // TimerButton
            // 
            TimerButton.FlatStyle = FlatStyle.Flat;
            TimerButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerButton.ForeColor = Color.White;
            TimerButton.Location = new Point(15, 535);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(175, 32);
            TimerButton.TabIndex = 8;
            TimerButton.Text = "Timer";
            TimerButton.UseVisualStyleBackColor = true;
            TimerButton.MouseLeave += TimerButton_MouseLeave;
            TimerButton.MouseHover += TimerButton_MouseHover;
            // 
            // NotesApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(800, 581);
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
    }
}
