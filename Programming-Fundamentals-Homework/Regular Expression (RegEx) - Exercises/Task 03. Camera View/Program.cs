using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine();
            var skipTakeNums = Regex.Split(nums, @"[^0-9]")
                .Select(int.Parse)
                .ToArray();
            var skip = skipTakeNums[0];
            var take = skipTakeNums[1];
            var text = Console.ReadLine();
            var pattern = $"(?<=\\|<.{{{skip}}})\\w{{1,{take}}}";
            var cameraView = Regex.Matches(text, pattern);
            var viewList = new List<string>();
            foreach (Match view in cameraView)
            {
                viewList.Add($"{view}");
            }
            Console.WriteLine(string.Join(", ", viewList));
        }
    }
}
