using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number01 = byte.Parse(Console.ReadLine());
            uint number02 = uint.Parse(Console.ReadLine());
            int number03 = int.Parse(Console.ReadLine());
            long number04 = long.Parse(Console.ReadLine());
            Console.WriteLine($"{number01} {number02} {number03} {number04}");
        }
    }
}
