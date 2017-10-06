using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleFigureDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // first line
            Console.Write(new string('%', 2 * n));
            Console.WriteLine();


         
        
            for (int row = 0; row < (n - 1) / 2 ; row++)
            {                            
                    Console.Write("%");
                    Console.Write(new string(' ', (2 * n) - 2));
                    Console.Write("%");
                    Console.WriteLine();
            }
                              
            //mid
                        Console.Write("%");
                        Console.Write(new string(' ', n - 2));
                        Console.Write("*" + "*");
                        Console.Write(new string(' ', n - 2));
                        Console.Write("%");
                        Console.WriteLine();


            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write("%");
                Console.Write(new string(' ', (2 * n) - 2));
                Console.Write("%");
                Console.WriteLine();
            }

        
            
               // last line
               Console.Write(new string('%', 2 * n));
               Console.WriteLine();

            
        }
    }
}
