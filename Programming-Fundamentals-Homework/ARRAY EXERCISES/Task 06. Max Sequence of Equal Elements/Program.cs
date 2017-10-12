using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            FindLongestSequence(numbers);
        }

        private static void FindLongestSequence(int[] array)
        {
            int start = 0;
            int counter = 1;

            int bestPosition = 0;
            int bestLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                    if (counter > bestLen)
                    {
                        bestLen = counter;
                        bestPosition = start;
                    }
                }
                else
                {
                    if (counter > bestLen)
                    {
                        bestPosition = start;
                        bestLen = counter;
                    }
                    start = i;
                    counter = 1;
                }

            }
            for (int i = bestPosition; i < bestPosition + bestLen; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }


    }
}

