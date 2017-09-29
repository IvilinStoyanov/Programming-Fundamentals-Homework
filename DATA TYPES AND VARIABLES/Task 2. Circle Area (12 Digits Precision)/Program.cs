using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            double radius = double.Parse(Console.ReadLine());
            // solution
            Console.WriteLine("{0:F12}" , radius * radius * Math.PI);
        }
    }
}
