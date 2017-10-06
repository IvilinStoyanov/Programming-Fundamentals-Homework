using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciFormula(n));
        }

        static int FibonacciFormula (int n)
        {
            int oneStepBehind = 1;
            int currrentNumber = 0;
            for (int i = 0; i <= n; i++)
            {
                int tempLong = currrentNumber;
                currrentNumber += oneStepBehind;
                oneStepBehind = tempLong;
            }
            return currrentNumber;

        }
    }
}
