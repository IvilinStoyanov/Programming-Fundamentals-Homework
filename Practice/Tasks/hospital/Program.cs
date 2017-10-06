using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int days = 0;
            int treated = 0;
            int untreated = 0;
            for (int i = 0; i < period; i++)
            {
                days++;
                if (days % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }
                }               
                int patiance = int.Parse(Console.ReadLine());
                if (patiance <= doctors)
                { treated += patiance; }
                else
                { treated += doctors; } 
                if (doctors < patiance)
                {
                    untreated += Math.Abs(patiance - doctors);

                }                          
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }        
}
