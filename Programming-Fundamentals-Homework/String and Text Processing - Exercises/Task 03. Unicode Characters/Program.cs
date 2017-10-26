using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var uniCode = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                var code = $"{(int)text[i]:X4}".ToLower();
                uniCode += $"\\u{code}";
            }

            Console.WriteLine(uniCode);

        }
    }
}
