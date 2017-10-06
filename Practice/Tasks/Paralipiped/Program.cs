using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralipiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line
            int firstPartLeftSlashCount = n - 2;
            int firstPartRightDotCount = n * 2 + 1;
            Console.WriteLine("+{0}+{1}" ,
                new string('~' , firstPartLeftSlashCount),
                new string('.' , firstPartRightDotCount));
            // upper part 
            int upperPartLeftInterval = 0;
            int upperPartSlashLeftCount = n - 2;
            int upperPartRightDotCount = n * 2;
            int upperPartHeightCount = n * 2 + 1;
            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}" , 
                    new string('.' , upperPartLeftInterval),
                    new string('~' , upperPartSlashLeftCount),
                    new string('.' , upperPartRightDotCount));
                upperPartLeftInterval++;
                upperPartRightDotCount--;
            }
            // bottom part
            int bottomPartIntervalCount = 0;
            int bottomPartMiddleDotCount = n * 2;
            int bottomPartRightSlashCount = n - 2;
            int bottomPartHeightCount = n * 2 + 1;
            for (int i = 0; i < bottomPartHeightCount; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|" , 
                    new string('.' ,bottomPartIntervalCount),
                    new string('.' , bottomPartMiddleDotCount),
                    new string('~' , bottomPartRightSlashCount));
                bottomPartIntervalCount++;
                bottomPartMiddleDotCount--;
            }
            // last part
            int lastPartLeftSlashCount = n - 2;
            int lastPartRightDotCount = n * 2 + 1;
            Console.WriteLine("{0}+{1}+",
                new string('.', firstPartRightDotCount),
                new string('~', lastPartLeftSlashCount));
        }
    }
}
