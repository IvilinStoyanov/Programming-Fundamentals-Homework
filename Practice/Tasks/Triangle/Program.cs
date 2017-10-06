using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line 
            Console.WriteLine(new string('#' , n * 4 + 1));
            // upper part
            int upperPartLeftDotCount = 1;
            int upperPartLeftDiezCount = n * 2 - 1;
            int upperPartMiddleIntervalCount = 1;
            int upperPartRightDiezCount = n * 2 - 1;
            int upperPartRightDotCount = 1;
            int upperPartHeightCount = n;
            for (int i = 0; i < upperPartHeightCount; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}@{2}{3}{4}",
                   new string('.', upperPartLeftDotCount),
                   new string('#', upperPartLeftDiezCount),
                   new string(' ', upperPartMiddleIntervalCount),
                   new string(' ', upperPartMiddleIntervalCount),
                   new string('#', upperPartRightDiezCount),
                   new string('.', upperPartRightDotCount));
                    upperPartLeftDotCount++;
                    upperPartLeftDiezCount -= 2;
                  
                    upperPartRightDiezCount -= 2;
                    upperPartRightDotCount++;
                }
                else
                Console.WriteLine("{0}{1}{2}{3}{4}" , 
                    new string('.' , upperPartLeftDotCount),
                    new string('#' , upperPartLeftDiezCount),
                    new string(' ' , upperPartMiddleIntervalCount),
                    new string('#' , upperPartRightDiezCount),
                    new string('.' , upperPartRightDotCount));
                upperPartLeftDotCount++;
                upperPartLeftDiezCount -= 2;
                upperPartMiddleIntervalCount += 2;
                upperPartRightDiezCount -= 2;
                upperPartRightDotCount++;
            }
        }
    }
}
