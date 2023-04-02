using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowedEnergyWinform
{
    public sealed class Calculations
    {
        private static Calculations? instance;
        public static Calculations Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculations();
                }
                return instance;
            }
        }

        private Calculations()
        {
            int distance = 1;
            int energy = 1;

            while (energy < 100)
            {
                DistancePerEnergy.Add(distance, energy);
                distance += 1;
                energy = (int)Math.Ceiling(Math.Pow(distance, 1.5));
            }
        }

        public Dictionary<int, int> DistancePerEnergy { get; private set; } = new Dictionary<int, int>() { { 0, 0 } };
        public Random rng { get; private set; } = new Random();
    }
}
