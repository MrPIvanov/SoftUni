using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartUp
{
    static void Main()
    {
        var rows = int.Parse(Console.ReadLine());
        var text = "";

        for (int i = 0; i < rows; i++)
        {
            text += Console.ReadLine();
        }

        var fullMatchPattern = @"{[^\[\]{]+}|\[[^{}\[]+\]";

        var matches = Regex.Matches(text, fullMatchPattern);

        var allMatches = new List<string>();

        foreach (var match in matches)
        {
            allMatches.Add(match.ToString());
        }

        var resultToPrint = "";
        foreach (var item in allMatches)
        {
            var lengthOfTheMatch = item.Length;

            var numbersFromFullMatch = "";

            for (int i = 0; i < item.Length; i++)
            {
                if (char.IsNumber(item[i]))
                {
                    numbersFromFullMatch += item[i];
                }
            }

            if (numbersFromFullMatch.Length % 3 == 0)
            {
                var numberPattern = "[0-9]{3}";

                var allNumbersByTrees = Regex.Matches(numbersFromFullMatch, numberPattern);

                foreach (var number in allNumbersByTrees)
                {
                    resultToPrint += (char)(int.Parse(number.ToString()) - lengthOfTheMatch);
                }
            }
        }

        Console.WriteLine(resultToPrint);
    }
}