using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

           

            var playing = 365 - days;
            var realTimeofPlaying = (playing * 63) + (days * 127);

            var normFinal = 30000 - realTimeofPlaying;
            var normFinal_H = Math.Abs(normFinal / 60);
            var normFinal_m = Math.Abs(normFinal % 60);

            if (30000 < realTimeofPlaying)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play" , normFinal_H , normFinal_m);
            }
            else 
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", normFinal_H, normFinal_m);
            }
        }
    }
}
