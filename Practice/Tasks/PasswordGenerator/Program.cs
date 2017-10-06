using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number01 = int.Parse(Console.ReadLine());
            int number02 = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= number01; i++)
            {
                for (int j = 1; j <= number01; j++)
                {
                    for (char k = 'a' ; k < 'a' + number02 ; k++)
                    {
                        for (char l = 'a' ; l < 'a' + number02; l++)
                        {
                            for (int last = Math.Max(i , j) + 1; last <= number01; last++)
                            {                                                        
                                    Console.Write($"{i}{j}{k}{l}{last} ");                               
                            }
                        }
                    }
                }
            }
        }
    }
}
