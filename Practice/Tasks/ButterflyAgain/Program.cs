using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterflyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new string('-' , n - 2) + "\\" + " " + "/" + (new string('-', n - 2)));
                }
                else
                {
                    Console.WriteLine(new string('*', n - 2) + "\\" + " " + "/" + (new string('*', n - 2)));

                }
            }
            if (i == n - 1)
            {
                Console.WriteLine(new string(' ' , n - 1) + "@" + new string(' ', n - 1));
            }
            for (int j = 0; j < n - 2; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(new string('*', n - 2) + "/" + " " + "\\" + (new string('*', n - 2)));
                }
                else
                {
                    Console.WriteLine(new string('-', n - 2) + "/" + " " + "\\" + (new string('-', n - 2)));
                }
            }
            
        }
    }
}

