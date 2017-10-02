using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sumAll = 0;
            for (int i = 0; i < n; i++)
            {
                sumAll += decimal.Parse(Console.ReadLine());               
            }
            Console.WriteLine(sumAll);
        }
    }
}
