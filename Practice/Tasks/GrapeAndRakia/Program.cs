using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double AreaOfGrape = double.Parse(Console.ReadLine());
            double KgPerMeter3 = double.Parse(Console.ReadLine());
            double scrap = double.Parse(Console.ReadLine());
            // solution
            double kiloGrapes = AreaOfGrape * KgPerMeter3 - scrap;
            double alchohol = kiloGrapes * 0.45;

            double alchoholForSale = (alchohol / 7.5) * 9.80;
            double GrapeForSale = (kiloGrapes * 0.55) * 1.5;
            Console.WriteLine("{0:f2}" , alchoholForSale);
            Console.WriteLine("{0:f2}", GrapeForSale);


        }
    }
}
