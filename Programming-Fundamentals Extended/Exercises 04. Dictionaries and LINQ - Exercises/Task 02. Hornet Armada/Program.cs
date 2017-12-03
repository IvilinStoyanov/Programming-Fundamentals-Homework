using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            // data type of 2 dictionaries
            Dictionary<string, int> ActivityLegion =
                new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, long>> legionsWithSoldiers =
                new Dictionary<string, Dictionary<string, long>>();

            // input data
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var infoForLegionAndSoldiers = Console.ReadLine()
                      .Split(new char[] { '.', ' ', '>', '=', '-', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // LEGION - last activity and name in Index
                var lastActivity = int.Parse(infoForLegionAndSoldiers[0]);
                var legionName = infoForLegionAndSoldiers[1];
                // Soldier -  type and count in Index
                var soldierType = infoForLegionAndSoldiers[2];
                var soldierCount = int.Parse(infoForLegionAndSoldiers[3]);

                if (!legionsWithSoldiers.ContainsKey(legionName))
                {
                    ActivityLegion.Add(legionName, lastActivity);
                    legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }
                if (lastActivity > ActivityLegion[legionName])
                {
                    ActivityLegion[legionName] = lastActivity;
                }
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName].Add(soldierType, 0);
                }
                legionsWithSoldiers[legionName][soldierType] += soldierCount;
            }
            var lastCommand = Console.ReadLine()
                .Split('\\');

            var lastCommandCount = lastCommand.Length;
            if (lastCommandCount > 1)
            {
                var activityFromLastCommand = int.Parse(lastCommand[0]);
                var soldierType = lastCommand[1];

                foreach (var legion in legionsWithSoldiers
                    .Where(a => a.Value.ContainsKey(soldierType))
                    .OrderByDescending(soldier => soldier.Value[soldierType]))
                {
                    if (ActivityLegion[legion.Key] < activityFromLastCommand)
                    {
                        Console.WriteLine("{0} -> {1}", legion.Key, legionsWithSoldiers[legion.Key][soldierType]);
                    }
                }
            }
            else
            {
                var soldierTypeFromLastCommand = lastCommand[0];

                foreach (var legion in ActivityLegion.OrderByDescending(legion => legion.Value))
                {
                    if (legionsWithSoldiers[legion.Key].ContainsKey(soldierTypeFromLastCommand))
                    {
                        Console.WriteLine("{0} : {1}", legion.Value, legion.Key);
                    }
                }
            }
        }
    }
}