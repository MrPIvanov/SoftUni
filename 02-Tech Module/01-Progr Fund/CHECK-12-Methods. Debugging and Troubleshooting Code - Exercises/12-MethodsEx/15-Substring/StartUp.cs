namespace _15_Substring
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int symbolsToWrite = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int length = symbolsToWrite + 1;

                    string matchedString;

                    if (i + length <= text.Length)
                    {
                        matchedString = text.Substring(i, length);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }

                    Console.WriteLine(matchedString);

                    i += symbolsToWrite;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}