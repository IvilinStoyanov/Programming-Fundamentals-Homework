namespace _01.Hornet_Wings
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // input
            int wingsFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            // default variables
            int commonRest = 5;
            int wingFlapsPerSeconds = 100;
            //solution
                    //distance
            var distance = (double)(wingsFlaps / 1000) * distanceInMeters;
            // time
            var allRestCounts = wingsFlaps / endurance;                 
            var timeForRestingInSeconds = allRestCounts * commonRest;
            var timeForTravel = wingsFlaps / wingFlapsPerSeconds;
            var timeResult = timeForRestingInSeconds + timeForTravel;
            // printing
            Console.WriteLine("{0:F2} m." , distance);
            Console.WriteLine($"{timeResult} s.");
        }
    }
}
