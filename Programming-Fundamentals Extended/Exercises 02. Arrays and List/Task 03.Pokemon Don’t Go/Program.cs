using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var pokemons = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int removedPokomons = 0;
      
        int element;
        while(pokemons.Count > 0)
        {
            int indexValue = int.Parse(Console.ReadLine());
            if (indexValue < 0)
            {
                element = pokemons[0];
                pokemons[0] = pokemons[pokemons.Count - 1];
            }
            else if (indexValue >= pokemons.Count)
            {
                element = pokemons[pokemons.Count - 1];
                pokemons[pokemons.Count - 1] = pokemons[0];
            }
            else
            {
                element = pokemons[indexValue];
                pokemons.RemoveAt(indexValue);
            }
            removedPokomons += element;


            for (int i = 0; i < pokemons.Count; i++)
            {
                if(element >= pokemons[i])
                {
                    pokemons[i] += element;
                }
                else
                {
                    pokemons[i] -= element;
                }             
            }           
        }
        Console.WriteLine(removedPokomons);
    }
}
