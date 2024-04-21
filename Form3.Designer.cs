namespace NotesApp
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TitleTxtBox = new TextBox();
            DescTxtBox = new TextBox();
            NewButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleTxtBox.ForeColor = Color.FromArgb(54, 57, 62);
            TitleTxtBox.Location = new Point(12, 12);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.PlaceholderText = "Title";
            TitleTxtBox.Size = new Size(158, 29);
            TitleTxtBox.TabIndex = 0;
            // 
            // DescTxtBox
            // 
            DescTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescTxtBox.ForeColor = Color.FromArgb(54, 57, 62);
            DescTxtBox.Location = new Point(12, 47);
            DescTxtBox.Multiline = true;
            DescTxtBox.Name = "DescTxtBox";
            DescTxtBox.PlaceholderText = "Description";
            DescTxtBox.Size = new Size(159, 185);
            DescTxtBox.TabIndex = 1;
            // 
            // NewButton
            // 
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewButton.ForeColor = Color.White;
            NewButton.Location = new Point(12, 246);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(76, 34);
            NewButton.TabIndex = 4;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            NewButton.MouseLeave += NewButton_MouseLeave;
            NewButton.MouseHover += NewButton_MouseHover;
            // 
            // EditButton
            // 
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(12, 297);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(76, 34);
            EditButton.TabIndex = 5;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            EditButton.MouseLeave += EditButton_MouseLeave;
            EditButton.MouseHover += EditButton_MouseHover;
            // 
            // DeleteButton
            // 
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(12, 350);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(76, 34);
            DeleteButton.TabIndex = 6;
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
            SaveButton.Location = new Point(12, 404);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(76, 34);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            SaveButton.MouseLeave += SaveButton_MouseLeave;
            SaveButton.MouseHover += SaveButton_MouseHover;
            // 
            // ToDoListView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            ToDoListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ToDoListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(114, 137, 218);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ToDoListView.DefaultCellStyle = dataGridViewCellStyle3;
            ToDoListView.GridColor = Color.FromArgb(66, 69, 73);
            ToDoListView.Location = new Point(177, 12);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersVisible = false;
            ToDoListView.Size = new Size(459, 426);
            ToDoListView.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(648, 447);
            Controls.Add(ToDoListView);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(NewButton);
            Controls.Add(DescTxtBox);
            Controls.Add(TitleTxtBox);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleTxtBox;
        private TextBox DescTxtBox;
        private Button NewButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button SaveButton;
        private DataGridView ToDoListView;
    }
}