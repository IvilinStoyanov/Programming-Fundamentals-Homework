using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            if (3 <= h & 3 <= w & w <= 100 & h <= 100)
            {
                int sizeH =(int)(h / 1.2);
               
                int sizeW =(int)((w - 1) / 0.7);
               
                var resuzlt = (sizeH * sizeW) - 3;
                Console.WriteLine(resuzlt);
            }
        }
    }
}
