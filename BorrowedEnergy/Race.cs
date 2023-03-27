using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowedEnergy
{
    internal class Race
    {
        public Dictionary<string, int> race_runner_positions { get; private set; }
        public Dictionary<int, string> race_finishers { get; private set; } = new Dictionary<int, string>();
        public int race_distance { get; private set; }

        public Race(List<string> runner_names)
        {
            race_runner_positions = new Dictionary<string, int>();
            foreach(string runner_name in runner_names)
            {
                race_runner_positions.Add(runner_name, 0);
            }

            race_distance = 30 + new Random().Next(71);
        }

        public RunnerRaceStatus GetRaceInfo(Runner runner, bool get_related_runners)
        {
            return this.GetRaceInfo(runner.name, get_related_runners);
        }
        public RunnerRaceStatus GetRaceInfo(string runner_name, bool get_related_runners)
        {
            int current_position = race_runner_positions[runner_name];
            int current_place = race_runner_positions.Values.Where(p => p > current_position).Count() + 1;
            int distance_remaining = race_distance - current_position;
            int num_runners_finished = race_finishers.Count;

            List<string> runners_tied_with = race_runner_positions.Where(x => x.Value == current_position).Select(x => x.Key).ToList();
            List<string> related_runners = new List<string>();
            
            List<int> positions_ahead = race_runner_positions.Values
                .Where(x => x > current_position && x < race_distance).ToList();
            
            List<int> positions_behind = race_runner_positions.Values
                .Where(x => x < current_position).ToList();

            if (positions_ahead.Count > 0)
            {
                List<string> leaders = race_runner_positions
                    .Where(x => x.Value == positions_ahead.Max())
                    .Select(x => x.Key).ToList();
               
                List<string> immediately_ahead = race_runner_positions
                    .Where(x => x.Value == positions_ahead.Min())
                    .Where(x => !leaders.Contains(x.Key))
                    .Select(x => x.Key).ToList();
                
                related_runners.AddRange(leaders);
                related_runners.AddRange(immediately_ahead);
            }
            if (positions_behind.Count > 0)
            {
                List<string> immediately_behind = race_runner_positions
                    .Where(x => x.Value == positions_behind.Max())
                    .Select(x => x.Key).ToList();
                
                related_runners.AddRange(immediately_behind);
            }

            return new RunnerRaceStatus(current_place, distance_remaining, num_runners_finished, runners_tied_with, related_runners);
        }
    }

    internal class RunnerRaceStatus
    {
        public static int current_place;
        public static int distance_remaining;
        public static int num_runners_finished;
        public static List<string> runners_tied_with;
        public static List<string> related_runners;

        public RunnerRaceStatus (
            int in_current_place, int in_distance_remaining, int in_num_runners_finished,
            List<string> in_runners_tied_with, List<string> in_related_runners)
        {
            current_place = in_current_place;
            distance_remaining = in_distance_remaining;
            num_runners_finished = in_num_runners_finished;
            runners_tied_with = in_runners_tied_with;
            related_runners = in_related_runners;
        }
    }
}
