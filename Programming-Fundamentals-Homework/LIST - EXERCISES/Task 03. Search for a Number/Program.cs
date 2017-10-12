    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Task_03.Search_for_a_Number
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                int[] arr = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                numbers = numbers
                    .Take(arr[0])
                    .Skip(arr[1])
                    .ToList();
                Console.WriteLine(numbers.Contains(arr[2]) ?
                    "YES!" : "NO!");
            
            }
        }
    }
