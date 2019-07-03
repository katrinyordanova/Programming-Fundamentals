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
        public string Name { get; set; }
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

            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> booksByDate = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(dateTime)>0)
                {
                    booksByDate.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var pair in booksByDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:dd.MM.yyyy}");
            }
        }
        static Books ReadInput(string input)
        {
            string[] tokens = input.Split();
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

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
