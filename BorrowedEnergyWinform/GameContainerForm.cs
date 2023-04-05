namespace BorrowedEnergyWinform
{
    public partial class GameForm : Form
    {
        Game game;
        
        public GameForm()
        {
            InitializeComponent();
            TitleScreenForm titleScreen = new TitleScreenForm();
            titleScreen.MdiParent = this;
            titleScreen.Show();
        }

    }
}