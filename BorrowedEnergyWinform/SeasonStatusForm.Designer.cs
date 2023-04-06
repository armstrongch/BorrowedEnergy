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
            this.seasonStandingsDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.seasonStandingsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seasonStandingsDatagrid
            // 
            this.seasonStandingsDatagrid.AllowUserToAddRows = false;
            this.seasonStandingsDatagrid.AllowUserToDeleteRows = false;
            this.seasonStandingsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonStandingsDatagrid.Location = new System.Drawing.Point(68, 64);
            this.seasonStandingsDatagrid.Name = "seasonStandingsDatagrid";
            this.seasonStandingsDatagrid.ReadOnly = true;
            this.seasonStandingsDatagrid.RowTemplate.Height = 25;
            this.seasonStandingsDatagrid.Size = new System.Drawing.Size(696, 312);
            this.seasonStandingsDatagrid.TabIndex = 1;
            // 
            // SeasonStatusForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.seasonStandingsDatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeasonStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TitleScreenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.seasonStandingsDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView seasonStandingsDatagrid;
    }
}