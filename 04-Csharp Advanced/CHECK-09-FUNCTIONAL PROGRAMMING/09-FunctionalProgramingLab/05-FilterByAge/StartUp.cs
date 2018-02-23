namespace _05_FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var peoples = new Dictionary<string, int>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var current = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                peoples.Add(current[0], int.Parse(current[1]));
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var printCondition = Console.ReadLine();

            var filter = GetFilter(condition, age);
            var print = GetPrinter(printCondition);

            PrintingResult(peoples, filter, print);

        }

        private static void PrintingResult(Dictionary<string, int> peoples, Func<KeyValuePair<string, int>, bool> filter,
            Action<KeyValuePair<string, int>> print)
        {
            foreach (var people in peoples)
            {
                if (filter(people))
                {
                    print(people);
                }
            }
        }

        public static Func<KeyValuePair<string, int>, bool> GetFilter(string condition, int age)
        {

            if (condition == "older")
            {
                return x => x.Value >= age;
            }
            else
            {
                return x => x.Value < age;
            }
        }

        public static Action<KeyValuePair<string, int>> GetPrinter(string printCondition)
        {
            switch (printCondition)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    throw new NotImplementedException();

            }
            
        }
    }
}