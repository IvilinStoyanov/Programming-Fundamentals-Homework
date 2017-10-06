using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            if (number02 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", number01);
                return;
            }

            if (operation == "+")
            {
             
                var plus = number01 + number02;

                Console.Write("{0} + {1} = {2} - " , number01 , number02 , plus );
                if (plus % 2 == 0) { Console.Write("even"); }
                else { Console.Write("odd"); }
                Console.WriteLine();
            }
            if (operation == "-")
            {

                var minus = number01 - number02;

                Console.Write("{0} - {1} = {2} - ", number01, number02, minus);
                if (minus % 2 == 0) { Console.Write("even"); }
                else { Console.Write("odd"); }
                Console.WriteLine();
            }
            if (operation == "*")
            {

                var Multiplication = number01 * number02;

                Console.Write("{0} * {1} = {2} - ", number01, number02, Multiplication);
                if (Multiplication % 2 == 0) { Console.Write("even"); }
                else { Console.Write("odd"); }
                Console.WriteLine();
            }
         
            if (operation == "/")
            {
                Console.WriteLine($"{number01} / {number02} = {(double)number01 / number02:F2}");
                Console.WriteLine();
               
            }
         
            if (operation == "%")
            {

                var modul = number01 % number02;

                Console.Write("{0} % {1} = {2}", number01, number02, modul);
                Console.WriteLine();
              
            }       
        }
    }
}
