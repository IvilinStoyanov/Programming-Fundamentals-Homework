using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var planes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startingPositionOfIndex = int.Parse(Console.ReadLine());

            var commands = Console.ReadLine();
            var initialDamage = 1;
            while (commands != "Supernova")
            {
                var commandsArgs = commands.Split(' ');
                var direction = commandsArgs[0];
                var steps = int.Parse(commandsArgs[1]);
                if (direction == "left")
                {                                                
                        while (steps > 0)
                        {
                            startingPositionOfIndex--;
                            if (startingPositionOfIndex < 0)
                            {
                                startingPositionOfIndex = planes.Length - 1;
                                initialDamage++;
                            }
                            planes[startingPositionOfIndex] -= initialDamage;
                            steps--;
                        }
                    }               
                if (direction == "right")
                {
                  while (steps > 0)
                    {
                        startingPositionOfIndex++;
                        if(startingPositionOfIndex > planes.Length - 1)
                        {
                            startingPositionOfIndex = 0;
                            initialDamage++;
                        }
                        planes[startingPositionOfIndex] -= initialDamage;
                        steps--;
                    }                    
                }
                commands = Console.ReadLine(); // read input again
            }
            Console.WriteLine(string.Join(" ", planes));          
        }
    }
}
