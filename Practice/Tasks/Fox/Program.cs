using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // upper part
            int upperPartLeftStartCount = 1;
            int upperPartMiddleDashesCount = n * 2 - 1;
            int upperPartHeightCount = n;
            int upperPartRightStartCount = 1;

            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}",
                new string('*', upperPartLeftStartCount),
                new string('-', upperPartMiddleDashesCount),
                new string('*', upperPartRightStartCount));

                upperPartLeftStartCount++;
                upperPartMiddleDashesCount -= 2;
                upperPartRightStartCount++;
            }

            // middle part 
            int middlePartLeftStarCount = n / 2;
            int middlePartMiddleStarCount = n;
            int middlePartRightStarCount = n / 2;
            int middlePartHeightCount = n / 3;

            for (int i = 0; i < middlePartHeightCount; i++)
            {
                Console.WriteLine("|{0}\\{1}/{2}|" , 
                    new string('*' , middlePartLeftStarCount),
                    new string('*' , middlePartMiddleStarCount),
                    new string('*' , middlePartRightStarCount));

                middlePartLeftStarCount++;
                middlePartMiddleStarCount -= 2;
                middlePartRightStarCount++;
            }
            //bottom part
            int bottomPartLeftDashesCount = 1;
            int bottomPartMiddleStarCount = n * 2 - 1;
            int bottomPartRightDashesCount = 1;
            int bottomPartHeightCount = n;

            for (int i = 0; i < bottomPartHeightCount; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", 
                    new string('-' , bottomPartLeftDashesCount),
                    new string('*' , bottomPartMiddleStarCount),
                    new string('-' , bottomPartRightDashesCount));

                bottomPartLeftDashesCount++;
                bottomPartMiddleStarCount -= 2;
                bottomPartRightDashesCount++;
            }


        }
    }
}
