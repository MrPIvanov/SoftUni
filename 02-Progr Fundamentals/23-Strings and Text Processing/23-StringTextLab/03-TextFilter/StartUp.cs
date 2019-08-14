using System;
using System.Linq;

namespace _03_TextFilter
{
    public class StartUp
    {
        public static void Main()
        {
            var banWords = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToList();

            var text = Console.ReadLine();

            foreach (var word in banWords)
            {
                text = text.Replace($"{word}",$"{new string('*',word.Length)}");
            }

            Console.WriteLine(text);
        }
    }
}