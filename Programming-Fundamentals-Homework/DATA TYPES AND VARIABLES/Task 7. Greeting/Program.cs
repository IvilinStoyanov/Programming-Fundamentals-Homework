using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            // solution
            Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
        }
    }
}
