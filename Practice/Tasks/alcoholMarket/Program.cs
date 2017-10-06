using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());
            // variables
            double whiskeyResultF = whiskyPrice * whiskeyLiters;
            double rakiaResult = whiskyPrice / 2;
            double vineResult = rakiaResult * 0.60;
            double beerResult = rakiaResult * 0.20;
            // result
            double rakiaPriceF = rakiaResult * rakiaLiters;
            double vinePriceF = vineResult * wineLiters;
            double beerPriceF = beerResult * beerLiters;
            double sumAll = whiskeyResultF + rakiaPriceF + vinePriceF + beerPriceF;
            Console.WriteLine("{0:f2}" , sumAll);     
        }
    }
}
