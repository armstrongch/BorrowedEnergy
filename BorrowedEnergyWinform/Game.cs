using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorrowedEnergyWinform;

namespace BorrowedEnergyWinform
{
    internal partial class Game
    {
        private static Random rng = new Random();
        
        public List<Runner> Runners { get; private set; }
        public List<Race> Races { get; private set; } = new List<Race>();
        

        public Game(int player_energy)
        {
            Runners = new List<Runner>();
            
            if ((player_energy < 1) || (player_energy > 100))
            {
                throw new Exception($"Player energy must be between 1 and 100.");
            }
            
            //Shufle list of names
            names.OrderBy(n => rng.Next()).ToList();
            
            for (int i = 1; i <= 100; i += 1)
            {
                bool human_player = i == player_energy;
                string runner_name = human_player ? "PLAYER" : names[i-1];
                Runners.Add(new Runner(runner_name, human_player, i));
            }
        }

        public void RunRace()
        {
            foreach (Race race in Races.Where(r => !r.finished))
            {
                RunRace(race);
            }
        }

        public void RunRace(Race race)
        {
            Dictionary<Runner,RunnerRaceStatus> runner_race_statuses = new Dictionary<Runner, RunnerRaceStatus>();
            
            while (!race.finished)
            {
                runner_race_statuses.Clear();
                foreach(Runner runner in Runners
                    .Where(r => race.race_runner_positions.Keys.Contains(r.name))
                    .Where(r => !race.race_finishers.Values.Contains(r.name)))
                {
                    runner_race_statuses.Add(runner, race.GetRaceInfo(runner, true));
                }
            }

            foreach (Runner runner in runner_race_statuses.Keys.OrderBy(r => r.current_energy))
            {
                int distance = runner.ChooseDistance(runner_race_statuses[runner]);
                race.MoveRunner(runner, distance);
            }

            race.UpdateFinishers();

            throw new NotImplementedException();
        }

        public void DivideRunnersIntoRaces()
        {
            // Order runners by seed, with a 5-point random swing in both directions.
            // A runner seeded 50th might be evaluated at 45 or 55.
            Runners.OrderBy(r => r.seed_num + 5 - rng.Next(10)).ToList();
            List<List<string>> runner_name_groups = new List<List<string>>();
            // Divide the ordered runners into 10 groups of 10
            for (int i = 0; i < 10; i += 1)
            {
                List<string> group = Runners.GetRange(i * 10, 10).Select(r => r.name).ToList();
                group.OrderBy(n => rng.Next()).ToList();
                runner_name_groups.Add(group);
            }
            
            // Create 10 races, each containing 1 runner from each group.
            // This way, each race contains 1 of the 10 fastest runners, 1 of the 11th-20th fastest runners, etc.
            for (int i = 0; i < 10; i += 1)
            {
                List<string> race_runners = new List<string>();
                foreach (List<string> group in runner_name_groups)
                {
                    race_runners.Add(group[i]);
                }
                Races.Add(new Race(race_runners));
            }
        }
    }

}
