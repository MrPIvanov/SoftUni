namespace _05_ShortWordsSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','"','\'','\\','/','!','?',' ' };

            List<string> elements = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine($"{string.Join(", ", elements.Where(x=>x.Length<5).OrderBy(x=>x).Distinct())}");
        }
    }
}