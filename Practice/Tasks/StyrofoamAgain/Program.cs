using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyrofoamAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaOfHouse = double.Parse(Console.ReadLine());
            int windowCount = int.Parse(Console.ReadLine());
            double styrofoamMeterSquare = double.Parse(Console.ReadLine());
            double pricePerStyrofoam = double.Parse(Console.ReadLine());

            double allArea = (areaOfHouse - (2.4 * windowCount)) * 1.10;
            double styrofoamNeeded =Math.Ceiling(allArea / styrofoamMeterSquare);
            double money = styrofoamNeeded * pricePerStyrofoam;
            double leftMoney = Math.Abs(budget - money);
            if (budget >= money)
            {
                Console.WriteLine("Spent: {0:f2}" , money);
                Console.WriteLine("Left: {0:f2}", leftMoney);

            }
            else
            {
                Console.WriteLine("Need more: {0:f2}" , leftMoney);
            }

        }
    }
}
