namespace _04_SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            char[] separators = { ',', ';',':','.','!','(',')','"', '\'', '\\','/','[',']',' ' };

            List<string> input = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase = new List<string>();



            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(c=>char.IsLower(c)))
                {
                    lowerCase.Add(input[i]);
                }
                else if (input[i].All(c => char.IsUpper(c)))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixCase.Add(input[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCase)}");
        }
    }
}