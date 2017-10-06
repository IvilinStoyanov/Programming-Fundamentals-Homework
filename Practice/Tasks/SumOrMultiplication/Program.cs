using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;
            int thirt = 0;
          int  counter = 0;


            for (first = 1; first <= 30; first++)
            {
                for ( second = 1; second <= 30; second++)
                {
                    for (thirt = 1; thirt <= 30; thirt++)
                    {                  
                      {
                            if (first < second && second < thirt &&
                                first + second + thirt == n)
                            {
                                Console.WriteLine($"{first} + {second} + {thirt} = {n}");
                                counter++;                              
                            }
                            if (first > second && second > thirt &&
                                first * second * thirt == n)
                            {
                                Console.WriteLine($"{first} * {second} * {thirt} = {n}");
                                counter++;
                            }                         
                        }
                    }
                }               
            }
            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }                                                           
    }
}

