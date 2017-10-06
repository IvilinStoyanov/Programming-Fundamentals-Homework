using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var work = 365 - n;
            var totalplaydays = work * 63 + n * 127;
            var totalMins = 30000 - totalplaydays;
            var hours = Math.Abs(totalMins / 60);
            var mins = Math.Abs(totalMins % 60);

            if (30000 < totalplaydays)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
            }
        }
    }
}