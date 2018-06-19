namespace _02_BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine().Split();
            var pushElements = int.Parse(inputNumbers[0]);
            var popElements = int.Parse(inputNumbers[1]);
            var numberToSearch = int.Parse(inputNumbers[2]);

            var allNUmbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numbersStack = new Stack<int>(allNUmbers);

            for (int i = 0; i < popElements; i++)
            {
                numbersStack.Pop();
            }

            if (numbersStack.Contains(numberToSearch))
            {
                Console.WriteLine("true");
            }
            else if (numbersStack.Count ==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbersStack.Min());
            }
        }
    }
}
