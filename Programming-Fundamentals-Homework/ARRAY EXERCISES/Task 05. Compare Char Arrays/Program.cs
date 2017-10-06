using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //input arrays 
            char[] arrayFirst = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] arraySecond = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            bool oneIsFirst = false;
            bool twoIsFirst = false;

            for (int i = 0; i < Math.Min(arrayFirst.Length, arraySecond.Length); i++)
            {
                if (arrayFirst[i] < arraySecond[i])
                {
                    oneIsFirst = true;
                    break;
                }
                else if (arrayFirst[i] > arraySecond[i])
                {
                    twoIsFirst = true;
                    break;
                }
            }
            if (oneIsFirst)
            {
                Console.WriteLine(String.Join("", arrayFirst));
                Console.WriteLine(String.Join("", arraySecond));
            }
            else if (twoIsFirst)
            {
                Console.WriteLine(String.Join("", arraySecond));
                Console.WriteLine(String.Join("", arrayFirst));
            }
            else
            {
                if (arrayFirst.Length > arraySecond.Length)
                {
                    Console.WriteLine(string.Join("", arraySecond));
                    Console.WriteLine(string.Join("", arrayFirst));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrayFirst));
                    Console.WriteLine(string.Join("", arraySecond));
                }
            }
        }
    }
}

