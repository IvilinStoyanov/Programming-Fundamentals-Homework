using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalFilteringTime = n * filterTime;
            long goodPictures = (long)(Math.Ceiling(n * filterFactor / 100d));
            long totalUploadTime = goodPictures * uploadTime;

            long totalTime = totalFilteringTime + totalUploadTime;

            TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                projectTime.Days,
                projectTime.Hours,
                projectTime.Minutes,
                projectTime.Seconds);
        }
    }
}
