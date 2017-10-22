using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_BookLibraryModific
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
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture),
                    ISBNNumber = input[4],
                    Price = double.Parse(input[5])
                });

            }
            
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            var dict = new Dictionary<string, DateTime>();

            foreach (var item in bookList)
            {
                if (endDate.Date < item.ReleaseDate.Date)
                {
                    dict[item.Title] = item.ReleaseDate;
                }
            }
            foreach (var item in dict.OrderBy(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
            }

        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }
}