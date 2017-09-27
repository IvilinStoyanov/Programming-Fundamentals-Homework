using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            double miles = double.Parse(Console.ReadLine());
            // solution
            Console.WriteLine("{0:F2}" , miles * 1.60934);
        }
    }
}
