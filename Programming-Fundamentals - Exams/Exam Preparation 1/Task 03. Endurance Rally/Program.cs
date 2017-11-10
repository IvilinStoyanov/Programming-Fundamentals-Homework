using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var drivers = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpoint = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            //data for drivers          
            foreach (var driver in drivers)
            {
                bool FuelLeft = false;
                int reachedIndex = 0;
                double fuel = driver[0];

                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkpoint.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel <= 0)
                    {
                        FuelLeft = true;
                        reachedIndex = i;
                        break;
                    }
                }

                if (FuelLeft == true)
                {
                    Console.WriteLine($"{driver} - reached {reachedIndex}");
                }
                else
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", driver, fuel);
                }
            }
        }
    }
}
