namespace _03_RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToUpper();
            var result = new StringBuilder();            

            var pattern = @"([^0-9]+)([0-9]+)";

            MatchCollection matches = Regex.Matches(text,pattern);

            foreach (Match match in matches)
            {
                var currentText = match.Groups[1].Value;
                var currentNumber = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < currentNumber; i++)
                {
                    result.Append(currentText);
                }

            }
            var resultText = result.ToString();
          
            Console.WriteLine($"Unique symbols used: {resultText.Distinct().Count()}");
            Console.WriteLine(resultText);

        }
    }
}