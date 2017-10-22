namespace _05_ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandParts = command.Split().ToArray();


                if (commandParts[0] == "add")
                {
                    numbers.Insert(int.Parse(commandParts[1]), int.Parse(commandParts[2]));

                }

                else if (commandParts[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandParts[1]), commandParts.Skip(2).Select(int.Parse).ToList());

                }
                else if (commandParts[0] == "contains")
                {
                    Console.WriteLine($"{numbers.IndexOf(int.Parse(commandParts[1]))}");

                }
                else if (commandParts[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandParts[1]));

                }
                else if (commandParts[0] == "shift")
                {
                    int possitions = int.Parse(commandParts[1]) % numbers.Count;
                    int[] reminders = numbers.Take(possitions).ToArray();
                    numbers.RemoveRange(0, possitions);
                    numbers.AddRange(reminders);
                }
                else if (commandParts[0] == "sumPairs")
                {

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        int sum = (numbers[i] + numbers[i + 1]);
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}