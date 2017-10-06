using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string('*', i));

                for (int mid = 1; mid < i; mid++)
                {
                    Console.WriteLine("*" + new string(' ', mid) + "*");
                }
            }
        }
    }

}

