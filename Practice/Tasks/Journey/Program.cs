using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
           

            if (budget <= 100  )
            {
                if (season == "summer")
                {
                    var campPrice = (budget * 30) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp " + "- {0:f2}" , campPrice);
                }
                else if (season == "winter") 
                        {
                    var hotelPrice = (budget * 70) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel " + "- {0:f2}", hotelPrice);
                        }
                 }
            if ( budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    var campPrice = (budget * 40) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp " + "- {0:f2}", campPrice);
                }
                else if (season == "winter")
                {
                    var hotelPrice = (budget * 80) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel " + "- {0:f2}", hotelPrice);
                }
            }
            if (budget > 1000)
            {
                var hotelPrice = (budget * 90) / 100;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel " + "- {0:f2}", hotelPrice);
            }
        }
    }
}
