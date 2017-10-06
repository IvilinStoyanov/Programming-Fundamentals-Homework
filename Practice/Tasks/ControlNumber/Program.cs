using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int sum = 0;
            int allsum = 0;
            int result = 0;
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    number1 = i * 2;
                    number2 = j * 3;

                    result = allsum + number1 + number2;
                    counter++;
                    if (result >= control)
                    {
                        Console.WriteLine("{0} moves", counter);
                        Console.WriteLine("Score {0} >= {1}", result, control);
                        return;
                    }
                    sum = number1 + number2;
                    allsum = allsum + sum;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    number1 = i * 2;
                    number2 = j * 3;

                    result = allsum + number1 + number2;
                    counter++;
                    if (result < control)
                    {
                        Console.WriteLine("{0} moves", counter - 1);
                        return;
                    }
                    sum = number1 + number2;
                    allsum = allsum + sum;

                }
            }
        }
    }
}
