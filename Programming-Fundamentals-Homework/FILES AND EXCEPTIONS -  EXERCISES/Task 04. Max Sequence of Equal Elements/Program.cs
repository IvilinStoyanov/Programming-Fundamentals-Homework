using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText("input.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startIndex = 0;
            int lenght = 1;
            int maxStartindex = 0;
            int maxLenth = 1;
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i] == lines[i - 1])
                {
                    lenght++;
                }
                else
                {
                    startIndex = i;
                    lenght = 1;
                }
                if (lenght > maxLenth)
                {
                    maxLenth = lenght;
                    maxStartindex = i - lenght + 1;
                }
            }

            int[] arrayOutput = lines
                .Skip(maxStartindex)
                .Take(maxLenth)
                .ToArray();

           var output =  string.Join(" ", arrayOutput);
            File.WriteAllText("output.txt", output);
            
        }
    }
}
