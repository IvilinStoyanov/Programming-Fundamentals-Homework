using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            // first line
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_' , (n * 2) + 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();

            for (int row = 0; row <= n; row++)
            {
                if (row < n)
                {

                    Console.Write(new string('.', n - row));
                    Console.Write("//");
                    Console.Write(new string('_', (2 * n) - 1 + (2 * row)));
                    Console.Write("\\\\");
                    Console.Write(new string('.', n - row));
                    Console.WriteLine();
                }

                else
                {

                    Console.Write("//");
                    Console.Write(new string('_', n + row - 3));
                    Console.Write("STOP!");
                    Console.Write(new string('_', n + row - 3));
                    Console.Write("\\\\");
                    Console.WriteLine();
                }
            }
            for (int row = n; row > 0; row--)
            {
                Console.Write(new string('.', n - row));
                Console.Write("\\\\");
                Console.Write(new string('_', (2 * n) - 1 + (2 * row)));
                Console.Write("//");
                Console.Write(new string('.', n - row));
                Console.WriteLine();
            }
          


        }
    }
}
