using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            long amountOfPictures = long.Parse(Console.ReadLine());
            long amountOfTimeForAllPictues = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long amountOfTimeNeededForFilteredPictues = long.Parse(Console.ReadLine());
            //filtered picture
            double filteredPictues = Math.Ceiling(amountOfPictures * (filterFactor / 100.0));
            //time for ALL and FILTERED
            long timeForAllPictues = (amountOfPictures * amountOfTimeForAllPictues); // ALL
            double timeForFilteredPictues = (double)filteredPictues * amountOfTimeNeededForFilteredPictues; // filtered 

            long totalTime = (long)(timeForAllPictues + timeForFilteredPictues);
                               
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
            Console.WriteLine(result);
        }
    }
}
