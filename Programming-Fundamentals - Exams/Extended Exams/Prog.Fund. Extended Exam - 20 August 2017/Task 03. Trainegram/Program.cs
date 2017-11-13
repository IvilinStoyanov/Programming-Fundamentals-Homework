using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";

            string data = Console.ReadLine();
            
            while(data != "Traincode!")
            {
                Match Istrain = Regex.Match(data, pattern);
                if (Istrain.Success)
                {
                    Console.WriteLine(data);
                }
                data = Console.ReadLine();
            }
        }
    }
}
