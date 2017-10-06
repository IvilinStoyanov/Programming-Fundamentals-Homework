using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            
            // generator to 111
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int sum = i * 100 + j * 10 + k;
                        
                        if (sum % 3 == 0 )
                        {
                            special += 5;
                        }
                    else if (sum % 5 == 0)
                        {
                            special -= 2;
                        }
                    else if (sum % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= control)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
                            return;
                        }
                    }               
                }                 
            }
           if (special < control)
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }

        }
    }
}
