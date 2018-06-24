namespace _05_AppliedArithmetics
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            Func<int, int> add = x => x + 1;
            Func<int, int> multi = x => x * 2;
            Func<int, int> substract = x => x - 1;
            Action<int> print = x => Console.Write($"{x.ToString()} ");

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(add).ToList();
                        break;

                    case "multiply":
                        numbers = numbers.Select(multi).ToList();
                        break;

                    case "subtract":
                        numbers = numbers.Select(substract).ToList();
                        break;

                    case "print":
                        numbers.ForEach(print);
                        Console.WriteLine();
                        break;
                }

            }


        }
    }
}