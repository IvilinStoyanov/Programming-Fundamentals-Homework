using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double LittleRoom = double.Parse(Console.ReadLine());
            double Kitchen = double.Parse(Console.ReadLine());
            double PricePerM3 = double.Parse(Console.ReadLine());

            double bathroom = LittleRoom / 2;
            double secondRoom = (LittleRoom * 0.1) + LittleRoom;
            double thirtRoom = (secondRoom * 0.1) + secondRoom;

            double allSpaceWithoutCoridor = (LittleRoom + Kitchen + bathroom + secondRoom + thirtRoom) * 0.05;
            double allSpaceFinal = allSpaceWithoutCoridor + LittleRoom + Kitchen + bathroom + secondRoom + thirtRoom;

            double result = allSpaceFinal * PricePerM3;

            Console.WriteLine("{0:f2}" , result);

        }
    }
}
