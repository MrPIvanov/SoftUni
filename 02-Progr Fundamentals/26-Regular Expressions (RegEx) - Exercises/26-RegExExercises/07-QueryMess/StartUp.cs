using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _07_QueryMess
{
    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<string>>();
            
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var pattern = @"(?<=^|\?|&)([^?]*?)={1}([^?]*?)(?=$|\?|&)";

                MatchCollection currentMatches = Regex.Matches(input, pattern);

                foreach (Match item in currentMatches)
                {
                    var key = item.Groups[1].Value;
                    var value = item.Groups[2].Value;

                    key = key.Replace("+"," ");
                    key = key.Replace("%20", " ");
                    key = key.Trim();
                    var finalKey = "";
                    value = value.Replace("+", " ");
                    value = value.Replace("%20", " ");
                    value = value.Trim();
                    var finalValue = "";

                    for (int i = 0; i < key.Length; i++)
                    {
                        if (key[i]==' ' && key[i+1] == ' ')
                        {
                            continue;

                        }
                        finalKey += key[i];

                    }

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] == ' ' && value[i + 1] == ' ')
                        {
                            continue;

                        }
                        finalValue += value[i];

                    }

                    if (result.ContainsKey(finalKey))
                    {
                        result[finalKey].Add(finalValue);
                    }
                    else
                    {
                        result[finalKey] = new List<string>();
                        result[finalKey].Add(finalValue);
                    }

                }

                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ",item.Value)}]");
                }
                Console.WriteLine();
                result.Clear();


            }


        }
    }
}