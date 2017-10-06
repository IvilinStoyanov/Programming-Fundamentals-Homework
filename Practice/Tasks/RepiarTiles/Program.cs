using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepiarTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int LenghtLanding = int.Parse(Console.ReadLine());
            double WidthTiles = double.Parse(Console.ReadLine());
            double LenghtTiles = double.Parse(Console.ReadLine());
            int widthBench = int.Parse(Console.ReadLine());
            int lenghtBench = int.Parse(Console.ReadLine());

            int areaLanding = LenghtLanding * LenghtLanding;
            double areaTiles = WidthTiles * LenghtTiles;
            int areaBench = widthBench * lenghtBench;
            double allArea = areaLanding - areaBench;
            double tilesCount = allArea / areaTiles;
            double time = tilesCount * 0.2;
            Console.WriteLine("{0:f2}" , tilesCount);
            Console.WriteLine("{0:f2}", time);

        }
    }
}
