using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int n = 0; n <= number; n++)
            {
                int sumOfDigits = 0;
                int digits = n;
                while (digits >0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool specialNumber = 
                    (sumOfDigits == 5) ||
                    (sumOfDigits == 7) ||
                    (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}" , n , specialNumber);
            }
        }
    }
}
