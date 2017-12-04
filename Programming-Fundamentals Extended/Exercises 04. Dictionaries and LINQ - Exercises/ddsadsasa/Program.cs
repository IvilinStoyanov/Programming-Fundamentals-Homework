using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _4_Task
{
    static void Main(string[] args)
    {

        var inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var squadsSotre = new Dictionary<string, HashSet<string>>();

        while (inputLine[0] != "Blaze it!")
        {
            var name = inputLine[0];

            var mate = inputLine[1];

            if (name != mate)
            {
                if (!squadsSotre.ContainsKey(name))
                {
                    squadsSotre[name] = new HashSet<string>();
                }
                squadsSotre[name].Add(mate);
            }

            inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        var sortetList = new Dictionary<string, int>();

        foreach (var nameMatePair in squadsSotre)
        {
            var mates = CheckTheRealMates(squadsSotre, nameMatePair);

            sortetList[nameMatePair.Key] = mates;
        }

        foreach (var creature in sortetList.OrderByDescending(n => n.Value))
        {
            Console.WriteLine($"{creature.Key} : {creature.Value}");
        }
    }

    private static int CheckTheRealMates(Dictionary<string, HashSet<string>> squadsSotre, KeyValuePair<string, HashSet<string>> nameMatePair)
    {
        var matesNumber = nameMatePair.Value.Count();

        var creature = nameMatePair.Key;

        foreach (var currentMate in nameMatePair.Value)
        {
            foreach (var pair in squadsSotre)
            {
                if ((pair.Key != creature) && pair.Key == currentMate && pair.Value.Contains(creature))
                {
                    matesNumber--;
                }
            }
        }
        return matesNumber;
    }
}