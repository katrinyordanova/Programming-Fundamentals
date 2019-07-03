using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05._Book_Library
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public  string Name { get; set; }
        public List<Books> Books { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            List<Books> books = new List<Books>();

            for (int i = 0; i < numbersOfLines; i++)
            {
                books.Add(ReadInput(Console.ReadLine()));
            }

            Library library = new Library { Name = "Library", Books = books };

            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }

            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
        static Books ReadInput(string input)
        {
            string[] tokens = input.Split();
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "d.M.yyyy",CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price =decimal.Parse(tokens[5]);

            return new Books
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                ISBN = isbn,
                Price = price
            };
        }
    }
}
