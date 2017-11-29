using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).OrderByDescending(x => x).ToArray();
            var avegareOfNumbers = numbers.Average();
            
            List<long> filteredNumbers = new List<long>();
            if (numbers.Length == 1 || numbers.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }
            if(avegareOfNumbers == 0)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > avegareOfNumbers && numbers.Length != 0)
                {
                    filteredNumbers.Add(numbers[i]);
                }
            }
            if (filteredNumbers.Count < 5)
            {
                for (int i = 0; i < filteredNumbers.Count; i++)
                {
                    Console.Write(filteredNumbers[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(filteredNumbers[i] + " ");
                }
            }                 
        }
    }
}
