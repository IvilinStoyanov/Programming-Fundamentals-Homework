using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            double EarnedMoney = double.Parse(Console.ReadLine());
            double theRateofTheDollar = double.Parse(Console.ReadLine());

            int Year = 365;
            double bonus = 2.5;

         
           
                double salary = Days * EarnedMoney;

                double totalSalary = (salary * 12) + (salary * bonus);

                double totalSalaryWithTax = ((totalSalary * 25) / 100);
                double salaryClear = totalSalary - totalSalaryWithTax;

                double salaryintoBGN = salaryClear * theRateofTheDollar;

                double averageProfit = salaryintoBGN / 365;
                Console.WriteLine("{0:f2}", averageProfit);
            }
          
        }
    }

