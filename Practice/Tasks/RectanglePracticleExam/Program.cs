using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePracticleExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%' , n * 2));
            int numRow = n;
            if (n % 2 == 0)
            {
                numRow--;
            }
            for (int i = 0; i < numRow; i++)
            {
                Console.Write("%");
                if (i == numRow / 2)
                { 
                Console.Write(new string(' ', n - 2));
                Console.Write("**");
                Console.Write(new string(' ', n - 2));
                  }
                else {
                    Console.Write(new string(' ', n * 2 - 2));
                     }
                Console.Write("%");
                Console.WriteLine();
            }
            
            Console.WriteLine(new string('%', n * 2));

        }
    }
}
