using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int counts = 0;
            while (type != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", type);
                counts++;
                type = Console.ReadLine();
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counts);
        }
    }
}
