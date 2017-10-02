using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            // solution 
            Console.WriteLine("Name: {0}", name);
            // health
            Console.WriteLine("Health: " + "|" + new string('|' , currentHealth) + new string('.', maximumHealth - currentHealth) + "|");
            // energy
            Console.WriteLine("Energy: " + "|" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + "|");


        }
    }
}
