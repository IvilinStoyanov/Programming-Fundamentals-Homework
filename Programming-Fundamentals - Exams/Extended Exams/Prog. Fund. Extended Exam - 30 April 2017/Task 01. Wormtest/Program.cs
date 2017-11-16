using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthCentimeters = double.Parse(Console.ReadLine()) * 100;
            double widthCentimeters = double.Parse(Console.ReadLine());
           
            if(lengthCentimeters % widthCentimeters == 0 || widthCentimeters == 0)
            {
                Console.WriteLine("{0:F2}" , lengthCentimeters * widthCentimeters);
            }
            else
            {
                double result = (lengthCentimeters / widthCentimeters) * 100;
                Console.WriteLine("{0:F2}%" , result);
            }
        }
    }
}
