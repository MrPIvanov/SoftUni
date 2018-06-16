using System;
using System.Text.RegularExpressions;

namespace _04_MatchDates
{
    public class StartUp
    {
        public static void Main()
        {
            var patters = @"\b(?<day>[0-9]{2})([-\.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>[0-9]{4})\b";
            var text = Console.ReadLine();

            var matches = Regex.Matches(text, patters);

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }


        }
    }
}