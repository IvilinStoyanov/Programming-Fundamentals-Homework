using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int ab = GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            int biggestNumber = GetMax(ab, int.Parse(Console.ReadLine()));

            Console.WriteLine(biggestNumber);
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
