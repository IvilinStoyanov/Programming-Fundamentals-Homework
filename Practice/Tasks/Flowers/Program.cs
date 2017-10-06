using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantems = int.Parse(Console.ReadLine());
            int rozes = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double totalPrice = 0;
            double totalFlowers = hrizantems + rozes + tulips;

            if (season == "spring" || season == "summer")
            {
                double priceHrizantems = hrizantems * 2.00;
                double priceRozes = rozes * 4.10;
                double priceTulips = tulips * 2.50;
                if (holiday == "y")
                {
                    totalPrice = (priceHrizantems + priceRozes + priceTulips) * 1.15;
                }
                else
                {
                    totalPrice = priceHrizantems + priceRozes + priceTulips;
                }
                if (tulips > 7)
                {
                    totalPrice *= 0.95;
                }
            }
            else
            {
                double priceHrizantems = hrizantems * 3.75;
                double priceRozes = rozes * 4.50;
                double priceTulips = tulips * 4.15;
                if (holiday == "y")
                {
                    totalPrice = (priceHrizantems + priceRozes + priceTulips) * 1.15;
                }
                else
                {
                    totalPrice = priceHrizantems + priceRozes + priceTulips;
                }
                if (rozes >= 10 && season == "winter")
                {
                    totalPrice *= 0.90;
                }

            }
            if (totalFlowers > 20)
            {
                totalPrice *= 0.80;
            }

            double arranging = totalPrice + 2.00;
            Console.WriteLine("{0:F2}", Math.Round(arranging, 2));
        }

    }
}