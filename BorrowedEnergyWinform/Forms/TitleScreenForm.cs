using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowedEnergyWinform
{
    public partial class TitleScreenForm : GameContainerChildForm
    {

        GameContainerForm parentForm;

        public TitleScreenForm(GameContainerForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void submitPlayerEnergyButton_Click(object sender, EventArgs e)
        {
            parentForm.InitGame(int.Parse(playerEnergyTextBox.Text));
            parentForm.ShowSeasonStatus();
        }
    }
}
