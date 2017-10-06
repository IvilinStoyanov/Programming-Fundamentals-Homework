using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // first line 
            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));
            // first line 

            for (int i = 0; i <= n; i++)
            {
                if (i < n)
                {
                    Console.WriteLine(new string('.', n - i) + "//" + new string('_', (2 * n) - 1 + (2 * i)) + "\\\\" + new string('.', n - i));
                }
                else
                {
                    Console.WriteLine("//" + new string('_', n + i - 3) + "STOP!" + new string('_', n + i - 3) + "\\\\");
                }
            }
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string('.', n - i) + "\\\\" + new string('_', 2 * n - 1 + 2 * i) + "//" + new string('.', n - i));
            }
        }
    }
}
