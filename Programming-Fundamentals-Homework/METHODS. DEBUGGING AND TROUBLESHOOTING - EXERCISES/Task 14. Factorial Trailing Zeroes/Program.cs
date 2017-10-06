using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = FindingFactorial(number);
            int zeroes = TrailingZeroesCount(factorial);
            Console.WriteLine(zeroes);
        }

        static BigInteger FindingFactorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int TrailingZeroesCount(BigInteger num)
        {
            int zeroes = 0;
            bool hasZeroes = true;
            while (hasZeroes == true)
            {
                BigInteger digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    zeroes++;
                }
                else
                {
                    hasZeroes = false;
                }
            }
            return zeroes;
        }


    }
}
