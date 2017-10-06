using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input array
            int[] numbers = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            // rotation times
            int k = int.Parse(Console.ReadLine());

            int[] rotated = new int[numbers.Length];
            // rotating k times the array
            for (int i = 0; i < k; i++)
            {
                int temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];

                }
                numbers[0] = temp;
                // sum array
                for (int l = 0; l < numbers.Length; l++)
                {
                    rotated[l] += numbers[l];
                }
            }
            // printing
            Console.WriteLine(string.Join(" ", rotated));
        }
    }
}

    

