namespace BorrowedEnergyWinform
{
    partial class SeasonStatusForm
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
            this.seasonStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seasonStatusLabel
            // 
            this.seasonStatusLabel.AutoSize = true;
            this.seasonStatusLabel.Location = new System.Drawing.Point(56, 41);
            this.seasonStatusLabel.Name = "seasonStatusLabel";
            this.seasonStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.seasonStatusLabel.TabIndex = 0;
            // 
            // SeasonStatusForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.seasonStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeasonStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TitleScreenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label seasonStatusLabel;
    }
}