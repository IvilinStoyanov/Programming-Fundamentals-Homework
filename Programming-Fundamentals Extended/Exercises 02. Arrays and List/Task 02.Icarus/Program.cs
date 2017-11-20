using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var planes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int startingPosition = int.Parse(Console.ReadLine());
        int initialDamage = 1;

        var commands = Console.ReadLine();
        while (commands != "Supernova")
        {
            var commandsArgs = commands.Split(' ');
            var postion = commandsArgs[0];
            int steps = int.Parse(commandsArgs[1]);
            if (postion == "left")
            {
                while (steps > 0)
                {
                    startingPosition--;
                    if (startingPosition < 0)
                    {                    
                        startingPosition = planes.Length - 1;
                        initialDamage++;
                    }
                    planes[startingPosition] -= initialDamage;                  
                    steps--;
                }
            }
            if (postion == "right")
            {
                while (steps > 0)
                {
                    startingPosition++;
                    if (startingPosition > planes.Length - 1)
                    {                      
                        startingPosition = 0;
                        initialDamage++;
                    }
                    planes[startingPosition] -= initialDamage;                
                    steps--;
                }
            }
            commands = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" " , planes));

    }
}

