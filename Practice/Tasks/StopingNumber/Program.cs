using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            
            for (int first = m; first >= n; first--)
            {
                if (first % 2 == 0 && first % 3 == 0)
                {
                   if (s == first)
                    {
                        break;
                    }
                    Console.Write($"{first} ");
                }
                


            }
            
        }
    }
}
