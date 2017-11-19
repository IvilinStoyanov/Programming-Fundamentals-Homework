using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            input.Sort();
            input.Reverse();
            for (int i = 0; i < n; i++)
            {
                Console.Write(input[i] + " ");
            }
            
        }
    }
}
