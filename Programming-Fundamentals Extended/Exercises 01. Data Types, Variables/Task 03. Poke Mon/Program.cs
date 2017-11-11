using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); // N
            int distance = int.Parse(Console.ReadLine()); // M
            int exhaustionFactor = int.Parse(Console.ReadLine()); // Y
            int count = 0;

            int halfPower = pokePower / 2;          
            while (pokePower >= distance )
            {
                
                pokePower -= distance;
                if (pokePower == halfPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                    
                }              
                count++;
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
            
        }
    }
}
