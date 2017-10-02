using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int current = 0; bool result = false;
            for (int ch = 1; ch <= n; ch++)
            {
                current = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{current} -> {result}");
                sum = 0;
                ch = current;
            }

        }
    }
}
