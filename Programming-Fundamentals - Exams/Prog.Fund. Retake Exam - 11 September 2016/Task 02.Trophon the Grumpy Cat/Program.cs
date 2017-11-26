using System;
using System.Linq;

class Trophon
{
    static void Main()
    {
        long[] priceRatings = Console.ReadLine().Split().Select(long.Parse).ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        string priceRating = Console.ReadLine();
        string typeOfRating = Console.ReadLine();
        long leftDamage = 0;
        long rightDamage = 0;
        if (priceRating == "cheap")
        {
            if (typeOfRating == "positive")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] > 0 && priceRatings[i] < priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] > 0 && priceRatings[i] < priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
            else if (typeOfRating == "negative")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
            else if (typeOfRating == "all")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] < priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] < priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
        }
        else if (priceRating == "expensive")
        {
            if (typeOfRating == "positive")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
            else if (typeOfRating == "negative")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] < 0 && priceRatings[i] >= priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] < 0 && priceRatings[i] >= priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
            else if (typeOfRating == "all")
            {
                for (int i = 0; i < entryPoint; i++)
                {
                    if (priceRatings[i] >= priceRatings[entryPoint]) leftDamage += priceRatings[i];
                }
                for (int i = entryPoint + 1; i < priceRatings.Length; i++)
                {
                    if (priceRatings[i] >= priceRatings[entryPoint]) rightDamage += priceRatings[i];
                }
            }
        }

        if (leftDamage >= rightDamage)
        {
            Console.WriteLine($"Left - {leftDamage}");
        }
        else
        {
            Console.WriteLine($"Right - {rightDamage}");
        }

    }
}