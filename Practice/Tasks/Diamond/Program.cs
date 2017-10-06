using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());         
            Console.WriteLine("{0}{1}{0}" , new string('.' , n), new string('*' , n * 3));
            int upperPartDotCount = n - 1;
            int upperPartMidDotCount = n * 3;           
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}" , 
                    new string('.' , upperPartDotCount),
                    new string('.' , upperPartMidDotCount));
                upperPartDotCount--;
                upperPartMidDotCount += 2;
            }
            int specialMidPart = 5 * n;
            Console.WriteLine("{0}" , new string('*' , specialMidPart));          
            int bottomPartDotCount = 1;
            int bottomPartMidDotCount = (n - 1) * 5 + 1;            
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}" , 
                    new string('.' , bottomPartDotCount),
                    new string('.' , bottomPartMidDotCount));
                bottomPartDotCount++;
                bottomPartMidDotCount -= 2;
            }                
            Console.WriteLine("{0}{1}{0}" , new string('.', n * 2 + 1), new string('*' , n - 2));
        }
    }
}
