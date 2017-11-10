using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new char[] {'{', '}'}, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([A-Za-z]+)(.+)\1";

            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(text);
            int placeholderIndex = 0;
            foreach (Match match in matches)
            {
                if (placeholderIndex >= placeholders.Length)
                {
                    break;
                }
                else
                {
                    text = ReplaceFirst(text, match.Groups[2].Value, placeholders[placeholderIndex++]);
                }
            }
            Console.WriteLine(text);
        }

        static string ReplaceFirst(string text, string oldValue, string newValue)
        {
            string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

            string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

            return substringWithNewValue + text.Substring(substringWithOldValue.Length);         
        }
    }
}
