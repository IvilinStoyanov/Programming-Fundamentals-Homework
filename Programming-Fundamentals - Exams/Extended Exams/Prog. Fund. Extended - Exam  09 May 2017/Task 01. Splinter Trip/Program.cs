using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        /* info : 
     * consumes a lot of fuel - 25L per mile 
     *  Heavy winds need 1.5 times more fuel.
     *  the total fuel amount we put in needs to increase by 5%.
        */
        double tripDistanceInMiles = double.Parse(Console.ReadLine());
        double fuelTankCapacityInLiters = double.Parse(Console.ReadLine());
        double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

        double NonHeavyWindsConsumption = (tripDistanceInMiles - milesSpentInHeavyWinds) * 25;
        double HeavyWindsConsumption = milesSpentInHeavyWinds * (25 * 1.5);
        double FuelConsumption = NonHeavyWindsConsumption + HeavyWindsConsumption;
        double tolerance = FuelConsumption * 1.05;
        double remainingFuel = fuelTankCapacityInLiters - tolerance;
        double result = Math.Abs(remainingFuel);
        Console.WriteLine($"Fuel needed: {tolerance:F2}L");
        if(remainingFuel >= 0)
        {
            Console.WriteLine($"Enough with {result:F2}L to spare!");
        }
        else
        {
            Console.WriteLine($"We need {result:F2}L more fuel.");
        }
    }
}

