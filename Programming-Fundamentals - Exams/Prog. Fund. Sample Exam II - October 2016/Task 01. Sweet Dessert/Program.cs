using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        decimal amountOfCash = decimal.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        //price for every product
        decimal priceOfBananas = decimal.Parse(Console.ReadLine());
        decimal priceOfEggs = decimal.Parse(Console.ReadLine());
        decimal priceOfBerries = decimal.Parse(Console.ReadLine());
        // constant variables
        decimal minimumPartition = 6.0m;
        //solution
        int neededPartition = (int)Math.Ceiling(numberOfGuests / minimumPartition);

        decimal bananas = neededPartition * (2 * priceOfBananas);
        decimal eggs = neededPartition * (4 * priceOfEggs);
        decimal berries = neededPartition * (0.2m * priceOfBerries);
        // all sum of products
        decimal allSum = bananas + eggs + berries;
        decimal result = allSum - amountOfCash;
        if(amountOfCash >= allSum)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {allSum:F2}lv.");          
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {result:F2}lv more.");
        }

    }
}

