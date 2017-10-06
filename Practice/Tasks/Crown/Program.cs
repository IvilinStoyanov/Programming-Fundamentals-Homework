using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line
            int firstLineIntervalLeftCount = n - 2;
            int firstLineIntervalRightCount = n - 2;
            Console.WriteLine("@{0}@{1}@",
                new string(' ', firstLineIntervalLeftCount),
                new string(' ', firstLineIntervalRightCount));
            // second line       
            int secondLineLeftIntervalCount = n - 3;
            int secondLineRightIntervalCount = n - 3;
            Console.WriteLine("**{0}*{1}**",
               new string(' ', secondLineLeftIntervalCount),
               new string(' ', secondLineRightIntervalCount));
            // upper part

            int upperPartLeftDotCount = 1;
            int upperPartLeftIntervalCount = n - 5;
            int upperPartMiddleDotCount = 1;
            int upperPartRightIntervalCount = n - 5;
            int upperPartRightDotCount = 1;
            int upperPartHeightCount = n / 2 - 2;
            for (int i = 0; i < upperPartHeightCount; i++)
            {

                Console.WriteLine("*{0}*{1}*{2}*{3}*{4}*",
                    new string('.', upperPartLeftDotCount),
                    new string(' ', upperPartLeftIntervalCount),
                    new string('.', upperPartMiddleDotCount),
                    new string(' ', upperPartRightIntervalCount),
                    new string('.', upperPartRightDotCount));

                upperPartLeftDotCount++;
                upperPartLeftIntervalCount -= 2;
                upperPartMiddleDotCount += 2;
                upperPartRightIntervalCount -= 2;
                upperPartRightDotCount++;
            }
            // middle part
            int middlePartLeftDotCount = n / 2 - 1;
            int middlePartMiddleDotCount = n - 3;
            int middlePartRightCount = n / 2 - 1;
            Console.WriteLine("*{0}*{1}*{2}*",
                new string('.', middlePartLeftDotCount),
                new string('.', middlePartMiddleDotCount),
                new string('.', middlePartRightCount));

            // last line
            int lastLineLeftDotCount = n / 2;
            int lastLineLeftStartCount = n / 2 - 2;
            int lastLineRightStartCount = n / 2 - 2;
            int lastLineRightDotCount = n / 2;
            Console.WriteLine("*{0}{1}.{2}{3}*" , 
               new string('.' , lastLineLeftDotCount),
               new string('*' , lastLineLeftStartCount),
               new string('*' , lastLineRightStartCount),
               new string('.' , lastLineRightDotCount));

            int lastStarCount = n * 2 - 1;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0}" , 
                 new string('*' ,lastStarCount));
            }
        }
    }
        
}


