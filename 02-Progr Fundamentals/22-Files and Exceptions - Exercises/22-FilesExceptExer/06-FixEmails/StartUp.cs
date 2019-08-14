namespace _06_FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, string>();
            var oddCounter = 0;
            var lastName = "";

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                oddCounter++;
                if (oddCounter%2==1)
                {
                    lastName = input;

                }
                else
                {
                    if (input.EndsWith("us") || input.EndsWith("uk"))
                    {
                        continue;
                    }
                    else
                    {
                        result[lastName] = input;
                    }
                }
            }

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }


        }
    }
}