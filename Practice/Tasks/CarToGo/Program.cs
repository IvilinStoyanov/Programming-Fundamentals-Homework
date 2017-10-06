using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

           

            if (budget <= 100)
            {
                
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    double CabrioPrice = budget * 0.35;
                    Console.WriteLine("Cabrio - {0:f2}", CabrioPrice);
                }
                else
                {
                    double JeepPrice = budget * 0.65;
                    Console.WriteLine("Jeep - {0:f2}", JeepPrice);
                }
            }
            if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    double CabrioPrice = budget * 0.45;
                    Console.WriteLine("Cabrio - {0:f2}", CabrioPrice);
                }
                else
                {
                    double JeepPrice = budget * 0.80;
                    Console.WriteLine("Jeep - {0:f2}", JeepPrice);
                }
            }
            if (budget > 500)
            {
                Console.WriteLine("Luxury class");          
                    double JeepPrice = budget * 0.90;
                    Console.WriteLine("Jeep - {0:f2}", JeepPrice);
                }
            }
        }
    }

