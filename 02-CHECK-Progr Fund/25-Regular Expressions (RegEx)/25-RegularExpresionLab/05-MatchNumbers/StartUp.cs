using System;
using System.Text.RegularExpressions;

namespace _05_MatchNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?[0-9]+[\.]?[0-9]*($|(?=\s))";

            MatchCollection allMatches = Regex.Matches(text,pattern);

            foreach (Match number in allMatches)
            {
                Console.Write($"{number} ");

            }


        }
    }
}