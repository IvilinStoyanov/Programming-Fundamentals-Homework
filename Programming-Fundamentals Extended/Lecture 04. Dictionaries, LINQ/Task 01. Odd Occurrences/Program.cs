using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToArray();
            var dic = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (var i in input)
            {
                int count = 1;
                if (!dic.ContainsKey(i))
                {                  
                    dic.Add(i, count);                 
                }
                else
                {
                    dic[i] += count;
                }
            }
            foreach (var d in dic)
            {
                if(d.Value % 2 != 0)
                {
                    result.Add(d.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
