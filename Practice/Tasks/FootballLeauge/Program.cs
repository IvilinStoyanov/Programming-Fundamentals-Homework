using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeauge
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadium = int.Parse(Console.ReadLine());
            double fans = int.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;
            for (int i = 0; i < fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                if (sector == 'A')
                {
                    a++;
                }
                if (sector == 'B')
                {
                    b++;
                }
                if (sector == 'V')
                {
                    v++;
                }
                if (sector == 'G')
                {
                    g++;
                }           
            }
            Console.WriteLine("{0:f2}%" , a / fans * 100);
            Console.WriteLine("{0:f2}%", b / fans * 100);
            Console.WriteLine("{0:f2}%", v / fans * 100);
            Console.WriteLine("{0:f2}%", g / fans * 100);
            Console.WriteLine("{0:f2}%", fans / stadium * 100);
        }
    }
}
