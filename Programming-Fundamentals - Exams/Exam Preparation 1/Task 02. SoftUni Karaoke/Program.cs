using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace SoftuniKaraoke
{
    public class SoftuniKaraoke
    {
        public static void Main()
        {
            // input
            List<string> participant = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None).ToList();
          
            Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();  //data store
            string input = Console.ReadLine();
            while(input != "dawn")
            {
                // variables
                var info = input.Split(new string[] { ", "}, StringSplitOptions.None).ToList();
                string name = info[0];
                string song = info[1];
                string awards = info[2];

               if(!participant.Any(p => p == name) || !songs.Any(s => s == song))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if(!winners.ContainsKey(name))
                {
                    winners.Add(name, new List<string>());
                }
                if (!winners[name].Contains(awards))
                {
                    winners[name].Add(awards);
                    winners[name] = winners[name].
                        OrderBy(a => a).ToList();
                }

                input = Console.ReadLine();
            }
            winners = winners.OrderByDescending(a => a.Value.Count)               
                .ToDictionary(x => x.Key, v => v.Value);
            if(winners.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var win in winners)
            {
                var name = win.Key;
                var awardsCount = win.Value.Count();
                Console.WriteLine("{0}: {1} awards" , name , awardsCount);
                foreach (var w in win.Value)
                {
                    var awardsName = w;
                    Console.WriteLine("--{0}" , awardsName);
                }
            }

        }
    }
}