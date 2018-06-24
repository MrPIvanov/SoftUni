namespace _02_KnightsOfHonor
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var person in input)
            {
                Console.WriteLine($"Sir {person}");
            }


        }
    }
}