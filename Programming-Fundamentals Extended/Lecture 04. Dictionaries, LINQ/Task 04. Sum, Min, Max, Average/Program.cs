using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int numberOfCounts = int.Parse(Console.ReadLine());
        List<int> numberSequance = new List<int>();
        for (int i = 0; i < numberOfCounts; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numberSequance.Add(number);
        }
        PrintingNumbersInfo(numberSequance);   
    }

    private static void PrintingNumbersInfo(List<int> numberSequance)
    {
        Console.WriteLine($"Sum = {numberSequance.Sum()}");
        Console.WriteLine($"Min = {numberSequance.Min()}");
        Console.WriteLine($"Max = {numberSequance.Max()}"); ;
        Console.WriteLine($"Average = {numberSequance.Average()}");
    }
}

