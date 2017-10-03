using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign (int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number {0} is negative." , number);
            }
            if (number == 0)
            {
                Console.WriteLine("The number {0} is zero." , number);
            }
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive." , number);
            }
        }
    }
}
