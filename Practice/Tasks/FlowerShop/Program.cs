using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int magnolii = int.Parse(Console.ReadLine());
            int zuimbuili = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());

            double PriceOfGift = double.Parse(Console.ReadLine());

            // variables
            double magnoliiPrice = 3.25;
            double zuimbuiliPrice = 4;
            double roziPrice = 3.50;
            double kaktusiPrice = 8;

            // result 
            double moneyWithoutTax = (magnolii * magnoliiPrice) + (zuimbuili * zuimbuiliPrice) + (rozi * roziPrice) + (kaktusi * kaktusiPrice);
            double moneyWithTax = moneyWithoutTax * 0.05;
            double FinalMoney = moneyWithoutTax - moneyWithTax;
            double leftMoney = Math.Abs(FinalMoney - PriceOfGift);
            if (FinalMoney >= PriceOfGift)
            {
                Console.WriteLine("She is left with {0} leva." , Math.Truncate(leftMoney));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(leftMoney));
            }
        }
    }
}
