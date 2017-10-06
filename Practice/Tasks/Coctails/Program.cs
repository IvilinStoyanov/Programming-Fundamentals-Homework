using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coctails
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            string typeOfCoctail = Console.ReadLine();
            string sizeOfCoctail = Console.ReadLine();
            int coctailCount = int.Parse(Console.ReadLine());
            // variables
            double priceCoctail = 0;
            if (typeOfCoctail == "Watermelon")
            {
                priceCoctail = typeOfCoctail == "Watermelon" && sizeOfCoctail == "small"
                    ? 56 * 2 : 28.70 * 5;
            }
            if (typeOfCoctail == "Mango")
            {
                priceCoctail = typeOfCoctail == "Mango" && sizeOfCoctail == "small"
                ? 36.66 * 2 : 19.60 * 5;
            }
            if (typeOfCoctail == "Pineapple")
            {
                priceCoctail = typeOfCoctail == "Pineapple" && sizeOfCoctail == "small"
                ? 42.10 * 2 : 24.80 * 5;
            }
            if (typeOfCoctail == "Raspberry")
            {
                priceCoctail = typeOfCoctail == "Raspberry" && sizeOfCoctail == "small"
                ? 20 * 2 : 15.20 * 5;
            }
            double allPrice = priceCoctail * coctailCount;
            if (allPrice > 1000) allPrice *= 0.50;
            if (allPrice >= 400 && allPrice <= 1000) allPrice *= 0.85;
            Console.WriteLine("{0:f2} lv." , allPrice);
        }
    }
}
