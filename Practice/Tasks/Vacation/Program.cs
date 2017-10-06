using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // variables
            string choosenSeason = season == "Summer" 
                ? "Alaska" : "Morocco";
            Console.Write(choosenSeason);
          if (budget <= 1000)
            {             
                double priceForSeason = season == "Summer" ?
                    budget * 0.65 : budget * 0.45;
                Console.WriteLine(" - Camp - {0:f2}", priceForSeason);
            }
          if (budget > 1000 && budget <= 3000)
            {
                double priceForSeason = season == "Summer" ?
                   budget * 0.80 : budget * 0.60;
                Console.WriteLine(" - Hut - {0:f2}", priceForSeason);
            }
          if (budget > 3000)
            { 
                double priceForSeason = season == "Summer" ?
                   budget * 0.90 : budget * 0.90;
                Console.WriteLine(" - Hotel - {0:f2}", priceForSeason);
            }
        }
    }
}
