using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var numBase = int.Parse(inputLine[0]);
            var numberBase10 = BigInteger.Parse(inputLine[1]);
            var numString = string.Empty;

            while (numberBase10 > 0)
            {
                var remainder = numberBase10 % numBase;
                numString = remainder + numString;
                numberBase10 /= numBase;
            }

            Console.WriteLine(numString);
        }
    }
}