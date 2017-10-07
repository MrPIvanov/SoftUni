using System;

namespace _11_stringConc
{
    class Program
    {
        static void Main(string[] args)
        {

            char separator = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine().ToLower();
            int lines = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= lines; i++)
            {
                string currentWord = Console.ReadLine();

                if (evenOdd=="odd")
                {
                    if (i%2!=0)
                    {
                        result += currentWord;
                        result += separator;
                    }

                }

                else
                {
                    if (i%2==0)
                    {
                        result += currentWord;
                        result += separator;
                    }
                }

            }


            result = result.Remove(result.Length-1,1);

            Console.WriteLine(result);





        }
    }
}