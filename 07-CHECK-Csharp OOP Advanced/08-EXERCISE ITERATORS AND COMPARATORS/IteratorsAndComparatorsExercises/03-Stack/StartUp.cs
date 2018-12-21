using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var customStack = new CustomStack();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            if (command=="Pop")
            {
                customStack.Pop();
            }
            else
            {
                var argsStrings = command.Split().Skip(1).ToArray();
                var argsInt = string.Join("", argsStrings).Split(",").Select(int.Parse).ToArray();

                foreach (var item in argsInt)
                {
                    customStack.Push(item);
                }

            }
        }

        foreach (var item in customStack)
        {
            Console.WriteLine(item);
        }
        foreach (var item in customStack)
        {
            Console.WriteLine(item);
        }
    }
}