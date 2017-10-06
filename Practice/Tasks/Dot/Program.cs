using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            if (a <= x && x <= b || a >= x && x >= b)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            if (Math.Abs(a - x) < Math.Abs(b - x))
            {
                Console.WriteLine(Math.Abs(a - x));
            }
            else
            {
                Console.WriteLine(Math.Abs(b - x));
            }

        }

        }
}

