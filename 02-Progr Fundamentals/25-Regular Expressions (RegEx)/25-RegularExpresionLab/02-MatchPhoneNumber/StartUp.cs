using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_MatchPhoneNumber
{
    public class StartUp
    {
        public static void Main()
        {
            var pattern = @"(^| ){0}\+359( |-)2\2[0-9]{3}\2[0-9]{4}\b";
            var resultColection = new List<string>();

            var text = Console.ReadLine();

            foreach (Match number in Regex.Matches(text,pattern))
            {
                resultColection.Add(number.ToString());
            }

            Console.WriteLine(string.Join(", ", resultColection));
        }
    }
}