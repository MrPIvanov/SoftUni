using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_EmailStatistics
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfEmails = int.Parse(Console.ReadLine());
            var pattern = @"^(?<name>[a-zA-Z]{5,})@(?<server>[a-z]{3,})\.(?<domain>com|bg|org)$";
            var emailDatabase = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfEmails; i++)
            {
                var currentEmail = Console.ReadLine();

                if (Regex.IsMatch(currentEmail, pattern))
                {
                    var key = Regex.Match(currentEmail, pattern).Groups["server"].Value + "." + Regex.Match(currentEmail, pattern).Groups["domain"].Value;
                    var name = Regex.Match(currentEmail, pattern).Groups["name"].Value;
                    if (emailDatabase.ContainsKey(key))
                    {
                        if (emailDatabase[key].Contains(name))
                        {
                            continue;
                        }
                        else
                        {
                            emailDatabase[key].Add(name);
                        }

                    }
                    else
                    {
                        emailDatabase[key] = new List<string>();
                        emailDatabase[key].Add(name);

                    }


                }
            }

            foreach (var domain in emailDatabase.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var name in domain.Value)
                {
                    Console.WriteLine($"### {name}");
                }
            }

        }
    }
}