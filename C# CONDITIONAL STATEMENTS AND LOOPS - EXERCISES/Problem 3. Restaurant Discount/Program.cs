using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();
            double suitablePrice = 1;
            double priceOfPackage = 1;
            double discount = 1;
            string hall = null;
            if (groupSize > 120) Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                if (groupSize > 100 && groupSize <= 120)
                {
                    hall = "Great Hall";
                    switch (servicePackage)
                    {
                        case "Normal": discount = 0.95; priceOfPackage = 500; break;
                        case "Gold": discount = 0.9; priceOfPackage = 750; break;
                        case "Platinum": discount = 0.85; priceOfPackage = 1000; break;
                    }
                    suitablePrice = (7500 + priceOfPackage) * discount;
                }
                // first change
                else if (groupSize > 50 && groupSize <= 100)
                {
                    hall = "Terrace";
                    switch (servicePackage)
                    {
                        case "Normal": discount = 0.95; priceOfPackage = 500; break;
                        case "Gold": discount = 0.9; priceOfPackage = 750; break;
                        case "Platinum": discount = 0.85; priceOfPackage = 1000; break;
                    }
                    suitablePrice = (5000 + priceOfPackage) * discount;
                }
                // second change
                else if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    switch (servicePackage)
                    {
                        case "Normal": discount = 0.95; priceOfPackage = 500; break;
                        case "Gold": discount = 0.9; priceOfPackage = 750; break;
                        case "Platinum": discount = 0.85; priceOfPackage = 1000; break;
                    }
                    suitablePrice = (2500 + priceOfPackage) * discount;
                }
                // third change
                double pricePerPerson = suitablePrice / groupSize;
                Console.WriteLine("We can offer you the {0:F2}", hall);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
        }
    }
}