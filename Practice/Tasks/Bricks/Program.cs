using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cart = int.Parse(Console.ReadLine());

            double onCourse = cart * workers;                 
            double result = (bricks) / onCourse;
          
            Console.WriteLine(Math.Ceiling(result));
        }
    }
}
