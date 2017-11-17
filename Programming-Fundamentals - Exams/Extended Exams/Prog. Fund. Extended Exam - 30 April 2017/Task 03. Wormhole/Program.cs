using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var wormholes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 0;
        int currentWormhole = 0;
        for (int i = 0; i < wormholes.Length; i++)
        {
            if(wormholes[i] == 0)
            {
                counter++;
            }
            if(wormholes[i] != 0)
            {
                currentWormhole = wormholes[i];
                wormholes[i] = 0;
                i = currentWormhole;
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
