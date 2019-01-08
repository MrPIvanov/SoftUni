using System;
using System.Linq;

namespace _02_SortWords
{
    public class StartUp
    {
        static void Main()
        {
            var words = Console.ReadLine().Split().ToList();

            foreach (var word in words.OrderBy(x => x))
            {
                Console.Write($"{word} ");
            }
        }
    }
}