namespace _04_AddVAT
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToList();


            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }


        }
    }
}