using System;
using System.Text.RegularExpressions;

namespace _06_ReplaceATag
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";

            string input;
            while ((input=Console.ReadLine()) != "end")
            {
                
                string replaced = Regex.Replace(input, pattern, replacement);

                Console.WriteLine(replaced);


            }


        }
    }
}