using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double seconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerOneMeter = double.Parse(Console.ReadLine());
            // variables
            double needToSwim = meters * secondsPerOneMeter;
            double slowingCount = Math.Truncate(meters / 15);
            double slowingCountF = (slowingCount * 12.5);
            double allTime = needToSwim + slowingCountF;
          
            if (allTime >= seconds)
            {
                double result = Math.Abs(allTime - seconds);
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", result);
                
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", allTime);
            }

        }
    }
}
