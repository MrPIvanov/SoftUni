using System;

namespace _05_OnlyLetters
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var number = 0;
            var numberInARow = 0;
            bool wasANumber = false;

            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    number = int.Parse(text[i].ToString());
                    numberInARow++;
                    wasANumber = true;

                }
                catch (Exception)
                {
                    if (wasANumber)
                    {
                        wasANumber = false;
                        numberInARow = 0;

                        Console.Write($"{text[i]}");
                    }
                    Console.Write($"{text[i]}");
                    
                }

            }

            if (wasANumber)
            {
                Console.WriteLine(text.Substring(text.Length-numberInARow));
            }


        }
    }
}