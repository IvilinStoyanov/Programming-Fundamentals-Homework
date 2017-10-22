using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
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

            Random phrasesIndex = new Random();
            var phrRandom = phrasesIndex.Next(0, phrases.Length);
            var phrasesOfRandomElement = phrases[phrRandom];

            Random eventsIndex = new Random();
            var eventsRandom = eventsIndex.Next(0, events.Length);
            var elemntOfRandomElement = events[eventsRandom];

            Random authorsIndex = new Random();
            var authorsRandom = authorsIndex.Next(0, authors.Length);
            var authorsOfRandomElement = authors[authorsRandom];

            Random citiesIndex = new Random();
            var citiesRandom = citiesIndex.Next(0, cities.Length);
            var citiesOfRandomElement = cities[citiesRandom];

            Console.WriteLine($"{phrasesOfRandomElement} {elemntOfRandomElement} {authorsOfRandomElement} – {citiesOfRandomElement}.");





        }
    }
}

