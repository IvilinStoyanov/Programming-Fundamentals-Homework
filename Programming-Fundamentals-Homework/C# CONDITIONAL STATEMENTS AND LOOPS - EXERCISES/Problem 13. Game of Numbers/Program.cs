using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int lastNumber01 = 0;
            int lastNumber02 = 0;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    if (i + j == magicNumber)
                    {
                        lastNumber01 = i;
                        lastNumber02 = j;
                    }
                    counter++;
                }
            }
            if (lastNumber01 + lastNumber02 == magicNumber)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastNumber01, lastNumber02, magicNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }

        }
    }
}
