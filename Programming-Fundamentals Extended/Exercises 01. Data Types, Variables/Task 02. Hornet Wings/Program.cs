    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Task_02.Hornet_Wings
    {
        class Program
        {
            static void Main(string[] args)
            {
            // input
                long wingFlaps = long.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());       // A hornet rests for 5 seconds.
                int endurance = int.Parse(Console.ReadLine());            //integer indicating the endurance of the contestant
            //solution
                var distanceInMeters = wingFlaps / 1000 * distance;
                var restTime = (wingFlaps / endurance) * 5;
                var restTimeForDistance = wingFlaps / 100;
                var allTime = restTime + restTimeForDistance;
                Console.WriteLine($"{distanceInMeters:F2} m.");
                Console.WriteLine($"{allTime} s.");
            }
        }
    }
