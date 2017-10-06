using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            switch (typeOfFigure)
            {
                // printing results 
                case "triangle":
                    double sideOfTriangle = double.Parse(Console.ReadLine());
                    double heightOfTriangle = double.Parse(Console.ReadLine());
                    double resultTriangle = (TriangleArea(sideOfTriangle, heightOfTriangle));
                    Console.WriteLine("{0:F2}", resultTriangle);
                    break;
                case "square":
                    double sideOfSquare = double.Parse(Console.ReadLine());
                    double resultSquare = SquareArea(sideOfSquare);
                    Console.WriteLine("{0:F2}", resultSquare);
                    break;
                case "rectangle":
                    double widhtOfRectangle = double.Parse(Console.ReadLine());
                    double heightOfRectangle = double.Parse(Console.ReadLine());
                    double resultRectangle = RectangleArea(widhtOfRectangle, heightOfRectangle);
                    Console.WriteLine("{0:F2}" , resultRectangle);
                    break;
                case "circle":
                    double radiusOfCircle = double.Parse(Console.ReadLine());
                    double resultCircle = CircleArea(radiusOfCircle);
                    Console.WriteLine("{0:F2}", resultCircle);
                    break;
            }                     
        }

        static double TriangleArea(double side , double height)
            {
            return (side * height) / 2;
            }
        
        static double SquareArea(double side)
        {
            return side * side;
        }

        static double RectangleArea (double widht , double height)
        {
            return widht * height;
        }

        static double CircleArea (double radius)
        {
            return Math.PI * Math.Pow(radius, 2); 
        }
    }
}
