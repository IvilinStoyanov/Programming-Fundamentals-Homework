using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numberToFind = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < input.Length; i++)
            {
                if(input.Contains(numberToFind))
                {
                    isFound = true;
                   
                }                                             
            }
            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
