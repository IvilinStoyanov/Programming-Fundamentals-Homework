using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // upper part - first line
            int upperPartLeftDotCount = n * 2 - 1;
            int upperPartRightDotCount = n * 2 - 1;
            Console.WriteLine("{0}/|\\{1}", 
                new string('.' , upperPartLeftDotCount),
                new string('.' , upperPartRightDotCount));
            // upper part - second line
            int upperPartLeftDotCountSL = n * 2 - 1;
            int upperPartRightDotCountSL = n * 2 - 1;
            Console.WriteLine("{0}\\|/{1}",
                new string('.', upperPartLeftDotCountSL),
                new string('.', upperPartRightDotCountSL));
            // upper part - thirt line 
            int upperPartLeftDotCountTL = n * 2 - 1;
            int upperPartRightDotCountTL = n * 2 - 1;
            Console.WriteLine("{0}***{1}",
                new string('.', upperPartLeftDotCountSL),
                new string('.', upperPartRightDotCountSL));

            // middle line
            int middleLineLeftDotCount = n * 2 - 2;
            int middleLineDashCountL = 1;
            int middleLineDashCountR = 1;
            int middleLineRightDotCount = n * 2 - 2;
            int middleLineHeightCount = n * 2 - 1;

            for (int i = 0; i < middleLineHeightCount; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{3}",
                    new string('.', middleLineLeftDotCount),
                    new string('-', middleLineDashCountL),
                    new string('-', middleLineDashCountR),
                    new string('.', middleLineRightDotCount));

                middleLineLeftDotCount--;
                middleLineDashCountL++;
                middleLineDashCountR++;
                middleLineRightDotCount--;
            }

            int bottomPartStarCountUp = n * 4 + 1;
            Console.WriteLine("{0}"
                , new string('*', bottomPartStarCountUp));

            // bottom part
            for (int i = 0; i < n ; i++)
            {
                Console.Write("*.");
            }
            Console.Write("*");
            for (int i = 0; i < n; i++)
            {
                Console.Write(".*");
            }

                Console.WriteLine();
            int bottomPartStarCountDown = n * 4 + 1;
            Console.WriteLine("{0}"
                , new string('*', bottomPartStarCountDown));

        }
    }
}
