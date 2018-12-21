using System;

public class StartUp
{
    static void Main()
    {
        var numberOfCommands = int.Parse(Console.ReadLine());
        var customList = new CustomLinkedList<int>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            var commandArgs = Console.ReadLine().Split();
            var command = commandArgs[0];
            var value = int.Parse(commandArgs[1]);

            switch (command)
            {
                case "Add":
                    customList.Add(value);
                    break;

                case "Remove":
                    customList.Remove(value);
                    break;
            }
        }

        Console.WriteLine(customList.Count);
        Console.WriteLine(string.Join(" ", customList));
    
    }
}