using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {

            double PriceOfSkumriq = double.Parse(Console.ReadLine());
            double PriceOfCaca = double.Parse(Console.ReadLine());

            double PalamudKg = double.Parse(Console.ReadLine());
            double SafridKg = double.Parse(Console.ReadLine());
            double MidiKg = double.Parse(Console.ReadLine());


            double PalamudPrice = (PriceOfSkumriq * 0.60) + PriceOfSkumriq;
            double SafridPrice = (PriceOfCaca * 0.80) + PriceOfCaca;
            double MidiPrice = 7.50 * MidiKg;

            double all = (PalamudPrice * PalamudKg) + (SafridPrice * SafridKg) + MidiPrice;

            Console.WriteLine("{0:f2}" , all);
        }
    }
}
