using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counts = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= max)
                    {
                        break;
                    }
                    else
                    {
                        sum += (i * j) * 3;
                    }
                    counts++;
                }
            }
            if (sum >= max)
            {
                Console.WriteLine($"{counts} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counts} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
