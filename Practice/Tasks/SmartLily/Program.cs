using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfMachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int m = 0;
            int n = 0;
            double totalMoney = 0;
            double change = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                    {
                    m += 10;
                    money += m;
                    n++;
                      }
                else
                {
                    toys++;
                }
            }
            totalMoney = (toys * pricePerToy) + (money - n);
            if (priceOfMachine <= totalMoney)
            {
                change = totalMoney - priceOfMachine;
                Console.WriteLine("Yes! {0:F2}", change);
            }
            else
            {
                change = priceOfMachine - totalMoney;
                Console.WriteLine("No! {0:F2}", change);
            }

        }
    }
}
