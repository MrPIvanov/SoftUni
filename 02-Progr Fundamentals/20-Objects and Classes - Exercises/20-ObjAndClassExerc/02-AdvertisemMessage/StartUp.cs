using System;

namespace _02_AdvertisemMessage
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

           string[] phrases = {"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};
            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };
            string[] cities = { "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" };


            Random rnd = new Random();
            

            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine($"{phrases[rnd.Next(0, phrases.Length)]} {events[rnd.Next(0, events.Length)]} " +
                    $"{authors[rnd.Next(0, authors.Length)]} {cities[rnd.Next(0, cities.Length)]}");
            }

        }
    }
}