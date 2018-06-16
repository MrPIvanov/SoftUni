using System;

namespace _01_Censorship
{
    public class StartUp
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            Console.WriteLine(text.Replace(word,new string('*',word.Length)));


        }
    }
}