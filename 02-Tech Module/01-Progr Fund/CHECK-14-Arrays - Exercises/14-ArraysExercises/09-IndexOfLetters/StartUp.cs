namespace _09_IndexOfLetters
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            char[] inputChars = input.ToCharArray();

            char[] letters = new char[26];

            for (int i = 97; i <= 122; i++)
            {
                letters[i - 97] = (char)i;
            }


            for (int i = 0; i < inputChars.Length; i++)
            {
                for (int y = 0; y < letters.Length; y++)
                {
                    if (inputChars[i]==letters[y])
                    {
                        Console.WriteLine($"{letters[y]} -> {y}");


                    }


                }
            }

        }
    }
}