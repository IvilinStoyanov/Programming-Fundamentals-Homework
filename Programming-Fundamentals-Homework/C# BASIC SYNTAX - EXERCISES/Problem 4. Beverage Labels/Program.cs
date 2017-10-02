using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string nameOfProduct = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());
            //variables 
            energyContent /= 100;
            sugarContent /= 100;
            // solution
            Console.WriteLine("{0}ml {1}:" , volume , nameOfProduct);
            Console.WriteLine("{0}kcal, {1}g sugars" , volume * energyContent, volume * sugarContent);

        }
    }
}
