namespace NotesApp
{
    partial class Form4
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
            ShortBButton = new Button();
            LongBButton = new Button();
            StopButton = new Button();
            minsLbl = new Label();
            PomodoroButton = new Button();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            secLbl = new Label();
            label1 = new Label();
            StartButton = new Button();
            SuspendLayout();
            // 
            // ShortBButton
            // 
            ShortBButton.FlatStyle = FlatStyle.Flat;
            ShortBButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShortBButton.ForeColor = Color.White;
            ShortBButton.Location = new Point(221, 216);
            ShortBButton.Name = "ShortBButton";
            ShortBButton.Size = new Size(146, 41);
            ShortBButton.TabIndex = 2;
            ShortBButton.Text = "Short Break";
            ShortBButton.UseVisualStyleBackColor = true;
            ShortBButton.Click += ShortBButton_Click;
            ShortBButton.MouseLeave += ShortBButton_MouseLeave;
            ShortBButton.MouseHover += ShortBButton_MouseHover;
            // 
            // LongBButton
            // 
            LongBButton.FlatStyle = FlatStyle.Flat;
            LongBButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LongBButton.ForeColor = Color.White;
            LongBButton.Location = new Point(72, 216);
            LongBButton.Name = "LongBButton";
            LongBButton.Size = new Size(143, 41);
            LongBButton.TabIndex = 3;
            LongBButton.Text = "Long Break";
            LongBButton.UseVisualStyleBackColor = true;
            LongBButton.Click += LongBButton_Click;
            LongBButton.MouseLeave += LongBButton_MouseLeave;
            LongBButton.MouseHover += LongBButton_MouseHover;
            // 
            // StopButton
            // 
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StopButton.ForeColor = Color.White;
            StopButton.Location = new Point(286, 158);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(81, 41);
            StopButton.TabIndex = 4;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            StopButton.MouseLeave += StopButton_MouseLeave;
            StopButton.MouseHover += StopButton_MouseHover;
            // 
            // minsLbl
            // 
            minsLbl.AutoSize = true;
            minsLbl.Font = new Font("Franklin Gothic Medium Cond", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minsLbl.ForeColor = Color.FromArgb(114, 137, 218);
            minsLbl.Location = new Point(53, 26);
            minsLbl.Name = "minsLbl";
            minsLbl.Size = new Size(148, 120);
            minsLbl.TabIndex = 5;
            minsLbl.Text = "00";
            // 
            // PomodoroButton
            // 
            PomodoroButton.FlatStyle = FlatStyle.Flat;
            PomodoroButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PomodoroButton.ForeColor = Color.White;
            PomodoroButton.Location = new Point(159, 158);
            PomodoroButton.Name = "PomodoroButton";
            PomodoroButton.Size = new Size(121, 41);
            PomodoroButton.TabIndex = 6;
            PomodoroButton.Text = "Pomodoro";
            PomodoroButton.UseVisualStyleBackColor = true;
            PomodoroButton.Click += PomodoroButton_Click;
            PomodoroButton.MouseLeave += PomodoroButton_MouseLeave;
            PomodoroButton.MouseHover += PomodoroButton_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(54, 57, 62);
            label2.ForeColor = Color.FromArgb(114, 137, 218);
            label2.Location = new Point(53, 278);
            label2.Name = "label2";
            label2.Size = new Size(330, 63);
            label2.TabIndex = 7;
            label2.Text = "* 25 Minutes sets the timer to Pomodoro Time\r\nShort Break sets the timer to 5 minutes\r\nLong Break sets the timer to 15 minutes\r\n";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // secLbl
            // 
            secLbl.AutoSize = true;
            secLbl.Font = new Font("Franklin Gothic Medium Cond", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secLbl.ForeColor = Color.FromArgb(114, 137, 218);
            secLbl.Location = new Point(235, 26);
            secLbl.Name = "secLbl";
            secLbl.Size = new Size(148, 120);
            secLbl.TabIndex = 8;
            secLbl.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(114, 137, 218);
            label1.Location = new Point(185, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 120);
            label1.TabIndex = 9;
            label1.Text = ":";
            // 
            // StartButton
            // 
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.ForeColor = Color.White;
            StartButton.Location = new Point(72, 158);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(81, 41);
            StartButton.TabIndex = 10;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            StartButton.MouseLeave += StartButton_MouseLeave;
            StartButton.MouseHover += StartButton_MouseHover;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(455, 359);
            Controls.Add(StartButton);
            Controls.Add(label1);
            Controls.Add(secLbl);
            Controls.Add(label2);
            Controls.Add(PomodoroButton);
            Controls.Add(minsLbl);
            Controls.Add(StopButton);
            Controls.Add(LongBButton);
            Controls.Add(ShortBButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button ShortBButton;
        private Button LongBButton;
        private Button StopButton;
        private Label minsLbl;
        private Button PomodoroButton;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label secLbl;
        private Label label1;
    }
}