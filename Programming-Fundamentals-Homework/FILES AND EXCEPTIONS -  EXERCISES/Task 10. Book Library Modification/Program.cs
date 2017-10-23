using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN_Number { get; set; }
        public double price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var authorDate = new Dictionary<string, DateTime>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var dates = tokens[3].Split(".".ToCharArray()).ToArray();
                var releaseDate = new DateTime
                    (
                        int.Parse(dates[2]),
                        int.Parse(dates[1]),
                        int.Parse(dates[0])
                    );
                var book = new Book()
                {
                    Title = tokens[0],
                    Author = tokens[1],
                    Publisher = tokens[2],
                    ReleaseDate = releaseDate,
                    ISBN_Number = tokens[4],
                    price = double.Parse(tokens[5])
                };

                if (!authorDate.ContainsKey(book.Title))
                {
                    authorDate[book.Title] = new DateTime();
                }
                authorDate[book.Title] = book.ReleaseDate;
            }
            authorDate = authorDate.OrderBy(a => a.Value).ThenBy(a => a.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            var dateToPrintAfterTokens = Console.ReadLine().Split('.').ToArray();
            var dateToPrintAFter = new DateTime(
                int.Parse(dateToPrintAfterTokens[2]),
                int.Parse(dateToPrintAfterTokens[1]),
                int.Parse(dateToPrintAfterTokens[0]));

            foreach (var authorAndDate in authorDate)
            {
                var author = authorAndDate.Key;
                var date = authorAndDate.Value;
                if (dateToPrintAFter < date)
                {
                    Console.WriteLine($"{author} -> {date.ToString(@"dd.MM.yyyy")}");
                }
            }

        }
    }
}