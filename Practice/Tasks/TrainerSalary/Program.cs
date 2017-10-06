using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs        
            int numberOfLectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            //variable 
            int JelevCount = 0;
            int RoYaLCount = 0;
            int RoliCount = 0;
            int TrofonCount = 0;
            int SinoCount = 0;
            int otherCount = 0;
            // counter 
            int counter = 0;
            for (int lectures = 0; lectures < numberOfLectures; lectures++)
            {
                string n = Console.ReadLine();
                if (n == "Jelev")
                {
                    JelevCount++;
                }
                if (n == "RoYaL")
                {
                    RoYaLCount++;
                }
                if (n == "Roli")
                {
                    RoliCount++;
                }
                if (n == "Trofon")
                {
                    TrofonCount++;
                }
                if (n == "Sino")
                {
                    SinoCount++;
                }
                if (n != "Jelev" && n!= "RoYaL" && n != "Roli" && n != "Trofon" && n != "Sino")
                {
                    otherCount++;
                }             
            }
            double budgetForAll = budget / numberOfLectures;
            Console.WriteLine("Jelev salary: {0:f2} lv" , JelevCount * budgetForAll);
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYaLCount * budgetForAll);
            Console.WriteLine("Roli salary: {0:f2} lv", RoliCount * budgetForAll);
            Console.WriteLine("Trofon salary: {0:f2} lv", TrofonCount * budgetForAll);
            Console.WriteLine("Sino salary: {0:f2} lv", SinoCount * budgetForAll);
            Console.WriteLine("Others salary: {0:f2} lv", otherCount * budgetForAll);


        }
    }
}
