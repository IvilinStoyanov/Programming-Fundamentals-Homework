using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // {trainName} -> {wagonName} : {wagonPower}
        Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();
        var data = Console.ReadLine();
        while (data != "It's Training Men!")
        {
            var dataSplit = data.Split(new string[] { " -> ", " : ", " = " }, StringSplitOptions.RemoveEmptyEntries);
            // data after split 
            string trainName = dataSplit[0];
            // adding data to dictionary
            if (dataSplit.Length >= 3)
            {
                string wagonName = dataSplit[1];
                int wagonPower = int.Parse(dataSplit[2]);

                if (!trains.ContainsKey(trainName))
                {
                    trains.Add(trainName, new Dictionary<string, int>());
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
                        trains[trainName] = new Dictionary<string, int>();
                    }
                    trains[trainName].Clear();
                    foreach (var wagon in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                }
                else
                {
                    if (!trains.ContainsKey(trainName))
                    {
                        trains[trainName] = new Dictionary<string, int>();
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

