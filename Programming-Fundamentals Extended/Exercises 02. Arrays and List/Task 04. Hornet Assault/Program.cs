using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var beehives = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        var hornet = Console.ReadLine()
            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        bool IsAlive = false;

        for (int i = 0; i < beehives.Count; i++)
        {
            if(hornet.Count == 0)
            {
                break;
            }
           var hornetPower = hornet.Sum();
            if(beehives[i] >= hornetPower)
            {
                hornet.RemoveAt(0);
              
            }           
                beehives[i] -= hornetPower;           
        }
        var alive = new List<int>();
        foreach (var bee in beehives)
        {
            if(bee > 0)
            {
                alive.Add(bee);
                IsAlive = true;
            }
        }
        if(IsAlive)
        {
            Console.WriteLine(string.Join(" " , alive));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornet));
        }
    }
}

