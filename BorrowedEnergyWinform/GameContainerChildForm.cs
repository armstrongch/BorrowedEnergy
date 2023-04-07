using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowedEnergyWinform
{
    public partial class GameContainerChildForm : Form
    {
        public void Show()
        {
            base.Show();
            this.WindowState = FormWindowState.Maximized;
            this.Location = new System.Drawing.Point(0, 0);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameContainerChildForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "GameContainerChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }
    }
}
