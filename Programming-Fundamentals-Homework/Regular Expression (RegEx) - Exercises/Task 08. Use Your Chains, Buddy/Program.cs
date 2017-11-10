﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var codePattern = @"<p>(?<info>.*?)<\/p>";
            var codeMatches = Regex.Matches(inputString, codePattern)
                .Cast<Match>()
                .Select(m => m.Groups["info"].Value)
                .ToArray();
            var codedMessage = string.Join("", codeMatches);
            var replaceWithSpaces = @"[^a-z\d]+";
            codedMessage = Regex.Replace(codedMessage, replaceWithSpaces, " ");
            var decodedMessage = string.Empty;
            for (int i = 0; i < codedMessage.Length; i++)
            {
                if ('a' <= codedMessage[i] && codedMessage[i] <= 'm')
                {
                    decodedMessage += (char)(codedMessage[i] + 13);
                }
                else if ('n' <= codedMessage[i] && codedMessage[i] <= 'z')
                {
                    decodedMessage += (char)(codedMessage[i] - 13);
                }
                else
                {
                    decodedMessage += codedMessage[i];
                }
            }

            Console.WriteLine(decodedMessage.Trim());
        }
    }
}