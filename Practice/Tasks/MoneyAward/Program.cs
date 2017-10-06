using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAward
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double awardPerOnePoint = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum = sum + (points * 2);
                }
                else
                {
                    sum += points;
                }
            }
                double result = awardPerOnePoint * sum;
            Console.WriteLine("The project prize was {0:f2} lv.", result);          
        }
    }
}
