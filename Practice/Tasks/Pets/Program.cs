using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            // variables

            double dogFood_Kg = double.Parse(Console.ReadLine());
            double catFood_Kg =  double.Parse(Console.ReadLine());
            double turtleFood_Grams = double.Parse(Console.ReadLine());

            // resulst
            double DogFoodNeeded = dogFood_Kg * days;
            double CatFoodNeeded = catFood_Kg * days;
            double turtleFoodNeeded = (turtleFood_Grams * days) / 1000;

            double allFood = DogFoodNeeded + CatFoodNeeded + turtleFoodNeeded;
            double FinalFood = Math.Abs(allFood - foodLeft);
            if (foodLeft >= allFood)
            {
                Console.WriteLine("{0} kilos of food left." , Math.Truncate(FinalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(FinalFood));
            }

        }
    }
}
