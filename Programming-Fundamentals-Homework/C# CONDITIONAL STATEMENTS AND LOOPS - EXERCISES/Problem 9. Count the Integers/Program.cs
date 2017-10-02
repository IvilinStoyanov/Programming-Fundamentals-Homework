using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = 0;
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    counts++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counts);
            }
        }
    }
}
