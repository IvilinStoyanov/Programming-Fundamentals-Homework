using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricitySum = 0;
            double others = 0;
            double sumOther = 0;
            for (int i = 0; i < months; i++)
            {
                double bill = double.Parse(Console.ReadLine());
                   electricitySum += bill;

                others = (bill + 20 + 15) * 1.2;
                sumOther += others;

            }
            double sumAll = electricitySum + (20 * months) + (15 * months);
            double avergePerMonth = (electricitySum + (20 * months) + (15 * months) + sumOther) / months;         
            // results print
            Console.WriteLine("Electricity: {0:f2} lv" , electricitySum);
            Console.WriteLine("Water: {0:f2} lv", (20 * months));
            Console.WriteLine("Internet: {0:f2} lv", (15 * months));
            Console.WriteLine("Other: {0:f2} lv", sumOther);
            Console.WriteLine("Average: {0:f2} lv", avergePerMonth);
        }
    }
}
