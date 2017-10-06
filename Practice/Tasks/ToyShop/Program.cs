using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs 
            double priceForTrip = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());
            // variables
            double puzzlePrice = 2.60;
            int talkingDollPrice = 3;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            int truckPrice = 2;
            double sumFromAllToys = 0;
            //solition
                 sumFromAllToys = 
                (puzzleCount * puzzlePrice) +
                (talkingDollCount * talkingDollPrice) +
                (teddyBearCount * teddyBearPrice) +
                (minionCount * minionPrice) +
                (trucksCount * truckPrice);
            int ToyCounts = puzzleCount + talkingDollCount + teddyBearCount +
                minionCount + trucksCount;
            if (ToyCounts >= 50)
            {
                sumFromAllToys *= 0.75;
            }
            sumFromAllToys *= 0.90;
            double leftMoney = Math.Abs(sumFromAllToys - priceForTrip);
            if (sumFromAllToys >= priceForTrip)
            {
                Console.WriteLine("Yes! {0:f2} lv left." , leftMoney);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed." , leftMoney);
            }

        }
    }
}
