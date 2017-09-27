using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());           
            // solution
            Console.WriteLine("{0:F2}" , a * b);
                
        }
    }
}
