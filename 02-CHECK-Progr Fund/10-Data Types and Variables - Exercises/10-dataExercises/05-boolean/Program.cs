using System;

namespace _05_boolean
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();

            if (word=="true")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



        }
    }
}