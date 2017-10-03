using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintBody(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintBody(n);
            }         
            PrintHeader(n);
        }
    }
}
