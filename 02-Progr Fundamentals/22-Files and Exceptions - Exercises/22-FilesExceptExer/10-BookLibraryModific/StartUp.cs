namespace _10_BookLibraryModific
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
            var targetDate = new DateTime();
            targetDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in endLibrary.Books.Where(x=>x.ReleaseDate>targetDate).OrderBy(x=>x.ReleaseDate).ThenBy(x=>x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.Day}.{book.ReleaseDate.Month:d2}.{book.ReleaseDate.Year}");
            }



        }
    }

    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public decimal Price { get; set; }

        public Book(string[] book)
        {
            Title = book[0];
            Author = book[1];
            Publisher = book[2];
            ReleaseDate = DateTime.ParseExact(book[3],"dd.MM.yyyy", CultureInfo.InvariantCulture); 
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