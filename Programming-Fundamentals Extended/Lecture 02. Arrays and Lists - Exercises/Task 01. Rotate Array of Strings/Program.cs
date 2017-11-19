using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var rotatedArray = new string[input.Length];

            for (int i = 0; i < input.Length - 1; i++)
            {
                rotatedArray[i + 1] = input[i];
            }
            var lastElement = input[rotatedArray.Length - 1];
            rotatedArray[0] = lastElement;
            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}





