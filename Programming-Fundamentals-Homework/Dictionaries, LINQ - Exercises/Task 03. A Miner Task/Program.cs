using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceAndQuantity = new Dictionary<string, int>();
            var resourse = Console.ReadLine();

            while (resourse != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (!resourceAndQuantity.ContainsKey(resourse)) 
                    {
                    resourceAndQuantity[resourse] = 0;
                    }
                resourceAndQuantity[resourse] += quantity;
                resourse = Console.ReadLine();
            }
           
            foreach (var item in resourceAndQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
