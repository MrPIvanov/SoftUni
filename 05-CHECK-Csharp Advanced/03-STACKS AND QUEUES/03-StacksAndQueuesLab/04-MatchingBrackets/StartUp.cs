namespace _04_MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var input = str.ToCharArray();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }

                if (input[i]==')')
                {
                    Console.WriteLine(str.Substring(stack.Peek(),i-stack.Pop()+1));
                }


            }



        }
    }
}
