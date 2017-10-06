using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char invalid = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i != invalid && j != invalid && k != invalid)
                        {
                            counter++;
                            Console.Write($"{i}{j}{k} ");
                        }
                        
                    }
                }
            }
            Console.Write(counter);

        }
    }
}
