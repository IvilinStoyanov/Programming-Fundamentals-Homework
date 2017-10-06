using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {

            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var pipe1 = p1 * h;
            var pipe2 = p2 * h;
            var allpipes = pipe1 + pipe2;
            if (pipe1 + pipe2 <= v)
            {
                var totalPoolWater = ((pipe1 + pipe2) / v) * 100;
                var pipe1Water = (pipe1 / allpipes) * 100;
                var pipe2Water = (pipe2 / allpipes) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(totalPoolWater),
                    Math.Truncate(pipe1Water),
                    Math.Truncate(pipe2Water));
            }
            else 
            {
                var overflow = (pipe1 + pipe2) - v;
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters." , h, overflow);
            }
                            
        }
    }
}
