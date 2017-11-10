using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double securityKey = double.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            double securityToken = 0;
          
            List<string> websites = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                //{siteName} {siteVisits} {siteCommercialPricePerVisit}              
                var siteName = data[0];
                long siteVisits = long.Parse(data[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(data[2]);
                //formula: siteVisits * siteCommercialPricePerVisit
                totalLoss += siteVisits * siteCommercialPricePerVisit;
                securityToken = Math.Pow(securityKey, n);        
                websites.Add(siteName);
                
            }
            foreach (var web in websites)
            {
                Console.WriteLine(web);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
