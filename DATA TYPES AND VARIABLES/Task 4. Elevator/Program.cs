using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            // solution 
            int courseNeeded = (int)Math.Ceiling((double)people / elevatorCapacity);
            Console.WriteLine(courseNeeded);

        }
    }
}
