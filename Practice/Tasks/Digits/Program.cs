using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numCopy = n;
            var digit3 = numCopy % 10;
            numCopy /= 10;
            var digit2 = numCopy % 10;
            numCopy /= 10;
            var digit1 = numCopy % 10;
            for (int row = 0; row < digit1 + digit2; row++)
            {
                for (int col = 0; col < digit1 + digit3; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= digit1;
                        Console.Write("{0} ", n);
                    }
                   else if (n % 3 == 0)
                    {
                        n -= digit2;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n += digit3;
                        Console.Write("{0} ", n);
                    }                  
                }
                Console.WriteLine();
            }
        }
    }
}
