using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOfInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTurn = int.Parse(Console.ReadLine());
             int counter09 = 0;
               int counter1019 = 0;
                int counter2029 = 0;
                  int counter3039 = 0;
                     int counter4050 = 0;
                        int invalidNumber = 0;
                double result = 0;
            for (int i = 0; i < numberOfTurn; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers >= 0 && numbers <= 9)
                {
                    result = result + (numbers * 0.20);
                    counter09++;
                }
                if (numbers >= 10 && numbers <= 19)
                {
                    result = result + (numbers * 0.30);
                    counter1019++;
                }
                if (numbers >= 20 && numbers <= 29)
                {
                    result = result + (numbers * 0.40);
                    counter2029++;
                }
                if (numbers >= 30 && numbers <= 39)
                {
                    result += 50;
                    counter3039++;
                }
                if (numbers >= 40 && numbers <= 50)
                {
                    result += 100;
                    counter4050++;
                }
                if (numbers > 50 || numbers < 0)
                {
                    result /= 2;
                    invalidNumber++;
                }
            }
            double allCounts = counter09 + counter1019 + counter2029 + counter3039 + counter4050 + invalidNumber;
            Console.WriteLine("{0:f2}" , result);
            Console.WriteLine("From 0 to 9: {0:f2}%" , counter09 / allCounts * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", counter1019 / allCounts * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", counter2029 / allCounts * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", counter3039 / allCounts * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", counter4050 / allCounts * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%" , invalidNumber / allCounts * 100);

        }
    }
}
