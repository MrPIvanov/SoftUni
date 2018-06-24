namespace _03_CustomMinFunction
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(numbers.Min());


        }
    }
}