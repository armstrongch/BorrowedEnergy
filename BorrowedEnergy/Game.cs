using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowedEnergy
{
    internal partial class Game
    {
        public List<Runner> Runners { get; private set; }
        private static Random rng = new Random();

        public Game(int player_energy)
        {
            Runners = new List<Runner>();
            
            if ((player_energy < 1) || (player_energy > 100))
            {
                throw new Exception($"Player energy must be between 1 and 100.");
            }
            
            //Shufle list of names
            names = names.OrderBy(n => rng.Next()).ToList();
            
            for (int i = 1; i <= 100; i += 1)
            {
                bool human_player = i == player_energy;
                string runner_name = human_player ? "PLAYER" : names[i-1];
                Runners.Add(new Runner(runner_name, human_player, i));
            }
        }
    }
}
