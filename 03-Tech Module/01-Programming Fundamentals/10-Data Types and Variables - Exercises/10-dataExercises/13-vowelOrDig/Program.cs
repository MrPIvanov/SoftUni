using System;

namespace _13_vowelOrDig
{
    class Program
    {
        static void Main(string[] args)
        {

            char symbol = char.Parse(Console.ReadLine());

            if (symbol=='0'||symbol=='1'||symbol == '2' || symbol == '3'||symbol == '4' || symbol == '5'||symbol == '6' || symbol == '7'
                    ||symbol == '8' || symbol == '9')
            {
                Console.WriteLine("digit");
            }

            else if (symbol=='a'|| symbol == 'o' || symbol == 'u' || symbol == 'y' || symbol == 'e' || symbol == 'q'||symbol=='i')
            {
                Console.WriteLine("vowel");


            }


            else
            {
                Console.WriteLine("other");
            }
        }

    }
}