using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var sentenceReg = new Regex(@"^[A-Z][^\.]*\.$");
        var wordsReg = new Regex(@"[^\s,\.]+");

        var input = Console.ReadLine();
        while (!input.Equals("Worm Ipsum"))
        {
            var sentaceMatch = sentenceReg.Match(input);
            if(sentaceMatch.Success)
            {
                var wordMatches = wordsReg.Matches(input);
                foreach (Match word in wordMatches)
                {
                    var currentWord = word.Value;
                    if(currentWord.Length != currentWord.Distinct().Count())
                    {
                        var symbol = currentWord.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        var newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                        input = Regex.Replace(input, currentWord, newWord);
                    }
                }
                Console.WriteLine(input);
            }
            input = Console.ReadLine();
        }
    }
}

