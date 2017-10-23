using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            if (lines.Length == 1)
            {
                var output = 0;
                File.AppendAllText("output.txt", output.ToString());
                return;
            }
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                leftSum = lines
                    .Take(i)
                    .Sum();
                rightSum = lines
                    .Skip(i + 1)
                    .Sum();
                if (leftSum == rightSum)
                {
                    var output = i;
                    File.AppendAllText("output.txt", output.ToString());
                    return;
                }
            }
            var output1 = "no";
            File.WriteAllText("output.txt", output1);
        }



    }
}
