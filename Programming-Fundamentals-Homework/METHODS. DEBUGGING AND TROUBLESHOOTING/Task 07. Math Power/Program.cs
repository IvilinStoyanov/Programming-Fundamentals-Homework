using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double number = double.Parse(Console.ReadLine());
            double powerOfNumber = double.Parse(Console.ReadLine());
            double result = CalculaitonOfMathPower(number, powerOfNumber);
            Console.WriteLine(result);

        }

        static double CalculaitonOfMathPower(double number , double powerOfNumber)
        {           
            double result = Math.Pow(number, powerOfNumber);
            return result;
        }


    }
}
