using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
                char end = char.Parse(Console.ReadLine());
            char invalidLetter = char.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = start; i <= end; i++)
            {      
                for (int j = start; j <= end; j++)
                {                  
                    for (int k = start; k <= end; k++)
                    {
                        if (i != invalidLetter && j != invalidLetter && k != invalidLetter)
                        {
                            counter++;
                            Console.Write("{0}{1}{2} ", (char)(i), (char)(j), (char)(k));
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
