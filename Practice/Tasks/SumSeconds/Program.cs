using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var total = a + b + c;
            if (total >= 0 && total <= 59)
            {
                int min = 0;
                int sec = total;
                Console.WriteLine("{0}" + ":" + "{1:D2}", min, sec);
            }
            else if (total >= 60 && total <= 119)
            {
                int min = 1;
                int sec = total - 60;
                Console.WriteLine("{0}" + ":" + "{1:D2}", min, sec);
            }
            else if (total >= 120 && total <= 179)
            {
                int min = 2;
                int sec = total - 120;
                Console.WriteLine("{0}" + ":" + "{1:D2}", min, sec);
            }
        }
    }
}