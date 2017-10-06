using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            //variables
            double car = 0;
            double microbus = 0;
            double littleBus = 0;
            double bigBus = 0;
            double train = 0;

        // for cicle
            for (int i = 0; i < numberOfPeople; i++)
            {
                int groupNumber = int.Parse(Console.ReadLine());
                if (groupNumber <= 5)
                {
                    car += groupNumber;
                }
                else if (6 <= groupNumber && groupNumber <= 12)
                {
                    microbus += groupNumber;
                }
                else  if (13 <= groupNumber && groupNumber <= 25)
                {
                    littleBus += groupNumber;
                }
               else if (26 <= groupNumber && groupNumber <= 40)
                {
                    bigBus += groupNumber;
                }
               else if (groupNumber > 40 )
                {
                    train += groupNumber;
                }              
            }
            double allSum = car + microbus + littleBus + bigBus + train;
            

            Console.WriteLine("{0:f2}%" , car / allSum * 100);
            Console.WriteLine("{0:f2}%", microbus / allSum * 100);
            Console.WriteLine("{0:f2}%", littleBus / allSum * 100);
            Console.WriteLine("{0:f2}%", bigBus / allSum * 100);
            Console.WriteLine("{0:f2}%", train / allSum  * 100);





        }
    }
}
