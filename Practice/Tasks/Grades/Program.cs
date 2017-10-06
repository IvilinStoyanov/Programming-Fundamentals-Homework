using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int numberOfStudent = int.Parse(Console.ReadLine());
            
            double markCount = 0;

            // mark of studens system counter
            double F = 0;
            double D = 0;
            double C = 0;    
            double AB = 0;

            for (int i = 0; i < numberOfStudent; i++)
            {
                double mark = double.Parse(Console.ReadLine());

               if (mark >= 2 && mark <= 2.99)
                {
                    F++;
                    markCount += mark;
                }
               if (mark >= 3.00 && mark <= 3.99)
                {
                    D++;
                    markCount += mark;
                }
               if (mark >= 4.00 && mark <= 4.99)
                {
                    C++;
                    markCount += mark;
                }
               if (mark >= 5)
                {
                    AB++;
                    markCount += mark;
                }
            }
            //solution
            double allStudents = F + D + C + AB;
            Console.WriteLine("Top students: {0:f2}%" , AB / allStudents * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", C / allStudents * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", D / allStudents * 100);
            Console.WriteLine("Fail: {0:f2}%", F / allStudents * 100);
            Console.WriteLine("Average: {0:f2}", markCount / allStudents);


        }
    }
}
