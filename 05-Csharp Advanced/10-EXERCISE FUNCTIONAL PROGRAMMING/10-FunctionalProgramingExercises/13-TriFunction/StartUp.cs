namespace _13_TriFunction
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numberToCheck = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();

            names = names.Where(x =>
            {
                var tempSum = 0;
                foreach (var letter in x)
                {
                    tempSum += letter;
                }
                return tempSum >= numberToCheck;

            })
            .ToList();


            if (names.Count()>0)
            {
                Console.WriteLine(names[0]);
            }
        }
    }
}