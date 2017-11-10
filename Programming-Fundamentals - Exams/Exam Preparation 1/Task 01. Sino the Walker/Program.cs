    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Task_01.Sino_the_Walker
    {
        class Program
        {
            static void Main(string[] args)
            {          
                    var timeFormat = "HH:mm:ss";
                    var timeString = Console.ReadLine();
                    var startTime = DateTime.ParseExact(
                        timeString, timeFormat, CultureInfo.InvariantCulture);
                    var stepsCount = long.Parse(Console.ReadLine());
                    var secondsPerStep = int.Parse(Console.ReadLine());
                    var travelTime = (stepsCount * secondsPerStep) % (3600 * 24);
                    var arriveTime = startTime.AddSeconds(travelTime);
                    Console.WriteLine($"Time Arrival: {arriveTime:HH:mm:ss}");
                }
            }
        }