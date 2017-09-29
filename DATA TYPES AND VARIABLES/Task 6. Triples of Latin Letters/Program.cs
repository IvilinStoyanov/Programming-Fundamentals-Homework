using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + k);
                        char letter3 = (char)('a' + l);
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
           
        }
    }
}
