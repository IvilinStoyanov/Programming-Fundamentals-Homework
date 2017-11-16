using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var spiesData = new Dictionary<string, Dictionary<string, int>>();
            var data = Console.ReadLine();
            while(data != "quit")
            {
                var dataSplit = data.Split(new char[] { ' ', '>', '-' }, StringSplitOptions.RemoveEmptyEntries);
                var countryName = dataSplit[0];
                var spiesName = dataSplit[1];
                var daysInService = int.Parse(dataSplit[2]);

                if(!spiesData.ContainsKey(countryName))
                {
                    spiesData.Add(countryName, new Dictionary<string, int>());
                }
                if(!spiesData[countryName].ContainsKey(spiesName))
                {
                    spiesData[countryName].Add(spiesName, new int());
                    spiesData[countryName][spiesName] = daysInService;
                }
                if (spiesData[countryName].ContainsKey(spiesName))
                {                   
                    spiesData[countryName][spiesName] = daysInService;
                }
                data = Console.ReadLine();
            }
            foreach (var country in spiesData.OrderByDescending(s => s.Value.Count))
            {
                Console.WriteLine("Country: " + country.Key);
                foreach (var spies in country.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"**{spies.Key} : {spies.Value}");                  
                }
            }
        }
    }
}
