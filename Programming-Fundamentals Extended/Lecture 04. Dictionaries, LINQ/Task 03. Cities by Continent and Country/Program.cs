using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var town = input[2];
                // adding info to dictionary 
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(town);
            }           
            foreach (var con in continents)
            {
                var countryAndTowns = con.Value;
                Console.WriteLine($"{con.Key}:");
                foreach (var countryAndTown in countryAndTowns)
                {
                    Console.WriteLine($"{countryAndTown.Key} -> {string.Join(", ", countryAndTown.Value)}");
                }
            }
        }
    }
}
