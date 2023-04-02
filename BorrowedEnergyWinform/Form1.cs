namespace BorrowedEnergyWinform
{
    public partial class GameForm : Form
    {
        Game game;
        
        public GameForm()
        {
            InitializeComponent();
        }

        private void selectDifficultyStartButton_Click(object sender, EventArgs e)
        {
            int player_energy = int.Parse(difficultyInputTextBox.Text);
            game = new Game(player_energy);
        }
    }
}