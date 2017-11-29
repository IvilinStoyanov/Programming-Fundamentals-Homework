using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    { 
        List<decimal> coffe = new List<decimal>();
        int n = int.Parse(Console.ReadLine());
        decimal pricePerCoffe = 0;
        decimal all = 0;
        for (int i = 0; i < n; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            var date = Console.ReadLine().Split('/');
            var capsuleCount = int.Parse(Console.ReadLine());
            var year = int.Parse(date[2]);
            var month = int.Parse(date[1]);
            int dayInMount = DateTime.DaysInMonth(year, month);
            // formula
            pricePerCoffe = (dayInMount * capsuleCount) * pricePerCapsule;
            coffe.Add(pricePerCoffe);
            all += pricePerCoffe;
        }
        foreach (var c in coffe)
        {
            Console.WriteLine($"The price for the coffee is: ${c:F2}");
        }
        Console.WriteLine($"Total: ${all:F2}");


    }
}
