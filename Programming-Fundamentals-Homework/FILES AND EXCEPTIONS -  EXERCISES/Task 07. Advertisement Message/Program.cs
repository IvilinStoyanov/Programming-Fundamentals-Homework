using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText("input.txt");
            int input = int.Parse(lines);         
            // Random is outside, cuz in inside doesn't work correctly
            Random phrasesIndex = new Random();
            Random eventsIndex = new Random();
            Random authorsIndex = new Random();
            Random citiesIndex = new Random();
            for (int i = 0; i < input; i++)
            {
                var phrases = new[]{
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

                var events = new[] {"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

                var authors = new[] {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

                var cities = new[] {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" };

              
                var phrRandom = phrasesIndex.Next(0, phrases.Length);
                var phrasesOfRandomElement = phrases[phrRandom];

                var eventsRandom = eventsIndex.Next(0, events.Length);
                var elemntOfRandomElement = events[eventsRandom];
              
                var authorsRandom = authorsIndex.Next(0, authors.Length);
                var authorsOfRandomElement = authors[authorsRandom];
             
                var citiesRandom = citiesIndex.Next(0, cities.Length);
                var citiesOfRandomElement = cities[citiesRandom];

                var output = ($"{phrasesOfRandomElement} {elemntOfRandomElement} {authorsOfRandomElement} – {citiesOfRandomElement}" 
                     + Environment.NewLine);
                File.WriteAllText("output.txt", output);
            }
           
        }
    }
}
