using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitkoin = int.Parse(Console.ReadLine());
            double ch = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());


            var bitkoinM = bitkoin * 1168;
            var chEu = ch * 0.15;
            var chBg = chEu * 1.76;
            var allMoney = ((bitkoinM   + chBg) / 1.95);
           
            var comissionAllMoney = ((allMoney * comission) / 100);
            var result = allMoney - comissionAllMoney;
            Console.WriteLine("{0:f2}", result);

        }
    }
}
