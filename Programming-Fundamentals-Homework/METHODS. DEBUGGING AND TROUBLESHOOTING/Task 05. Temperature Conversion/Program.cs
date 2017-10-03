using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsuis = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}" , celsuis);
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
