using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();



            if (n >= 20 && n < 100)
            {
                var busPrice = n * 0.09;
                Console.WriteLine("{0:f2}", busPrice);
            }
            else if (n >= 100) {
                var trainPrice = n * 0.06;
                Console.WriteLine("{0:f2}", trainPrice);
            }
            
            else if (n < 20 && dayOrNight == "day")
            {
                var taxiDay = 0.70 + (0.79 * n);
                Console.WriteLine("{0:f2}", taxiDay);
            }
            else if (n < 20 && dayOrNight == "night")
            {
                var taxiNight = 0.70 + (0.90 * n);
                Console.WriteLine("{0:f2}" , taxiNight);
            }

        }
    }
}
