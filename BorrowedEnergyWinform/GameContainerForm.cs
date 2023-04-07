namespace BorrowedEnergyWinform
{
    public partial class GameContainerForm : Form
    {
        Game? game;
        TitleScreenForm titleScreen;
        SeasonStatusForm seasonStatus;
        List<Form> forms = new List<Form>();
        
        public GameContainerForm()
        {
            InitializeComponent();
            
            titleScreen = new TitleScreenForm(this);
            forms.Add(titleScreen);

            seasonStatus = new SeasonStatusForm(this);
            forms.Add(seasonStatus);

            foreach(Form form in forms)
            {
                form.MdiParent = this;
            }

            titleScreen.Show();
        }

        public void InitGame(int playerEnergy)
        {
            this.game = new Game(playerEnergy);
        }

        public void ShowSeasonStatus()
        {
            foreach(Form form in forms)
            {
                form.Hide();
            }
            seasonStatus.Show(game.RunnerPoints());
        }

    }
}