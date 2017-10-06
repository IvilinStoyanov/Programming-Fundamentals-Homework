using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            // read two array from console
            string[] arrayFirst = Console.ReadLine().Split();
            string[] arraySecond = Console.ReadLine().Split();
            // counters 
            int counterOfLeft = 0;
            int counterOfRight = 0;
            // First Array check 
            for (int i = 0; i <= Math.Min(arrayFirst.Length, arraySecond.Length) - 1; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                {
                    counterOfLeft++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i <= Math.Min(arrayFirst.Length, arraySecond.Length) - 1; i++)
            {
                if (arrayFirst[arrayFirst.Length - 1 - i] == arraySecond[arraySecond.Length - 1 - i])
                {
                    counterOfRight++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(counterOfLeft, counterOfRight));
        }
    }
}
