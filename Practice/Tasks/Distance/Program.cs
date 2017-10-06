using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedinKm = int.Parse(Console.ReadLine());
            double firstTimeinMinutes = int.Parse(Console.ReadLine());
            double secondTimeinMinutes = int.Parse(Console.ReadLine());
            double thirtTimeinMinutes = int.Parse(Console.ReadLine());


            double normalSpeed = speedinKm * (firstTimeinMinutes / 60);
            double accerlerationSpeedMin = speedinKm + (speedinKm * 0.1);
            double slowingSpeedMin = accerlerationSpeedMin - (accerlerationSpeedMin * 0.05);

            double accerlerationSpeedHours = accerlerationSpeedMin * (secondTimeinMinutes / 60);
            double slowingSpeeHours = slowingSpeedMin * (thirtTimeinMinutes / 60);

            double allSpeed = normalSpeed + accerlerationSpeedHours + slowingSpeeHours;

            Console.WriteLine("{0:f2}" , allSpeed);
        }
    }
}
