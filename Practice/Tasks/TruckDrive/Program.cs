using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            string season = Console.ReadLine();
            double kilometersPerMonth = double.Parse(Console.ReadLine());

            // solution
            if (kilometersPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double money = (kilometersPerMonth * 0.75 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
                if (season == "Summer")
                {
                    double money = (kilometersPerMonth * 0.90 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
                if (season == "Winter")
                {
                    double money = (kilometersPerMonth * 1.05 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
            }
            if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    double money = (kilometersPerMonth * 0.95 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
                if (season == "Summer")
                {
                    double money = (kilometersPerMonth * 1.10 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
                if (season == "Winter")
                {
                    double money = (kilometersPerMonth * 1.25 * 4) * 0.90;
                    Console.WriteLine("{0:f2}", money);
                }
            }
            if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
            {
                double money = (kilometersPerMonth * 1.45 * 4) * 0.90;
                Console.WriteLine("{0:f2}", money);
            }
            
        }
    
        
    }
}
