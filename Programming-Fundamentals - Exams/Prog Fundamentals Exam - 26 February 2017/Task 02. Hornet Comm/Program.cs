using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> message = new List<string>();
            List<string> broadcast = new List<string>();

            string messagePattern = @"^([\d]+) <-> ([\w]+)$";
            string broadcastPattern = @"^([\D]+) <-> ([\w]+)$";

            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            var input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);
                if (messageRegex.IsMatch(input))
                {
                    message.Add($"{string.Join("",inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");
                }

                if (broadcastRegex.IsMatch(input))
                {
                    StringBuilder broadcastBuilder = new StringBuilder();
                    foreach (var c in inputArgs[1])
                    {
                        if (Char.IsLower(c))
                        {
                            broadcastBuilder.Append(Char.ToUpper(c));
                            continue;
                        }
                        if (Char.IsUpper(c))
                        {
                            broadcastBuilder.Append(Char.ToLower(c));
                            continue;
                        }
                        broadcastBuilder.Append(c);
                    }
                    broadcast.Add($"{broadcastBuilder.ToString()} -> {inputArgs[0]}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            PrintResult(broadcast);
          
            Console.WriteLine("Messages:");
            PrintResult(message);
        }

        public static void PrintResult(List<string> collection)
        {
            if (collection.Count != 0)
            {
                foreach (var c in collection)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }    
}
            

 


        
        

