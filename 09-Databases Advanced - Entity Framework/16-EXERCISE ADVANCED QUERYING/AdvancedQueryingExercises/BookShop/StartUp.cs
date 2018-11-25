namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                // Task 00 "Book Shop Database"
                DbInitializer.ResetDatabase(db);
                // ---------------------------------------------------------------------------------


                //// Task 01 "Age Restriction"
                //var command = Console.ReadLine();
                //var result = GetBooksByAgeRestriction(db, command);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 02 "Golden Books"
                //var result = GetGoldenBooks(db);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 03 "Books by Price"
                //var result = GetBooksByPrice(db);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 04 "Not Released In"
                //var year = int.Parse(Console.ReadLine());
                //var result = GetBooksNotRealeasedIn(db, year);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 05 "Book Titles by Category"
                //var input = Console.ReadLine();
                //var result = GetBooksByCategory(db, input);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 06 "Released Before Date"
                //var date = Console.ReadLine();
                //var result = GetBooksReleasedBefore(db, date);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 07 "Author Search"
                //var input = Console.ReadLine();
                //var result = GetAuthorNamesEndingIn(db, input);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 08 "Book Search"
                //var input = Console.ReadLine();
                //var result = GetBookTitlesContaining(db, input);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 09 "Book Search by Author"
                //var input = Console.ReadLine();
                //var result = GetBooksByAuthor(db, input);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 10 "Count Books"
                //var lengthCheck = int.Parse(Console.ReadLine());
                //var result = CountBooks(db,lengthCheck);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 11 "Total Book Copies"
                //var result = CountCopiesByAuthor(db);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 12 "Profit by Category"
                //var result = GetTotalProfitByCategory(db);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 13 "Most Recent Books"
                //var result = GetMostRecentBooks(db);
                //Console.WriteLine(result);
                //// ---------------------------------------------------------------------------------


                //// Task 14 "Increase Prices"
                //IncreasePrices(db);
                //// ---------------------------------------------------------------------------------


                //// Task 15 "Remove Books"
                //var numberOfDeletedBooks = RemoveBooks(db);
                //Console.WriteLine($"{numberOfDeletedBooks} books were deleted");
                //// ---------------------------------------------------------------------------------
            }
        }
        //Solution for Task 01 "Age Restriction"
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestrictionInput = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), command, true);

            var bookTitles = context.Books
                                    .Where(x => x.AgeRestriction == ageRestrictionInput)
                                    .OrderBy(x => x.Title)
                                    .Select(x => x.Title)
                                    .ToArray();

            return string.Join(Environment.NewLine, bookTitles);
        }

        //Solution for Task 02 "Golden Books"
        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBookTitles = context.Books
                                          .Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000)
                                          .OrderBy(x => x.BookId)
                                          .Select(x => x.Title)
                                          .ToArray();

            return string.Join(Environment.NewLine, goldenBookTitles);
        }

        //Solution for Task 03 "Books by Price"
        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var books = context.Books
                               .Where(x => x.Price > 40)
                               .OrderByDescending(x => x.Price)
                               .Select(x => new
                               {
                                   x.Title,
                                   x.Price
                               })
                               .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 04 "Not Released In"
        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                               .Where(x => x.ReleaseDate.Value.Year != year)
                               .OrderBy(x => x.BookId)
                               .Select(x => x.Title)
                               .ToArray();

            return string.Join(Environment.NewLine, books);

        }

        //Solution for Task 05 "Book Titles by Category"
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var books = context.Books
                               .Where(x => x.BookCategories.Any(s => categories.Contains(s.Category.Name.ToLower())))
                               .OrderBy(x => x.Title)
                               .Select(x => x.Title)
                               .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        //Solution for Task 06 "Released Before Date"
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var dateToUse = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                               .Where(x => x.ReleaseDate < dateToUse)
                               .OrderByDescending(x => x.ReleaseDate)
                               .Select(x => new
                               {
                                   x.Title,
                                   x.EditionType,
                                   x.Price
                               })
                               .ToArray();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 07 "Author Search"
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                                 .Where(x => EF.Functions.Like(x.FirstName, $"%{input}"))
                                 .Select(x => new
                                 {
                                     FullName = x.FirstName + " " + x.LastName
                                 })
                                 .OrderBy(x => x.FullName)
                                 .ToList();

            var sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FullName}");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 08 "Book Search"
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var bookTitles = context.Books
                                    .Where(x => EF.Functions.Like(x.Title.ToLower(), $"%{input.ToLower()}%"))
                                    .OrderBy(x => x.Title)
                                    .Select(x => x.Title)
                                    .ToArray();

            return string.Join(Environment.NewLine, bookTitles);
        }

        //Solution for Task 09 "Book Search by Author"
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                               .Where(x => EF.Functions.Like(x.Author.LastName.ToLower(), $"{input.ToLower()}%"))
                               .OrderBy(x => x.BookId)
                               .Select(x => new
                               {
                                   x.Title,
                                   AuthorFullName = x.Author.FirstName + " " + x.Author.LastName
                               })
                               .ToArray();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorFullName})");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 10 "Count Books"
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var bookCount = context.Books
                               .Where(x => x.Title.Length > lengthCheck)
                               .ToArray()
                               .Count();

            return bookCount;
        }

        //Solution for Task 11 "Total Book Copies"
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authors = context.Authors
                               .Select(x => new
                               {
                                   FullName = x.FirstName + " " + x.LastName,
                                   TotalCopiesSole = x.Books.Sum(s => s.Copies)
                               })
                               .OrderByDescending(x => x.TotalCopiesSole)
                               .ToArray();

            var sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.FullName} - {author.TotalCopiesSole}");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 12 "Profit by Category"
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                                    .Select(x => new
                                    {
                                        x.Name,
                                        Profit = x.CategoryBooks.Sum(s => s.Book.Price * s.Book.Copies)
                                    })
                                    .OrderByDescending(x => x.Profit)
                                    .ToArray();

            var sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"{category.Name} ${category.Profit:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //Solution for Task 13 "Most Recent Books"
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context.Categories
                                    .OrderBy(x => x.Name)
                                    .Select(x => new
                                    {
                                        x.Name,
                                        CategoryBooks = x.CategoryBooks
                                                                        .Select(s => new
                                                                        {
                                                                            BookTitle = s.Book.Title,
                                                                            ReleaseDate = s.Book.ReleaseDate
                                                                        })
                                                                        .OrderByDescending(s => s.ReleaseDate)
                                                                        .Take(3)
                                                                        .ToArray()
                                    })
                                    .ToArray();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.Name}");

                foreach (var book in category.CategoryBooks)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseDate.Value.Year})");
                }
            }
                                    
            return sb.ToString().TrimEnd();
        }

        //Solution for Task 14 "Increase Prices"
        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                               .Where(x => x.ReleaseDate.Value.Year < 2010)
                               .ToArray();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        //Solution for Task 15 "Remove Books"
        public static int RemoveBooks(BookShopContext context)
        {
            var booksToDelete = context.Books.Where(x => x.Copies < 4200).ToArray();
            var resultToReturn = booksToDelete.Count();

            context.Books.RemoveRange(booksToDelete);

            context.SaveChanges();

            return resultToReturn;
        }
    }
}
