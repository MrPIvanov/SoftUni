namespace _02_SimpleCalculator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Reverse();

            var stack = new Stack<string>(input);

            while (stack.Count>1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operand = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                switch (operand)
                {
                    case "+":
                        var result = firstNumber + secondNumber;
                        stack.Push(result.ToString());
                        break;
                    case "-":
                        var result2 = firstNumber - secondNumber;
                        stack.Push(result2.ToString());
                        break;
                }


            }

            Console.WriteLine(stack.Pop());
        }
    }
}
