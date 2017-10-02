using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());
            int number03 = int.Parse(Console.ReadLine());
            int number04 = int.Parse(Console.ReadLine());
            // solution
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}" , number01 , number02, number03, number04);
        }
    }
}
