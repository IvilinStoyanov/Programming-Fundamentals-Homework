using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            ulong personalID = ulong.Parse(Console.ReadLine());
            ulong employeeNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}"
                , firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
