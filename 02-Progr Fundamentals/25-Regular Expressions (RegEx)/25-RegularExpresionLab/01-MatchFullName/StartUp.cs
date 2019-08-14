using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    public class StartUp
    {
        public static void Main()
        {
            var names = Console.ReadLine();
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection result = Regex.Matches(names, regex);

            foreach (Match  name in result)
            {
                Console.Write(name.Value + " ");

            }

        }
    }
}