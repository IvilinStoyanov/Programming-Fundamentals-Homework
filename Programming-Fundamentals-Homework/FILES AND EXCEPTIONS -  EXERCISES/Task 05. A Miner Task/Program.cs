using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var input = File.ReadAllLines("input.txt");
            var resourceAndQuantity = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] == "stop" ||
                    input[i + 1] == "stop")
                {
                    break;
                }
                    var resourse = input[i];
                    int quantity = int.Parse(input[i + 1]);
                if (!resourceAndQuantity.ContainsKey(resourse))
                {
                    resourceAndQuantity[resourse] = 0;
                }
                resourceAndQuantity[resourse] += quantity;                     
                }
            foreach (var item in resourceAndQuantity)
            {
                var output = $"{item.Key} -> {item.Value}" + Environment.NewLine;
                File.WriteAllText("output.txt",
             output);
            }

        }
        }
    }

