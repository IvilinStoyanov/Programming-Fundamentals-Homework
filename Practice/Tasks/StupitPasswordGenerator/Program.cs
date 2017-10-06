using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupitPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstNumber = 1; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= n; secondNumber++)
                {
                    for (char firstLetter = 'a'; firstLetter < 'a' + l; firstLetter++)
                    {
                        for (char secondLetter = 'a'; secondLetter < 'a' + l; secondLetter++)
                        {
                            
                            for (int lastNumber =Math.Max(firstNumber, secondNumber) + 1; lastNumber <= n; lastNumber++)
                            {                                                         
                                    Console.Write($"{firstNumber}{secondNumber}{firstLetter}{secondLetter}{lastNumber} ");
                                counter++;
                            }
                        }
                    }
                }                       
            }
            Console.WriteLine();
            Console.WriteLine(counter);
        }
    }
}
