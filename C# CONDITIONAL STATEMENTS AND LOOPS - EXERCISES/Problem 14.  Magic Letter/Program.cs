using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            string thirdLetter = Console.ReadLine();
            string result = "";

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        result = ($"{i}{j}{k}");
                        if (!result.Contains(thirdLetter))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
        }
    }
}
