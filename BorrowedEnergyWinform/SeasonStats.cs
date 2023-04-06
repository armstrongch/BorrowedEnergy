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

        /// <summary>
        /// Calculates points for each runner, by adding the sum of all individual races scores.
        /// A runner scores X points per race, where X = number of runners - finish position.
        /// For instance, in a race with 10 runners, 1st place is worth 9 points and 10th place is worth 0 points.
        /// </summary>
        /// <returns>Dictionary of runners and their point totals.</returns>
        public Dictionary<Runner, int> RunnerPoints()
        {
            Dictionary<Runner, int> runner_points = new Dictionary<Runner, int>();

            List<Race> completedRaces = Races.Where(r => r.finished).ToList();
            
            foreach (Runner runner in Runners)
            {
                int points = 0;
                foreach (Race race in completedRaces)
                {
                    if (race.race_finishers.Values.Contains(runner.name))
                    {
                        int finish_position = race.race_finishers.Where(f => f.Value == runner.name).Select(f => f.Key).First();
                        points += (race.race_finishers.Count - finish_position);
                    }
                }
                runner_points.Add(runner, points);
            }
            return runner_points;
        }
    }

}
