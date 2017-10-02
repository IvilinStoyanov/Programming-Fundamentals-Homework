using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());          
            bool result = true;
            if (Math.Abs(a - b) < 0.000001)
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }
        }
    }
}
