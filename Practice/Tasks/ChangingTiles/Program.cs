using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleA = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double PricePerTiles = double.Parse(Console.ReadLine());
            double CostForWorker = double.Parse(Console.ReadLine());
            // inputs

            //solution
            double AreaOfTheFloor = floorWidth * floorLength;
            double AreaOfTiles = (triangleA * triangleHeight) / 2;

            double TilesNeeded = Math.Ceiling((AreaOfTheFloor / AreaOfTiles)) + 5;
            double PriceForAll = (TilesNeeded * PricePerTiles) + CostForWorker;

            double LeftMoney = Math.Abs(money - PriceForAll);

            if (money >= PriceForAll)
            {
                Console.WriteLine("{0:f2} lv left." , LeftMoney);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more." , LeftMoney);
            }

        }
    }
}
