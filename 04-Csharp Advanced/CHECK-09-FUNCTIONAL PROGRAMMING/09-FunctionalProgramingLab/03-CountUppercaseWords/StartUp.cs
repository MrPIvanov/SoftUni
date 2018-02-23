namespace _03_CountUppercaseWords
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var word in words)
            {
                if (word[0].ToString()==word[0].ToString().ToUpper())
                {
                    Console.WriteLine(word);
                }
            }


        }
    }
}