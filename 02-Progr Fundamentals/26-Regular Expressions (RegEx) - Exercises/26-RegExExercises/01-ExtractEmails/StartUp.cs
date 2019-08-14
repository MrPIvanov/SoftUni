using System;
using System.Text.RegularExpressions;

namespace _01_ExtractEmails
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            string input = Console.ReadLine();

            Regex reg = new Regex(pattern);

            foreach (Match m in reg.Matches(input))
            {
                Console.WriteLine(m.Value);
            }

           
        }
    }
}