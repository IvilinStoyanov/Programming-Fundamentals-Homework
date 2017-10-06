using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandBPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int left = Math.Min(a, b);
            int right = Math.Max(a, b);

            int distanceLeft = Math.Abs(left - point);
            int distanceRight = Math.Abs(right - point);

            int minDistance = Math.Min(distanceLeft, distanceRight);
            if (point >= left && point <= right)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(minDistance);


        }
    }
}
