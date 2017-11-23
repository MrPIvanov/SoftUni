using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BookLibrary
{
    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Book> bookList = new List<Book>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                bookList.Add(new Book
                {
                    Title = input[0],
                    Autor = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    ISBNNumber = input[4],
                    Price = double.Parse(input[5])
                });

            }

            var dict = new Dictionary<string, double>();
            foreach (var book in bookList)
            {
                if (!dict.ContainsKey(book.Autor))
                {
                    dict[book.Autor] = book.Price;

                }
                else
                {
                    dict[book.Autor] += book.Price;

                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }
}
  