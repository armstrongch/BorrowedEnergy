namespace BorrowedEnergyWinform
{
    partial class GameForm
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
            this.chooseDifficultyPanel = new System.Windows.Forms.Panel();
            this.selectDifficultyStartButton = new System.Windows.Forms.Button();
            this.difficultyInputTextBox = new System.Windows.Forms.TextBox();
            this.chooseDifficultyLabel = new System.Windows.Forms.Label();
            this.chooseDifficultyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseDifficultyPanel
            // 
            this.chooseDifficultyPanel.Controls.Add(this.selectDifficultyStartButton);
            this.chooseDifficultyPanel.Controls.Add(this.difficultyInputTextBox);
            this.chooseDifficultyPanel.Controls.Add(this.chooseDifficultyLabel);
            this.chooseDifficultyPanel.Location = new System.Drawing.Point(138, 62);
            this.chooseDifficultyPanel.Name = "chooseDifficultyPanel";
            this.chooseDifficultyPanel.Size = new System.Drawing.Size(520, 279);
            this.chooseDifficultyPanel.TabIndex = 0;
            // 
            // selectDifficultyStartButton
            // 
            this.selectDifficultyStartButton.Location = new System.Drawing.Point(72, 113);
            this.selectDifficultyStartButton.Name = "selectDifficultyStartButton";
            this.selectDifficultyStartButton.Size = new System.Drawing.Size(144, 23);
            this.selectDifficultyStartButton.TabIndex = 2;
            this.selectDifficultyStartButton.Text = "start game";
            this.selectDifficultyStartButton.UseVisualStyleBackColor = true;
            this.selectDifficultyStartButton.Click += new System.EventHandler(this.selectDifficultyStartButton_Click);
            // 
            // difficultyInputTextBox
            // 
            this.difficultyInputTextBox.Location = new System.Drawing.Point(66, 72);
            this.difficultyInputTextBox.Name = "difficultyInputTextBox";
            this.difficultyInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.difficultyInputTextBox.TabIndex = 1;
            // 
            // chooseDifficultyLabel
            // 
            this.chooseDifficultyLabel.AutoSize = true;
            this.chooseDifficultyLabel.Location = new System.Drawing.Point(60, 39);
            this.chooseDifficultyLabel.Name = "chooseDifficultyLabel";
            this.chooseDifficultyLabel.Size = new System.Drawing.Size(162, 15);
            this.chooseDifficultyLabel.TabIndex = 0;
            this.chooseDifficultyLabel.Text = "choose your difficulty (1-100)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseDifficultyPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.chooseDifficultyPanel.ResumeLayout(false);
            this.chooseDifficultyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel chooseDifficultyPanel;
        private Button selectDifficultyStartButton;
        private TextBox difficultyInputTextBox;
        private Label chooseDifficultyLabel;
    }
}