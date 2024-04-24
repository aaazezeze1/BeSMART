namespace NotesApp
{
    partial class Form5
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
            timer1 = new System.Windows.Forms.Timer(components);
            PlayButton = new Button();
            StopButton = new Button();
            FSearchButton = new Button();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayButton.ForeColor = Color.White;
            PlayButton.Location = new Point(54, 286);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(110, 46);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // StopButton
            // 
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopButton.ForeColor = Color.White;
            StopButton.Location = new Point(185, 286);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(75, 46);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // FSearchButton
            // 
            FSearchButton.FlatStyle = FlatStyle.Flat;
            FSearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FSearchButton.ForeColor = Color.White;
            FSearchButton.Location = new Point(281, 286);
            FSearchButton.Name = "FSearchButton";
            FSearchButton.Size = new Size(116, 46);
            FSearchButton.TabIndex = 2;
            FSearchButton.Text = "Load Folder";
            FSearchButton.UseVisualStyleBackColor = true;
            FSearchButton.Click += FSearchButton_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(744, 372);
            Controls.Add(FSearchButton);
            Controls.Add(StopButton);
            Controls.Add(PlayButton);
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MP3 Player";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button PlayButton;
        private Button StopButton;
        private Button FSearchButton;
    }
}