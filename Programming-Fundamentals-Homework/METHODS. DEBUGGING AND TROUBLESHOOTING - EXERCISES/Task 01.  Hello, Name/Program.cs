using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Hello__Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(PrintingName(name));
        }

        static string PrintingName(string name)
        {
            string greeting = $"Hello, {name}!";
            return greeting;
        }
    }
}
