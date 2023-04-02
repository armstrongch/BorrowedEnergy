using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowedEnergyWinform
{
    internal class Runner
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public string name { get; private set; }
        private bool human_player;

        public int seed_num { get; init; }
        public int max_energy { get; private set; }
        public int current_energy { get; private set; }
        
        /// <summary>
        /// Energy gained at the start of every day.
        /// </summary>
        public int daily_energy_recharge { get; private set; } = 10;
        
        /// <summary>
        /// Bonus distance every turn.
        /// </summary>
        public int bonus_distance { get; private set; } = 5;

        /// <summary>
        /// Bonus distance on the first turn of every race.
        /// </summary>
        public int bonus_start_distance { get; private set; } = 0;

        /// <summary>
        /// Bonus distance after crossing the finish line.
        /// </summary>
        public int bonus_finish_distance { get; private set; } = 0;

        public Runner(string name, bool human_player, int energy)
        {
            this.name = name;
            this.human_player = human_player;
            this.max_energy = energy;
            this.current_energy = energy;
            seed_num = energy;
        }

        public void StartDay()
        {
            current_energy = Math.Min(current_energy + daily_energy_recharge, max_energy);
        }

        public int ChooseDistance(RunnerRaceStatus race_status)
        {
            int max_selectable_distance = Calculations.Instance.DistancePerEnergy.Where(x => x.Value <= current_energy).Select(x => x.Key).Max();

            int selected_distance = Calculations.Instance.rng.Next(max_selectable_distance + 1);

            int total_distance = selected_distance + bonus_distance;
            if (race_status.current_position == 0)
            {
                total_distance += bonus_start_distance;
            }
            if (total_distance >= race_status.distance_remaining)
            {
                total_distance += bonus_finish_distance;
            }

            return total_distance;
        }
    }
}
