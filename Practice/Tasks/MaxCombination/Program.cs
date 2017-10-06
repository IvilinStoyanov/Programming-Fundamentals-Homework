using System;
class Battles
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int SecondNumber = int.Parse(Console.ReadLine());
        int maxCombination = int.Parse(Console.ReadLine());
        int Counter = 0;
        for (int i = firstNumber; i <= SecondNumber; i++)
        {
            for (int j = firstNumber; j <= SecondNumber;j++)
            {
                if (Counter == maxCombination)
                {
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.Write("<{0}-{1}>", i, j);
                }
                Counter++;
            }
        }
        Console.WriteLine();
    }
}