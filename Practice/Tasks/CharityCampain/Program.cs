using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampain
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gufreti = int.Parse(Console.ReadLine());
            int punkcakes = int.Parse(Console.ReadLine());
            // variables
            double sum = ((cakes * 45) + (gufreti * 5.80) + (punkcakes * 3.20)) * workers;
            double sumPerDaysF = (sum * days) * 0.875;
            Console.WriteLine("{0:f2}" , sumPerDaysF);

        }
    }
}
