using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = "";
            double price = 0;
            // variables for price
           
            double winterVacation = season == "Winter" && typeOfGroup == "boys" || typeOfGroup == "girls"
                ? 9.60 : 10;
            double springVacation = season == "Spring" && typeOfGroup == "boys" || typeOfGroup == "girls"
                ? 7.20 : 9.50;
            double summerVacation = season == "Summer" && typeOfGroup == "boys" || typeOfGroup == "girls"
                ? 15 : 20;

         if (season == "Winter")
         {
                price = winterVacation * studentsCount * nights;
                if (studentsCount >= 50) price *= 0.50;
                if (studentsCount >= 20 && studentsCount < 50) price *= 0.85;
                if (studentsCount >= 10 && studentsCount < 20) price *= 0.95;
            }
         if (season == "Spring")
         {
                price = springVacation * studentsCount * nights;
                if (studentsCount >= 50) price *= 0.50;
                if (studentsCount >= 20 && studentsCount < 50) price *= 0.85;
                if (studentsCount >= 10 && studentsCount < 20) price *= 0.95;
            }
         if (season == "Summer")
         {
                price = summerVacation * studentsCount * nights;
                if (studentsCount >= 50) price *= 0.50;
                if (studentsCount >= 20 && studentsCount < 50) price *= 0.85;
                if (studentsCount >= 10 && studentsCount < 20) price *= 0.95;
            }
            if (season == "Winter" && typeOfGroup == "girls") sport = "Gymnastics";
            if (season == "Spring" && typeOfGroup == "girls") sport = "Athletics";
            if (season == "Summer" && typeOfGroup == "girls") sport = "Volleyball";

            if (season == "Winter" && typeOfGroup == "boys") sport = "Judo";
            if (season == "Spring" && typeOfGroup == "boys") sport = "Tennis";
            if (season == "Summer" && typeOfGroup == "boys") sport = "Football";

            if (season == "Winter" && typeOfGroup == "mixed") sport = "Ski";
            if (season == "Spring" && typeOfGroup == "mixed") sport = "Cycling";
            if (season == "Summer" && typeOfGroup == "mixed") sport = "Swimming";
           
            Console.WriteLine(sport +" {0:f2} lv.",  price);
        }
    }
}
