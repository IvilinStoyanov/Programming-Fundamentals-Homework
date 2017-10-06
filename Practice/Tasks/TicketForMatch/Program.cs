using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketForMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double vip = 499.99;
            double normal = 249.99;

            if (category == "VIP")
            {
                if (people >= 1 && people <= 4)
                {
                    var finalBugdet = budget - ((budget * 75) / 100);
                    var ticketforPpl = people * vip;
                    var result = Math.Abs(finalBugdet - ticketforPpl);                
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left." , result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva." , result);
                }
                if (people >= 5 && people <= 9)
                {
                    var finalBugdet = budget - ((budget * 60) / 100);
                    var ticketforPpl = people * vip;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 10 && people <= 24)
                {
                    var finalBugdet = budget - ((budget * 50) / 100);
                    var ticketforPpl = people * vip;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 25 && people <= 49)
                {
                    var finalBugdet = budget - ((budget * 40) / 100);
                    var ticketforPpl = people * vip;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 50 )
                {
                    var finalBugdet = budget - ((budget * 25) / 100);
                    var ticketforPpl = people * vip;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
            }
            if (category == "Normal")
            {
                if (people >= 1 && people <= 4)
                {
                    var finalBugdet = budget - ((budget * 75) / 100);
                    var ticketforPpl = people * normal;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                   if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 5 && people <= 9)
                {
                    var finalBugdet = budget - ((budget * 60) / 100);
                    var ticketforPpl = people * normal;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 10 && people <= 24)
                {
                    var finalBugdet = budget - ((budget * 50) / 100);
                    var ticketforPpl = people * normal;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 25 && people <= 49)
                {
                    var finalBugdet = budget - ((budget * 40) / 100);
                    var ticketforPpl = people * normal;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
                if (people >= 50)
                {
                    var finalBugdet = budget - ((budget * 25) / 100);
                    var ticketforPpl = people * normal;
                    var result = Math.Abs(finalBugdet - ticketforPpl);
                    if (finalBugdet > ticketforPpl) Console.WriteLine("Yes! You have {0:f2} leva left.", result);
                    else Console.WriteLine("Not enough money! You need {0:f2} leva.", result);
                }
            }

        }
    }
}
