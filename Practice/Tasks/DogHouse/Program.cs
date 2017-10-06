using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double lenghtA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());
            // variables 
            double pages = (lenghtA * (lenghtA / 2)) * 2;
            double backWallSquarePart1 = (lenghtA / 2) * (lenghtA / 2);
            double backWallTrianglePart2 = ((lenghtA / 2) * (heightB -  lenghtA / 2)) / 2;
            double backWall = backWallSquarePart1 + backWallTrianglePart2;
            double frontWall = backWall - ((lenghtA / 5) * (lenghtA / 5));

            double Roof = lenghtA * (lenghtA / 2) + lenghtA * (lenghtA / 2);
            // solution 
            double allAreaOfHouse = (pages + backWall + frontWall) / 3;
            double RoofPaint = Roof / 5;

            Console.WriteLine("{0:f2}" , allAreaOfHouse);
            Console.WriteLine("{0:f2}", RoofPaint);




        }
    }
}
