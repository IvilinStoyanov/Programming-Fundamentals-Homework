using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
          
            int count = 1;
            int maxcount = 1;
            int number = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        count++;
                        if (count > maxcount)
                        {
                            maxcount = count;
                            number = numbers[i];
                        }
                    }
                    else
                    {
                        count = 1;
                    }                                   
                }
            }
            if(maxcount == 1)
            {
                number = numbers[0];
            }
            for (int i = 0; i < maxcount; i++)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }
    }
}
