using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double budget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double styrofoamM3 = double.Parse(Console.ReadLine());
            double styrofoamPrice = double.Parse(Console.ReadLine());
            //solution
            double areaHouseWithoutWindows = areaHouse - (windowsCount * 2.4);
            double areaHouseClean = areaHouseWithoutWindows * 1.10;
            double styrofoamNeeded = Math.Ceiling(areaHouseClean / styrofoamM3);
            double sumForStyrofoam = styrofoamNeeded * styrofoamPrice;
            //result
            double left = Math.Abs(budget - sumForStyrofoam);
            if (budget > sumForStyrofoam)
            {
                Console.WriteLine("Spent: {0:f2}", sumForStyrofoam);
                Console.WriteLine("Left: {0:f2}", left);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}" , left);
            }


        }
    }
}
