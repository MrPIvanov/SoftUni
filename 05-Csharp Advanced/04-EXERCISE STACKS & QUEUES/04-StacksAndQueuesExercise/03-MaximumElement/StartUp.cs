namespace _03_MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numberOfInputLines = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxStack = new Stack<int>();
            var maxElement = int.MinValue;

            for (int i = 0; i < numberOfInputLines; i++)
            {
                var lineOfInput = Console.ReadLine().Split();
                var command = lineOfInput[0];

                switch (command)
                {
                    case "1":
                        var element = int.Parse(lineOfInput[1]);

                        if (element>maxElement)
                        {
                            maxElement = element;
                            maxStack.Push(maxElement);
                        }

                        stack.Push(element);

                        break;

                    case "2":
                        if (stack.Peek() == maxElement)
                        {
                            maxStack.Pop();
                            maxElement = maxStack.Peek();
                        }

                        stack.Pop();

                        break;

                    case "3":
                        Console.WriteLine(maxStack.Peek());
                        break;
                }

            }


        }
    }
}
