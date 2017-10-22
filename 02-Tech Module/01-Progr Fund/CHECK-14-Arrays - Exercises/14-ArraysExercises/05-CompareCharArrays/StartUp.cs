namespace _05_CompareCharArrays
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');


            string firstWord = string.Join("", firstArray);
            string secondWord = string.Join("", secondArray);

            if (firstWord.CompareTo(secondWord) <= 0)
            {
                Console.WriteLine(firstWord);
                Console.WriteLine(secondWord);
            }
            else
            {
                Console.WriteLine(secondWord);
                Console.WriteLine(firstWord);
            }

        }
    }
}
