namespace _09_BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            var endLibrary = new Library();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var book = Console.ReadLine().Split();
                var currentBook = new Book(book);
                endLibrary.Books.Add(currentBook);                
            }

            foreach (var author in endLibrary.Books
                .GroupBy(x=>x.Author)
                .Select(x=>new {Author =x.Key, Prices = x.Sum(s=>s.Price)})
                .OrderByDescending(x=>x.Prices)
                .ThenBy(x=>x.Author))
            {
                Console.WriteLine($"{author.Author} - {author.Prices}");
            }

        }
    }

    public class Book
    {
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBNnumber  { get; set; }
        public decimal Price { get; set; }

        public Book(string[] book)
        {
            Title = book[0];
            Author = book[1];
            Publisher = book[2];
            ReleaseDate = book[3];
            ISBNnumber = book[4];
            Price = decimal.Parse(book[5]);


        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Name = "Default Name";
            Books = new List<Book>();
        }
    }
}