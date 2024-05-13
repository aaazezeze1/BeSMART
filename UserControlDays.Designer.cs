namespace NotesApp
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDays = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDays.Location = new Point(0, 0);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(28, 23);
            lblDays.TabIndex = 0;
            lblDays.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDays);
            Name = "UserControlDays";
            Size = new Size(90, 66);
            DoubleClick += UserControlDays_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
    }
}
