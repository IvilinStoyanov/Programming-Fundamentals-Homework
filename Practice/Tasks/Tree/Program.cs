using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line
            Console.Write(new string('*' , 2 * n));
            Console.Write(new string(' ',  n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();

            //mid
           ;
            var nose = (n - 1) / 2 - 1;
            for (int row = 0; row < n - 2; row++)
            {
                if (row != nose)
                {


                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }
            }



            // last line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
        }
    }
}
