using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_01.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\<\[[^A-Za-z0-9]*\]\.{1})+(\.{1}\[[A-Za-z0-9]*\]\.{1})*$";
            List<string> validTrains = new List<string>();

            string input = Console.ReadLine();
            while (!input.Equals("Traincode!"))
            {             
                if(Regex.IsMatch(input , pattern))
                {
                    validTrains.Add(input);
                }
                input = Console.ReadLine();
            }
            foreach (var trains in validTrains)
            {
                Console.WriteLine(trains);
            }
        }
    }
}
