using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsBikers = int.Parse(Console.ReadLine());
            int seniorsBikers = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            //variables for junuior 
            double juniorTrail = 5.50;
            double juniorCross = 8;
            double juniorDownhill = 12.25;
            double juniorRoad = 20;

            // variables for senior
            double seniorTrail = 7;
            double seniorCross = 9.50;
            double seniorDownhill = 13.75;
            double seniorRoad = 21.50;

            //result 

            if (trace == "trail")
            {
                double Sum = (juniorsBikers * juniorTrail) + (seniorsBikers * seniorTrail);
                double SumTax = Sum * 0.05;
                double FinalSum = Sum - SumTax;

                Console.WriteLine("{0:f2}" , FinalSum);
            }
            if (trace == "cross-country")
            {
                if (juniorsBikers + seniorsBikers >= 50)
                {
                  double ticketJ = juniorCross - (juniorCross * 0.25);
                    double ticketS = seniorCross - (seniorCross * 0.25);

                    double Sum = (juniorsBikers * ticketJ) + (seniorsBikers * ticketS);
                    double SumTax = Sum * 0.05;
                    double FinalSum = Sum - SumTax;

                    Console.WriteLine("{0:f2}", FinalSum);
                }
                else
                {
                    double Sum = (juniorsBikers * juniorCross) + (seniorsBikers * seniorCross);
                    double SumTax = Sum * 0.05;
                    double FinalSum = Sum - SumTax;

                    Console.WriteLine("{0:f2}", FinalSum);
                }
            }

            if (trace == "downhill")
            {
                double Sum = (juniorsBikers * juniorDownhill) + (seniorsBikers * seniorDownhill);
                double SumTax = Sum * 0.05;
                double FinalSum = Sum - SumTax;

                Console.WriteLine("{0:f2}", FinalSum);
            }

            if (trace == "road")
            {
                double Sum = (juniorsBikers * juniorRoad) + (seniorsBikers * seniorRoad);
                double SumTax = Sum * 0.05;
                double FinalSum = Sum - SumTax;

                Console.WriteLine("{0:f2}", FinalSum);
            }


        }
    }
}
