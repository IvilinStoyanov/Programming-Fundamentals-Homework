using System;
class Battles
{
    static void Main()
    {
        int firstPlayerPokemons = int.Parse(Console.ReadLine());
        int secondPlayerPokemons = int.Parse(Console.ReadLine());
        int maxBattles = int.Parse(Console.ReadLine());
        int battlesCount = 0;
        for (int first = 1; first <= firstPlayerPokemons; first++)
        {
            for (int second = 1; second <= secondPlayerPokemons; second++)
            {
                if (battlesCount == maxBattles)
                {
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.Write("({0} <-> {1}) ", first, second);
                }
                battlesCount++;
            }
        }
        Console.WriteLine();
    }
}