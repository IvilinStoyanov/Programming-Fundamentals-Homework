using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine().ToLower();
                switch (type)
                {
                    case "cheese":
                        totalAmount += 500;
                        break;
                    case "tomato sauce":
                        totalAmount += 150;
                        break;
                    case "salami":
                        totalAmount += 600;
                        break;
                    case "pepper":
                        totalAmount += 50;
                        break;
                }
            }
            Console.WriteLine("Total calories: {0}", totalAmount);
        }
    }
}
