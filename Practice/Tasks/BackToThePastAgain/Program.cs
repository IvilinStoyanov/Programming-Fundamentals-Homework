using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePastAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            double legacy = double.Parse(Console.ReadLine());
            int ReturningAge = int.Parse(Console.ReadLine());
            int age = 18;
            int money = 0;
            for (int i = 1800; i <= ReturningAge; i++)
            {

                if (i % 2 == 0)
                {
                    money += 12000;
                }
                else
                {
                    money += 12000 + (age * 50);
                }
              
                age++;
            }
            double left =legacy - money;
            if (left >= 0)
                {
                    Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", left);
                }
                else
                {
                    Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(left));
                }         
        }
    }
}
