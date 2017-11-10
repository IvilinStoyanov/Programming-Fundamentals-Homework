using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var sentencePattern = @"(^|(?<=\s))[A-Z][^.!?]*\W" + word + @"\W.*?(?=[\.\?\!])";
            var sentencesMatches = Regex.Matches(text, sentencePattern);
            foreach (Match sentence in sentencesMatches)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
