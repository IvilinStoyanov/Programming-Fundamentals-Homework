using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
             var banWords = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.None);

            string text = Console.ReadLine();

            foreach (var word in banWords)
            {
                while(text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
            
        }
    }
}
