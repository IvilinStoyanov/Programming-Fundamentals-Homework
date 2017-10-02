using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fistNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber > fistNumber)
                for (int i = fistNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            if (fistNumber > secondNumber)
            {
                for (int i = secondNumber; i <= fistNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
