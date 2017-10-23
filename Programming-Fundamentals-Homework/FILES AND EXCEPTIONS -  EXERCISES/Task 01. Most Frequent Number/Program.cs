using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText("input1.txt").Split(' ').Select(int.Parse).ToArray();
            var countPerNum = new Dictionary<int, int>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (!countPerNum.ContainsKey(lines[i]))
                {
                    countPerNum.Add(lines[i], 0);
                }
                countPerNum[lines[i]]++;
            }

            int maxValue = countPerNum.Values.Max();
            var leftmostNJumber = countPerNum
                .Where(n => n.Value == maxValue)
                .Select(n => n.Key)
                .Take(1)
                .ToArray()
                .Sum();

            File.WriteAllText("output1.txt", leftmostNJumber.ToString());

        }

    }
}
