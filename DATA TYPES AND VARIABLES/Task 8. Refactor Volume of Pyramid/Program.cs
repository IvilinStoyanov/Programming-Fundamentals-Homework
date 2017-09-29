using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.Write("Length: ");
             double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double V = double.Parse(Console.ReadLine());
            result = (lenght * width * V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", result);

        }
    }
}
