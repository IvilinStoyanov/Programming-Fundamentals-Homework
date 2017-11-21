using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int lengthOfTheMarathonInDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            double lengthOfTheTrack = double.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine());

            double amountOfMoneyDonated = double.Parse(Console.ReadLine());
            //solution
            int capacity = capacityOfTheTrack * lengthOfTheMarathonInDays;
            if(capacity <= numberOfRunners)
            {
                numberOfRunners = capacity;
            }
            long totalKilometers = (long)(numberOfRunners * averageLaps * lengthOfTheTrack) / 1000;
            decimal moneyRaisedPerKilometer = (decimal)(amountOfMoneyDonated * totalKilometers);
            Console.WriteLine($"Money raised: {moneyRaisedPerKilometer:F2}");
        }
            
    }
}
