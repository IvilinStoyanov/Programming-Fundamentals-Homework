using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06._6.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var widht = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = TriangleAreaCalculation(widht, height);
            Console.WriteLine(area);
        }
        
        static double TriangleAreaCalculation(double widht , double height)
        {
            return (widht * height) / 2;
        }
    }
}
