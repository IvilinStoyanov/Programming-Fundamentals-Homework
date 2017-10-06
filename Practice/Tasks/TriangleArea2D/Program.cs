using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            var a = Math.Abs(x3 - x2);
            Console.WriteLine(a);
            Console.WriteLine();
            var h = Math.Abs(y2 - y1);
            Console.WriteLine(h);
            Console.WriteLine();
            double area = a * h / 2.00;
            Console.WriteLine(area);
        }
    }
}
