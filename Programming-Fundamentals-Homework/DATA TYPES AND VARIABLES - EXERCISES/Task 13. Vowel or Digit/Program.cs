using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine().ToLower();
            int num = 0;
            if (int.TryParse(userInput, out num))
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("vowel");
                        break;
                    case "e":
                        Console.WriteLine("vowel");
                        break;
                    case "i":
                        Console.WriteLine("vowel");
                        break;
                    case "o":
                        Console.WriteLine("vowel");
                        break;
                    case "u":
                        Console.WriteLine("vowel");
                        break;
                    case "y":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
