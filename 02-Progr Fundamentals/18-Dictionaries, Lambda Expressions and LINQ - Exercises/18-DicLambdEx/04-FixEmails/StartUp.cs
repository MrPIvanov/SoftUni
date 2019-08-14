namespace _04_FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name!="stop")
            {
                string email = Console.ReadLine();

                if (email.EndsWith("uk")||email.EndsWith("us"))
                {
                    name = Console.ReadLine();
                    continue;
                }

                else 
                {
                    result[name] = email;
                }
                name = Console.ReadLine();

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}