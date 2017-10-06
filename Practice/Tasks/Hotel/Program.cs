using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (days <= 7)
                {
                    var studio = 50 * days;
                    var apartment = 65 * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                if (days > 7 && days <= 14)
                {
                    var studioDiscount = 50 * 0.05;
                    var studioPrice = (50 - studioDiscount) * days;

                    var apartment = 65 * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
                if (days > 14)
                {
                    var studioDiscount = 50 * 0.30;
                    var studioPrice = (50 - studioDiscount) * days;

                    var apartmentDiscount = 65 * 0.10;
                    var apartmentPrice = (65 - apartmentDiscount) * days;

                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            if (month == "June" || month == "September")
            {
                if (days <= 14)
                {
                    var studio = 75.20 * days;
                    var apartment = 68.70 * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                if (days > 14)
                {
                    var studioDiscount = 75.20 * 0.20;
                    var studioPrice = (75.20 - studioDiscount) * days;

                    var apartmentDiscount = 68.70 * 0.10;
                    var apartmentPrice = (68.70 - apartmentDiscount) * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            if (month == "July" || month == "August")
            {
                if (days <= 14)
                {
                    var studio = 76 * days;
                    var apartment = 77 * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
                if (days > 14)
                {
                    var studio = 76 * days;
                    var apartmentDiscount = 77 * 0.10;
                    var apartmentPrice = (77 - apartmentDiscount) * days;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                    Console.WriteLine("Studio: {0:f2} lv.", studio);
                }
            }
        }

    }
}

            
   

