using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText("input.txt");

            var chars = new char['z' - 'a' + 1];
            for (int i = 'a'; i <= 'z'; i++)
            {
                chars[i - 'a'] = (char)i;
            }
            for (int i = 0; i < lines.Length; i++)
            {
                var output = $"{lines[i]} -> {Array.IndexOf(chars, lines[i])}" + Environment.NewLine;

                File.WriteAllText("output.txt", output);
            }
        }
    }
}
