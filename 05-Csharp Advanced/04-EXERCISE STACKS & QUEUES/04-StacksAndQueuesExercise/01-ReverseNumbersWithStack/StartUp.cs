namespace _01_ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            var count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }

        }
    }
}
