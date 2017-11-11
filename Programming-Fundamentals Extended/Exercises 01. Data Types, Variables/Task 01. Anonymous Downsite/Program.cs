using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Task_01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var sites =new List<string>();
            var count = int.Parse(Console.ReadLine());
            var securityKey = long.Parse(Console.ReadLine());
            decimal totalMoneyLoss = 0;
            BigInteger SK = 0;
            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split(' '); // {siteName} {siteVisits} {siteCommercialPricePerVisit}
                var siteName = data[0];
                var siteVisits = decimal.Parse(data[1]);
                var siteCommercialPricePerVisit = decimal.Parse(data[2]);
                sites.Add(siteName);
                totalMoneyLoss += (siteVisits * siteCommercialPricePerVisit);
                
                SK = BigInteger.Pow(new BigInteger(securityKey), count);                             
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalMoneyLoss:F20}");
            Console.WriteLine($"Security Token: {SK}");
        }
    }
}
