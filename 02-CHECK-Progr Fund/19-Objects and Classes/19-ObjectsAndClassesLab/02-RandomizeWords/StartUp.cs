using System;
using System.Linq;

namespace _02_RandomizeWords
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();

            var randomNumber = new Random();
            var loopCounter = input.Count;


            for (int i = 0; i < loopCounter; i++)
            {
                var index = randomNumber.Next(0, input.Count);

                Console.WriteLine(input[index]);
                input.RemoveAt(index);
            }

            


        }
    }
}