using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();
        Regex regex = new Regex(@"^TO:\s([A-Z]+);\sMESSAGE:\s(.+);$");
        var securityKey = Console.ReadLine();
        int index = 0;
        //•	TO: {recipient}; MESSAGE: {message};
        var data = Console.ReadLine();
        while (data != "END")
        {
            var dataSplited = data.Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string convertedMessage = "";
            if (regex.IsMatch(data))
            {
                Match match = regex.Match(data);

                string sender = match.Groups[1].ToString();

                if (!messages.ContainsKey(sender))
                {
                    messages.Add(sender, new List<string>());
                }
                for (int i = 0; i < match.Length; i++)
                {
                    if (index > securityKey.Length - 1)
                    {
                        index = 0;
                    }
                    var x = int.Parse(securityKey[index].ToString());
                    char letter = (char)(match.ToString()[i] + x);
                    convertedMessage += letter;
                    index++;
                }
                index = 0;
                messages[sender].Add(convertedMessage);
            }
            else
            {

            }
            data = Console.ReadLine();
        }
        foreach (var recipient in messages.OrderBy(n => n.Key))
        {
            foreach (var item in recipient.Value)
            {
                Console.WriteLine(item);
            }
        }
    }
}

