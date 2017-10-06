using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            FindSums(array);
        }

        private static void FindSums(long[] array)
        {
             bool hasIndex = false;
            for (int i = 0; i < array.Length; i++)
            {
                long leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                long rightSum = 0;
                for (int l = array.Length - 1; l > i; l--)
                {
                    rightSum += array[l];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasIndex = true;
                    return;
                }
            }
            if (hasIndex == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
        