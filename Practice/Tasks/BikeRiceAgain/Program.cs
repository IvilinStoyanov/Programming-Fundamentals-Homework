using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRiceAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs 
            int studentsCount = int.Parse(Console.ReadLine());
            int adultsCount = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();
            double tax = 0;
            // variables for price
            if (typeOfRace == "trail")
            {
                 tax = studentsCount * 5.50 + adultsCount * 7;
            }
            if (typeOfRace == "cross-country")
            {
                if (studentsCount + adultsCount >= 50)
                {
                    tax = (studentsCount * 8 + adultsCount * 9.50) * 0.75;
                }
                else
                {
                    tax = studentsCount * 8 + adultsCount * 9.50;
                }
            }
            if (typeOfRace == "downhill")
            {
                tax = studentsCount * 12.25 + adultsCount * 13.75;
            }
            if (typeOfRace == "road")
            {
                tax = studentsCount * 20 + adultsCount * 21.50;
            }
            double taxFinal = tax * 0.95;
            Console.WriteLine("{0:f2}" , taxFinal);
        }
    }
}
