using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthInMeters = int.Parse(Console.ReadLine());
            double widthInCentimeters = double.Parse(Console.ReadLine());
            int lenghtInCentimeters = lengthInMeters * 100;
            double percentage = lenghtInCentimeters % widthInCentimeters;
           
            if(percentage == 0 || widthInCentimeters == 0)
            {
                Console.WriteLine("{0:F2}" ,(double)lenghtInCentimeters * widthInCentimeters);
            }
            else
            {
                var result = (double)(lenghtInCentimeters / widthInCentimeters * 100);
                Console.WriteLine($"{result:F2}%");
            }

        }
    }
}
