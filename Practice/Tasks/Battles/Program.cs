using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int player01 = int.Parse(Console.ReadLine());
            int player02 = int.Parse(Console.ReadLine());
            int maxBattleCount = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= player01; i++)
            {
                for (int j = 1; j <= player02; j++)
                {
                    counter++;
                    Console.Write("({0} <-> {1}) " , i , j);
                    if (counter == maxBattleCount)
                    {
                        return;
                    }
                   
                }
            }

        }
    }
}
