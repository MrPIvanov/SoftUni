namespace _02_IndexOfLetters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.WriteLine($"{letter} -> {(int)letter-97}");
            }


        }
    }
}