using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumberAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    counter++;
                    sum += (i * 2) + (j * 3);
                    if (sum >= control)
                    {
                        Console.WriteLine("{0} moves", counter);
                        Console.WriteLine("Score: {0} >= {1}", sum, control);
                        return;
                    }
                                  
                    }                                    
            }
            if (sum < control)
            {
                Console.WriteLine("{0} moves", counter);
                return;

            }
        }
    }
}
