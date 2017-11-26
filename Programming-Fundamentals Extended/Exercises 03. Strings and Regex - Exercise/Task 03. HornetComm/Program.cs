using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        // dictionaries to store data
        List<string> messagesList = new List<string>();
        List<string> broadcastList = new List<string>();
        // regex for private message 
        string privateMessage = @"^([\d]+) <-> ([\w]+)$";
        // regex for broadcast
        string broadcast = @"^([\D]+) <-> ([\w]+)$";

        var input = Console.ReadLine();
        while (!input.Equals("Hornet is Green"))
        {
            var prMessage = Regex.Match(input, privateMessage);
            var broadcastRegex = Regex.Match(input, broadcast);
            var args = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);
            if (prMessage.Success)
            {
                messagesList.Add($"{string.Join("", args[0].ToCharArray().Reverse())} -> {args[1]}");
            }
            if (broadcastRegex.Success)
            {

                StringBuilder broadcastBuilder = new StringBuilder();
                foreach (var c in args[1])
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
                broadcastList.Add($"{broadcastBuilder.ToString()} -> {args[0]}");
            }
            input = Console.ReadLine();
        }
        Console.WriteLine("Broadcasts:");
        PritingResult(broadcastList);
        Console.WriteLine("Messages:");
        PritingResult(messagesList);
    }

    private static void PritingResult(List<string> dataStored)
    {
        if (dataStored.Count != 0)
        {
            foreach (var data in dataStored)
            {
                Console.WriteLine(data);
            }
        }
        else
        {
            Console.WriteLine("None");
        }
    }
}


