namespace _01_ReverseStrings
{
    using System;
    using System.Collections;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var stack = new Stack(input);
            var count = stack.Count;

            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
