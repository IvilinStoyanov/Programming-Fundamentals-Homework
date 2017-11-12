using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            // totalYears = {totalLength} ^ 2 * ({totalWidth} + 2 * {wingLength})
            decimal totalYears = 0;
            for (int i = 0; i < count; i++)
            {
                var totalLength = int.Parse(Console.ReadLine());
                var totalWidth = decimal.Parse(Console.ReadLine());
                var wing = int.Parse(Console.ReadLine());
                totalYears = (decimal)(Math.Pow(totalLength, 2)) * (totalWidth + 2 * (decimal)wing);
                Console.WriteLine("{0}", totalYears);
            }
        }
    }
}