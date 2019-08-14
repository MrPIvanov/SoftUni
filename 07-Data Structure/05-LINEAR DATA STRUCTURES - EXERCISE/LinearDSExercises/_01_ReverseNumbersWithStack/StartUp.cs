using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var stack = new Stack<int>();

        foreach (var number in numbers)
        {
            stack.Push(number);
        }

        var counter = stack.Count;
        for (int i = 0; i < counter; i++)
        {
            Console.Write($"{stack.Pop()} ");
        }
    }
}