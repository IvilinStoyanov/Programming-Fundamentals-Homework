using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
           
            switch (proffesion)
            {
                case "Athlete":
                    price = 0.70;
                    Console.WriteLine("The {0} has to pay {1:F2}." , proffesion , quantity * price);
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesion, quantity * price);
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesion, quantity * price);
                    break;
                default:
                    price = 1.20;
                    Console.WriteLine("The {0} has to pay {1:F2}.", proffesion, quantity * price);
                    break;
            }
        }
    }
}
