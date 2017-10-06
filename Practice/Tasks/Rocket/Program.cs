using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper part
            int upperPartLeftDotCount = (n * 3) / 2 - 1;
            int upperPartMiddleIntervalCount = 0;
            int upperPartRightDotCount = (n * 3) / 2 - 1;
            int upperPartHeightCount = n;

            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("{0}/{1}\\{2}" , 
                    new string('.' , upperPartLeftDotCount),
                    new string(' ' , upperPartMiddleIntervalCount),
                    new string('.' , upperPartRightDotCount));

                upperPartLeftDotCount--;
                upperPartMiddleIntervalCount += 2;
                upperPartRightDotCount--;
            }
            // special part - one time 
            int specialPartLeftDotCount = n / 2;
            int specialPartMiddleStarCount = n * 2;
            int specialPartRightDotCount = n / 2;

            Console.WriteLine("{0}{1}{2}" ,
                 new string('.' ,specialPartLeftDotCount),
                 new string('*' , specialPartMiddleStarCount),
                 new string('.' , specialPartRightDotCount));

            // middle part
            int middlePartLeftDotCount = n / 2;
            int middlePartMiddleCharCount = n * 2 - 2;
            int middlePartRighttDotCount = n / 2;
            int middlePartHeightCount = n * 2;

            for (int i = 0; i < middlePartHeightCount; i++)
            {
                Console.WriteLine("{0}|{1}|{2}" , 
                    new string('.' , middlePartLeftDotCount),
                    new string('\\' , middlePartMiddleCharCount),
                    new string('.', middlePartRighttDotCount));
            }

            // bottom part
            int bottomPartHeightCount = n / 2;
            int bottomPartLeftDotCount = n / 2;
            int bottompartMiddleStarCount = n * 2 - 2;
            int bottomPartRightDotCount = n / 2;

            for (int i = 0; i < bottomPartHeightCount; i++)
            {
                Console.WriteLine("{0}/{1}\\{2}" , 
                    new string('.' , bottomPartLeftDotCount),
                    new string('*' , bottompartMiddleStarCount),
                    new string('.' , bottomPartRightDotCount));

                bottomPartLeftDotCount--;
                bottompartMiddleStarCount += 2;
                bottomPartRightDotCount--;
            }

        }
    }
}
