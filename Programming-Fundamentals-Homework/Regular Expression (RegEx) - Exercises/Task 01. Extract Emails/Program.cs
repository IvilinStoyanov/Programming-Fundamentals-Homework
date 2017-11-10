using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))[A-Za-z]+([0-9]+)?([\._-][A-z0-9]+)?@\w+-?\w+(?:\.\w+)+";
            string input = Console.ReadLine();

            var eMailMatches = Regex.Matches(input, pattern);
            foreach (Match email in eMailMatches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
