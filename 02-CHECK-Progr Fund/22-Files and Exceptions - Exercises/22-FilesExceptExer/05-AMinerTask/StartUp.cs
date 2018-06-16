namespace _05_AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, int>();
            int oddCounter = 0;
            var lastMaterial = "";
            


            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                oddCounter++;
                if (oddCounter%2 == 1)
                {
                    lastMaterial = input;

                }
                else
                {
                    if (result.ContainsKey(lastMaterial))
                    {
                        result[lastMaterial] += int.Parse(input);
                    }
                    else
                    {
                        result[lastMaterial] = int.Parse(input);
                    }
                }
            }

            foreach (var material in result)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }

        }
    }
}