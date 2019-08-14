using System;
using System.Text.RegularExpressions;

namespace _03_MatchHexadecimaNumb
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(0x)*([0-9A-F])+\b";

            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text,pattern);

            foreach (var number in matches)
            {
                Console.Write($"{number} ");
            }


        }
    }
}