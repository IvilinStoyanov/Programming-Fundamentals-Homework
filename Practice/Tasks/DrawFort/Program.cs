using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write('/');
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('^');
            }
            Console.Write('\\');
            for (int i = 0; i < (n * 2) - 4 - 2*(n/2); i++)
            {
                Console.Write('_');
            }
            Console.Write('/');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('^');
            }
            Console.Write('\\');
            Console.WriteLine();

            for (int row = 0; row < n - 3; row++)
            {
                Console.Write('|');
                for (int col = 0; col < n * 2 - 2; col++)
                {
                    Console.Write(' ');
                }
                Console.Write('|');
                Console.WriteLine();
            }
            Console.Write('|');
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(' ');
            }
            for (int i = 0; i < (2 * n) - 4- 2 * (n/2); i++)
            {
                Console.Write('_');
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(' ');
            }
            Console.Write('|');
            Console.WriteLine();

            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write('/');
            for (int i = 0; i < (n * 2) - 4 - 2 * (n/2) ; i++)
            {
                Console.Write(' ');
            }
            Console.Write('\\');
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('_');
            }
            Console.Write('/');
            Console.WriteLine();
        }
    }
}
