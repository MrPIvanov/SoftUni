using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var pattern = @"(_|,)([a-zA-Z]+)([0-9{1}])";

        while (input != "Report")
        {
            var wordsToPrins = new List<string>();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var sign = match.Groups[1].Value.ToString();
                var letters = match.Groups[2].Value.ToString();
                var number = int.Parse(match.Groups[3].Value.ToString());

                if (sign == "_")
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        var symbol = letters[i];
                        int symbolNumber = (int)symbol;
                        symbolNumber -= number;
                        Console.Write((char)symbolNumber);
                    }
                }
                else
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        var symbol = letters[i];
                        int symbolNumber = (int)symbol;
                        symbolNumber += number;
                        Console.Write((char)symbolNumber);
                    }
                }

                Console.Write(" ");
            }




            input = Console.ReadLine();
            Console.WriteLine();
        }
    }
}