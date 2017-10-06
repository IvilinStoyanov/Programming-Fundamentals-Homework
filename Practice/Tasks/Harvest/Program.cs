using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int xArea = int.Parse(Console.ReadLine());
            double yGrapes = double.Parse(Console.ReadLine());
            int zVines = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var totalAreaGrapes = xArea * yGrapes;
            var Vine = ((40 * totalAreaGrapes) / 100) / 2.5;
            var liters = (Vine - zVines);
            var vinesForWorkers = (liters / workers);
            var vinesNeeded = (zVines - Vine);
            if (Vine >= zVines)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters." , Math.Floor(Vine));
                Console.WriteLine("{0} liters left -> {1} liters per person." , Math.Ceiling(liters), Math.Ceiling(vinesForWorkers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0:f0} liters wine needed." , Math.Floor(vinesNeeded));
            }
        }
    }
}
