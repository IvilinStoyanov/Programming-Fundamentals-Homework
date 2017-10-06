using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs 
            int NumbersOfAdultPeople = int.Parse(Console.ReadLine());
            int NumbersOfStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            //variables for adults 
            double TrainForAdults = 24.99;
            double BusForAdults = 32.50;
            double ShipForAdults = 42.99;
            double PlaneForAdults = 70.00;

            //variables for students 
            double TrainForStudents = 14.99;
            double BusForStudents = 28.50;
            double ShipForStudents = 39.99;
            double PlaneForStudents = 50.00;

            //others variables
            double CostForOneNight = 82.99;

            //results
            if (transport == "train")
            {
                if (NumbersOfAdultPeople + NumbersOfStudents >= 50)
                {
                    double ticketAdult = TrainForAdults - (TrainForAdults * 0.50);
                    double ticketStudent = TrainForStudents - (TrainForStudents * 0.50);
                    double CostOfTheTransportBeta = (NumbersOfAdultPeople * ticketAdult) + (NumbersOfStudents * ticketStudent);
                    double CostofTheTransport = CostOfTheTransportBeta * 2;
                    double HotelPrice = nights * CostForOneNight;
                    double comision = (HotelPrice + CostofTheTransport) * 0.10;
                    double finalCost = HotelPrice + CostofTheTransport + comision;
                    Console.WriteLine("{0:f2}", finalCost);

                }
                else
                {
                    double CostOfTheTransportBeta = ((NumbersOfAdultPeople * TrainForAdults) + (NumbersOfStudents * TrainForStudents)) * 2;
                    
                    double HotelPrice = nights * CostForOneNight;
                    double comision = (HotelPrice + CostOfTheTransportBeta) * 0.10;
                    double finalCost = HotelPrice + CostOfTheTransportBeta + comision;
                    Console.WriteLine("{0:f2}", finalCost);
                }

            }
            if (transport == "airplane")
            {
                double CostOfTheTransportBeta = (NumbersOfAdultPeople * PlaneForAdults) + (NumbersOfStudents * PlaneForStudents);
                double CostofTheTransport = CostOfTheTransportBeta * 2;
                double HotelPrice = nights * CostForOneNight;           
                double comision = (HotelPrice + CostofTheTransport) * 0.10;              
                double finalCost = HotelPrice + CostofTheTransport + comision;
                Console.WriteLine("{0:f2}", finalCost);
            }
            if (transport == "bus")
            {
                double CostOfTheTransportBeta = (NumbersOfAdultPeople * BusForAdults) + (NumbersOfStudents * BusForStudents);
                double CostofTheTransport = CostOfTheTransportBeta * 2;
                double HotelPrice = nights * CostForOneNight;
                double comision = (HotelPrice + CostofTheTransport) * 0.10;
                double finalCost = HotelPrice + CostofTheTransport + comision;
                Console.WriteLine("{0:f2}", finalCost);
            }
            if (transport == "boat")
            {
                double CostOfTheTransportBeta = (NumbersOfAdultPeople * ShipForAdults) + (NumbersOfStudents * ShipForStudents);
                double CostofTheTransport = CostOfTheTransportBeta * 2;
                double HotelPrice = nights * CostForOneNight;
                double comision = (HotelPrice + CostofTheTransport) * 0.10;
                double finalCost = HotelPrice + CostofTheTransport + comision;
                Console.WriteLine("{0:f2}", finalCost);
            }






        }
    }
}
