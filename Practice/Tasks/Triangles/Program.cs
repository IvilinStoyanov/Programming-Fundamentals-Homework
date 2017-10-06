using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            // first line 
            int firstLineDiezCount = 4 * n + 1;          
            Console.WriteLine("{0}" ,
                new string('#', firstLineDiezCount));
            // upperPart
            int upperPartIntervalCount = 1;
            int upperPartDiezCount = n * 2 - 1;
            int upperPartDotCount = 1;
            for (int j = 1; j <= n; j++)
            {
                if (j == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                        new string('.', upperPartDotCount),
                        new string('#', upperPartDiezCount),
                        new string(' ', (n - 2) / 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', upperPartDotCount),
                        new string('#', upperPartDiezCount),
                        new string(' ', upperPartIntervalCount));

                }
                upperPartDotCount++;
                upperPartIntervalCount += 2;
                upperPartDiezCount -= 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n + 1 + i),
                    new string('#', 2 * n - 1 - 2 * i));
            }
        }
    }
}