using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // first line
            int firstLineStarCount = n * 2 + 1;
            Console.WriteLine("{0}" ,
                new string('*' , firstLineStarCount));
            // second line 
            int secondLineMiddleInterval = (n * 2 + 1) - 4;
            Console.WriteLine(".*" + "{0}" + "*." ,
                new string(' ' , secondLineMiddleInterval));
            // upper part 
            int upperPartLeftDotCount = 2;
            int upperPartMiddleACount = secondLineMiddleInterval - 2;
            int upperPartRightDotCount = 2;
            int upperPartHeightCount = n - 2;
            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("{0}*{1}*{2}" , 
                    new string('.' , upperPartLeftDotCount),
                    new string('@' , upperPartMiddleACount),
                    new string('.' , upperPartRightDotCount));
                upperPartLeftDotCount++;
                upperPartMiddleACount -= 2;
                upperPartRightDotCount++;
            }
            // middle special part
            int middleSpecialPartLeftDotCount = n;
            int middleSpecialPartRightDotCount = n;
            Console.WriteLine("{0}*{1}" , 
                new string('.' , middleSpecialPartLeftDotCount),
                new string('.' , middleSpecialPartRightDotCount));
            // bottom part
            int bottomPartLeftDotCount = n - 1;
            int bottomPartLeftIntervalCount = 0;
            int bottomPartRightIntervalCount = 0;
            int bottomPartRightDotCount = n - 1;
            int bottomPartHeightCount = n - 2;
            for (int i = 0; i < bottomPartHeightCount; i++)
            {
                Console.WriteLine("{0}*{1}@{2}*{3}" , 
                    new string('.' , bottomPartLeftDotCount),
                    new string(' ' , bottomPartLeftIntervalCount),
                    new string(' ' , bottomPartRightIntervalCount),
                    new string('.' , bottomPartRightDotCount));
                bottomPartLeftDotCount--;
                bottomPartLeftIntervalCount++;
                bottomPartRightIntervalCount++;
                bottomPartRightDotCount--;  
            }
            // ending part
            int endingPartMiddleCount = (bottomPartLeftIntervalCount + bottomPartRightIntervalCount + 1);
            Console.WriteLine(".*{0}*." , 
                new string('@' , endingPartMiddleCount));
            // last part 
            int bottomLineStarCount = n * 2 + 1;
            Console.WriteLine("{0}",
                new string('*', bottomLineStarCount));
        }
    }
}
