namespace _04_FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var borders = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstNumber = borders[0];
            var lastNumber = borders[1];
            var command = Console.ReadLine();
            var allNumbers = new List<int>();
            allNumbers = Enumerable.Range(firstNumber, lastNumber - firstNumber + 1).ToList();


            switch (command)
            {
                case "odd":
                    allNumbers = allNumbers.Where(x => x % 2 != 0).ToList();
                    break;

                case "even":
                    allNumbers = allNumbers.Where(x => x % 2 == 0).ToList();
                    break;
            }
            Console.WriteLine(string.Join(" ",allNumbers));

        }
    }
}