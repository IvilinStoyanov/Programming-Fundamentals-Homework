using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var textInput = Console.ReadLine();
            var result = new string(textInput.Reverse().ToArray());     
            Console.WriteLine(result);
        }
    }
}
