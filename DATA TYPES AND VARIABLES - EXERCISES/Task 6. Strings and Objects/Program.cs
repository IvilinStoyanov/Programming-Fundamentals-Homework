using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object concatenatedStrings = firstWord + " " + secondWord;
            string result = concatenatedStrings.ToString();
            Console.WriteLine(result);
        }
    }
}
