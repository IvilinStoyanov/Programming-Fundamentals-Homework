using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int cupsNeeded = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            // variables 
            int cupTime = 5;
            int workerDay = 8;

            // solution
            double allHours = workerCount * workDays * workerDay;
            double cupMade = Math.Truncate(allHours / cupTime);
            double leftCups = Math.Abs(cupMade - cupsNeeded);

            if (cupMade >= cupsNeeded)
            {            
                double moneyWon = leftCups * 4.2;
                Console.WriteLine("{0:f2} extra money" , moneyWon);
            }
            else
            {
                double losses = leftCups * 4.2;
                Console.WriteLine("Losses: {0:f2}" , losses);
            }

        }
    }
}
