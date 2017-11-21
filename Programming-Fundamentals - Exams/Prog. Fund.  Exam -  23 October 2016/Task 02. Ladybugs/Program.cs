using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int arrLength = int.Parse(Console.ReadLine());
            int[] ladybugs = new int[arrLength];

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandArgs = Console.ReadLine().Split();

            foreach (var index in indexes)
            {
                if (index >= 0 && index < arrLength)
                {
                    ladybugs[index] = 1;
                }
            }

            while (!commandArgs[0].Equals("end"))
            {
                long ladyBugsIndex = long.Parse(commandArgs[0]);
                long flyLenght = long.Parse(commandArgs[2]);

                if (ladyBugsIndex < 0 || ladyBugsIndex >= arrLength)
                {
                    commandArgs = Console.ReadLine().Split();
                    continue;
                }

                if (ladybugs[ladyBugsIndex] == 0)
                {
                    commandArgs = Console.ReadLine().Split();
                    continue;
                }

                if (commandArgs[1].Equals("right"))
                {
                    if (ladyBugsIndex + flyLenght >= arrLength || ladyBugsIndex + flyLenght < 0)
                    {
                        ladybugs[ladyBugsIndex] = 0;
                        commandArgs = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        long flyDistance = ladyBugsIndex + flyLenght;
                        ladybugs[ladyBugsIndex] = 0;
                        while (ladyBugsIndex < arrLength && ladyBugsIndex >= 0 && flyDistance < arrLength && flyDistance >= 0)
                        {
                            if (ladybugs[flyDistance] == 0)
                            {
                                ladybugs[flyDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyDistance += flyLenght;
                            }
                        }
                    }
                }
                else if (commandArgs[1].Equals("left"))
                {
                    if (ladyBugsIndex - flyLenght >= arrLength || ladyBugsIndex - flyLenght < 0)
                    {
                        ladybugs[ladyBugsIndex] = 0;
                        commandArgs = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        ladybugs[ladyBugsIndex] = 0;
                        long flyDistance = ladyBugsIndex - flyLenght;

                        while (ladyBugsIndex < arrLength && ladyBugsIndex >= 0 && flyDistance < arrLength && flyDistance >= 0)
                        {
                            if (ladybugs[flyDistance] == 0)
                            {
                                ladybugs[flyDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyDistance -= flyLenght;
                            }
                        }
                    }
                }

                commandArgs = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladybugs));


        }
    }
}