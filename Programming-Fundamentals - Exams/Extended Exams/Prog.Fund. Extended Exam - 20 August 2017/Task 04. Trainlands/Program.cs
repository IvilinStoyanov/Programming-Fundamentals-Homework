using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            //{trainName}(string) -> {wagonName}(string) : {wagonPower}(int)
            Dictionary<string, Dictionary<string, long>> trains = new Dictionary<string, Dictionary<string, long>>();
            var data = Console.ReadLine();
            while (data != "It's Training Men!")
            {
                var dataSplit = data.Split(new[] { " -> ", " : ", " = " }, StringSplitOptions.RemoveEmptyEntries);
                var trainName = dataSplit[0];
                if (dataSplit.Length == 3)
                {
                    var wagonName = dataSplit[1];
                    long wagonPower = long.Parse(dataSplit[2]);
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }
                    trains[trainName].Add(wagonName, wagonPower);
                }
                else
                {
                    string otherTrainName = dataSplit[1];
                    if (data.Contains(" = "))
                    {
                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new Dictionary<string, long>();
                        }
                        trains[trainName].Clear();
                        foreach (var wagons in trains[otherTrainName])
                        {
                            trains[trainName].Add(wagons.Key, wagons.Value);
                        }
                    }
                    else
                    {
                        if (!trains.ContainsKey(trainName))
                        {
                            trains[trainName] = new Dictionary<string, long>();
                        }

                        foreach (var wagons in trains[otherTrainName])
                        {
                            trains[trainName].Add(wagons.Key, wagons.Value);
                        }

                        trains.Remove(otherTrainName);
                    }
                }
                data = Console.ReadLine();
            }
            foreach (var train in trains
                .OrderByDescending(t => t.Value.Values.Sum())
                .ThenBy(t => t.Value.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagon in trains[train.Key]
                    .OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}

