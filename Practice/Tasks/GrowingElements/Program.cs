using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var currentLenght = 0;
            var maxLenght = 0;
            var previousNumber = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > previousNumber)
                {
                    currentLenght += 1;
                }
                else if (previousNumber > number)
                {
                    currentLenght = 1;
                }
                if (currentLenght > maxLenght) maxLenght = currentLenght;
                previousNumber = number;
            }
            Console.WriteLine(maxLenght);


        }
    }
}

