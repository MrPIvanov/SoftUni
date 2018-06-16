namespace _03_DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if (number==0)
            {
                Console.WriteLine(number);
            }

            while (number>0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            var count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());

            }
        }
    }
}
