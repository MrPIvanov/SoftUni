namespace _07_BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var brackets = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                if (letter=='{' || letter == '(' || letter == '[')
                {
                    brackets.Push(letter);
                }
                else
                {
                    char opositeBracket  = 't';
                    switch (letter)
                    {
                        case ')':
                            opositeBracket = '(';
                            break;
                        case '}':
                            opositeBracket = '{';
                            break;
                        case ']':
                            opositeBracket = '[';
                            break;
                    }

                    if (brackets.Count==0)
                    {
                        isBalanced = false;
                        break;
                    }
                    if (opositeBracket==brackets.Peek())
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
