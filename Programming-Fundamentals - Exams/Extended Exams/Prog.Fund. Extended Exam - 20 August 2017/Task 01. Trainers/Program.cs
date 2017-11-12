using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()                                  // 90/100 Cuz of the team names.
    {
        int count = int.Parse(Console.ReadLine());
        // store variables data
       
        var result = new SortedDictionary<string, decimal>();
        
        for (int i = 0; i < count; i++)
        {
            // input data
            long distanceInMeters = long.Parse(Console.ReadLine()) * 1600;
            decimal cargoInKilograms = decimal.Parse(Console.ReadLine()) * 1000;
            string teamName = Console.ReadLine();
            // converting data
            decimal cargoIncome = 1.5m * cargoInKilograms;
            decimal fuelConsumption = 0.7m * distanceInMeters * 2.5m;

            decimal participantEarnedMoney = cargoIncome - fuelConsumption;
            if (!result.ContainsKey(teamName))
            {
                result.Add(teamName,new decimal());                       
            }
            if (result.ContainsKey(teamName))
            {
                result[teamName] += participantEarnedMoney;
            }

        }
        var winner = result.OrderByDescending(x => x.Value).FirstOrDefault();
       
        Console.WriteLine($"The {winner.Key} Trainers win with ${winner.Value:F3}.");
    }
}

