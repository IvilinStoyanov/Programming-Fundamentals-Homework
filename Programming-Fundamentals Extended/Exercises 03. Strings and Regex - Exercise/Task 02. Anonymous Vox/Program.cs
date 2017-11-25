using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_02.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.+)\1";
            string input = Console.ReadLine();
            var placeholder = Console.ReadLine().Split(new char[] {'{', '}'}, StringSplitOptions.RemoveEmptyEntries);

            Regex reg = new Regex(pattern);
            MatchCollection collection = reg.Matches(input);
            int placeholderIndex = 0;

            foreach (Match item in collection)
            {
                if(placeholderIndex >= placeholder.Length)
                {
                    break;
                }
                else
                {
                    input = Replace(input, item.Groups[2].Value, placeholder[placeholderIndex++]);
                }             
            }
            Console.WriteLine(input);
        }

        private static string Replace(string input, string oldValue, string newValue)
        {
            string old = input.Substring(0, input.IndexOf(oldValue) + oldValue.Length);
            string substringNewValue = old.Replace(oldValue, newValue);
            return substringNewValue + input.Substring(old.Length);            
        }
    }
}
