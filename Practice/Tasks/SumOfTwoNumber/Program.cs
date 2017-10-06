using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {

                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, magicNumber);
                        return;
                    }


                }
            }
            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    counter++;
                    if (i + j != magicNumber)
                    {
                        Console.WriteLine("{0} combinations - neither equals {1}", counter - 1, magicNumber);
                        return;
                    }
                }
            }
        }
    }

}


