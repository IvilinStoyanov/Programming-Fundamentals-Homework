using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePlusFiveDays
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs 
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            // variables - days of months
            int daysInMonth = 31;
            if (m == 2)
            {
                daysInMonth = 28;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                daysInMonth = 30;
            }
            d += 5;
            if (d > daysInMonth)
            {
                d -= daysInMonth;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }
            Console.WriteLine("{0}.{1:D2}" , d , m);

        }
    }
}
