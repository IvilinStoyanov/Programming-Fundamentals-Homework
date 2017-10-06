using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double xHeight = double.Parse(Console.ReadLine());
            double yLenght = double.Parse(Console.ReadLine());
            double hHeightRoofSide = double.Parse(Console.ReadLine());

            //variables for house
            double frontDoor = 1.2 * 2;
            double frontSide = xHeight * xHeight - frontDoor;
            double backSide = xHeight * xHeight;
            double houseSidesWindows = (1.5 * 1.5) * 2;
            double houseSides = ((xHeight * yLenght) * 2) - houseSidesWindows;
            // variables for roof
            double rectangleRoof = (xHeight * yLenght) * 2;
            double triangleRoof = ((xHeight * hHeightRoofSide) / 2) * 2;

            // solution
            double AreaOfHouse = houseSides + frontSide + backSide;
            double AreaOfRoof = rectangleRoof + triangleRoof;
            // results
            Console.WriteLine("{0:f2}" , AreaOfHouse / 3.4);
            Console.WriteLine("{0:f2}", AreaOfRoof / 4.3);
        }
    }
}
