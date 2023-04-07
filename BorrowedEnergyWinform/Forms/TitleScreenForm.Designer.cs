namespace BorrowedEnergyWinform
{
    partial class TitleScreenForm
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
            this.playerEnergyTextBox = new System.Windows.Forms.TextBox();
            this.submitPlayerEnergyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerEnergyTextBox
            // 
            this.playerEnergyTextBox.Location = new System.Drawing.Point(218, 104);
            this.playerEnergyTextBox.Name = "playerEnergyTextBox";
            this.playerEnergyTextBox.Size = new System.Drawing.Size(100, 23);
            this.playerEnergyTextBox.TabIndex = 0;
            // 
            // submitPlayerEnergyButton
            // 
            this.submitPlayerEnergyButton.Location = new System.Drawing.Point(227, 156);
            this.submitPlayerEnergyButton.Name = "submitPlayerEnergyButton";
            this.submitPlayerEnergyButton.Size = new System.Drawing.Size(75, 23);
            this.submitPlayerEnergyButton.TabIndex = 1;
            this.submitPlayerEnergyButton.Text = "Submit";
            this.submitPlayerEnergyButton.UseVisualStyleBackColor = true;
            this.submitPlayerEnergyButton.Click += new System.EventHandler(this.submitPlayerEnergyButton_Click);
            // 
            // TitleScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.submitPlayerEnergyButton);
            this.Controls.Add(this.playerEnergyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TitleScreenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox playerEnergyTextBox;
        private Button submitPlayerEnergyButton;
    }
}