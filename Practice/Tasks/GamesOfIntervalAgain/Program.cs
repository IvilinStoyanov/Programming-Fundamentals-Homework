using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOfIntervalAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnCount = int.Parse(Console.ReadLine());
            double result = 0;
            double group0to9 = 0;
            double group10to19 = 0;
            double group20to29 = 0;
            double group30to39 = 0;
            double group40to50 = 0;
            double invalid = 0;
            for (int i = 0; i < turnCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    result += number * 0.20;
                    group0to9++;
                }
                if (number >= 10 && number <= 19)
                {
                    result += number * 0.30;
                    group10to19++;
                }
                if (number >= 20 && number <= 29)
                {
                    result += number * 0.40;
                    group20to29++;
                }
                if (number >= 30 && number <= 39)
                {
                    result += 50;
                    group30to39++;
                }
                if (number >= 40 && number <= 50)
                {
                    result += 100;
                    group40to50++;
                }
                if (number < 0 || number > 50)
                {
                    result /= 2;
                    invalid++;
                }
            }
           
            Console.WriteLine("{0:f2}" , result);
            Console.WriteLine("From 0 to 9: {0:f2}%", group0to9 / turnCount * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", group10to19 / turnCount * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", group20to29 / turnCount * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", group30to39 / turnCount * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", group40to50 / turnCount * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalid / turnCount * 100);
        }
    }
}
