namespace _07_AdvertMessage
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var messages = int.Parse(Console.ReadLine());

            string[] phrases = {"Excellent product.",
                                "Such a great product.",
                                "I always use that product.",
                                "Best product of its category.",
                                "Exceptional product.",
                                "I can't live without this product."};

            string[] events = {"Now I feel good.",
                                "I have succeeded with this product.",
                                "Makes miracles. I am happy of the results!",
                                "I cannot believe but now I feel awesome.",
                                "Try it yourself, I am very satisfied.",
                                "I feel great!"};

            string[] authors = {"Diana",
                                "Petya",
                                "Stella",
                                "Elena",
                                "Katya",
                                "Iva",
                                "Annie",
                                "Eva"};

            string[] cities = {"Burgas",
                                "Sofia",
                                "Plovdiv",
                                "Varna",
                                "Ruse"};

            Random random = new Random();
            

            for (int i = 0; i < messages; i++)
            {
                int randomPhrases = random.Next(0, phrases.Length);
                int randomEvents = random.Next(0, events.Length);
                int randomAuthors = random.Next(0, authors.Length);
                int randomCities = random.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randomPhrases]}{events[randomEvents]}{authors[randomAuthors]} - {cities[randomCities]}");

            }


        }
    }
}