using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            //upper part
            int upperPartLeftDotCount = ((n * 2) - 1) * 3;
            int upperPartMiddleSharpCount = 1;
            int upperPartRightDotCount = ((n * 2) - 1) * 3;
            int upperPartHeightCount = n * 2;
            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("{0}{1}{2}" , 
                    new string('.' , upperPartLeftDotCount),
                    new string('#' , upperPartMiddleSharpCount),
                    new string('.', upperPartRightDotCount));
                upperPartLeftDotCount -= 3;
                upperPartMiddleSharpCount += 6;
                upperPartRightDotCount -= 3;
            }
             int upperPartMiddleSharpCountSpecial = upperPartMiddleSharpCount - 12;

            // middle part
            int middlePartHeightCount = n - 2;
            int middlePartLeftDotCount = 2;
            int middlePartRightDotCount = 3;
            for (int i = 0; i < middlePartHeightCount; i++)
            {
                Console.WriteLine("|{0}{1}{2}",
                   new string('.', middlePartLeftDotCount),
                   new string('#', upperPartMiddleSharpCountSpecial),
                   new string('.', middlePartRightDotCount));
                middlePartLeftDotCount += 3;
                middlePartRightDotCount += 3;
                upperPartMiddleSharpCountSpecial -= 6;
            }
            //bottom part       
            int bottomPartMiddleSharpCount = n * 6 + 1;
            int bottomPartRightDotCount = (n - 1) * 3;
            int bottomPartLeftDotCount = bottomPartRightDotCount - 1;
            int bottomPartHeightCount = n;
            for (int i = 0; i < bottomPartHeightCount - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", 
                    new string('.' , bottomPartLeftDotCount),
                    new string('#' , bottomPartMiddleSharpCount),
                    new string('.' , bottomPartRightDotCount));
            }
            Console.WriteLine("@{0}{1}{2}",
                    new string('.', bottomPartLeftDotCount),
                    new string('#', bottomPartMiddleSharpCount),
                    new string('.', bottomPartRightDotCount));

        }
    }
}
