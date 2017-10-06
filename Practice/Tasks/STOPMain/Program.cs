using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOPMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // fist line 
            int FirstLineDotCount = n + 1;
            int FirstLineSlashCount = n * 2 + 1;
            Console.WriteLine("{0}{1}{0}" , 
                new string('.' , FirstLineDotCount),
                new string('_' , FirstLineSlashCount));
            // upper part
            int upperPartDotCount = n;
            int upperPartSlashCount = n * 2 - 1;
            int upperPartHeightCount = n;
            for (int i = 0; i < upperPartHeightCount; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}" , 
                    new string('.' , upperPartDotCount),
                    new string('_' , upperPartSlashCount));
                upperPartDotCount--;
                upperPartSlashCount += 2;
            }
            // STOP part
            if (n == n)
            {
                int stopPartSlashCount = (upperPartSlashCount -5)  / 2;             
                Console.WriteLine("//{0}STOP!{0}\\\\" , 
                    new string('_' , stopPartSlashCount));
            }
            // bottom part
            int bottomPartSlashCount = upperPartSlashCount;
            int bottomPartDotCount = 0;
            int bottomHeightCount = n;
            for (int i = 0; i < bottomHeightCount; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}" , 
                    new string('.' , bottomPartDotCount),
                    new string('_' , bottomPartSlashCount));
                bottomPartDotCount++;
                bottomPartSlashCount -= 2;


            }
        }
    }
}
