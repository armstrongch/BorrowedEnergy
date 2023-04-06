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
    public partial class SeasonStatusForm : Form
    {

        GameContainerForm parentForm;

        public SeasonStatusForm(GameContainerForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public void Show(Dictionary<Runner, int> runnerPoints)
        {
            DataTable seasonStandingData = new DataTable();
            seasonStandingData.Columns.Add("Runner");
            seasonStandingData.Columns.Add("Pre-Season Seed");
            seasonStandingData.Columns.Add("Current Point Total");

            foreach (var rp in runnerPoints)
            {
                DataRow row = seasonStandingData.Rows.Add();
                row[0] = rp.Key.name;
                row[1] = rp.Key.seed_num;
                row[2] = rp.Value;
            }

            seasonStandingsDatagrid.DataSource = seasonStandingData;
            
            base.Show();
        }
    }
}
