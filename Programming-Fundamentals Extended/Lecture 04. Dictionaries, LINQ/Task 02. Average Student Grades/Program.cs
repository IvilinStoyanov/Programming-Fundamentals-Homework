using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            int numberOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudents; i++)
            {
                var infoForStudent = Console.ReadLine().Split(' ');
                var name = infoForStudent[0];
                var mark = double.Parse(infoForStudent[1]);
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(mark);
            }
            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var average = studentGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                    Console.Write($"{grade:f2} ");
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
