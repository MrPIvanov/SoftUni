namespace _07_PredicateForNames
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var lengthToCheck = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();

            Func<string, bool> nameLengthChecker = x => x.Length <= lengthToCheck;

            foreach (var name in names.Where(nameLengthChecker))
            {
                Console.WriteLine(name);
            }


        }
    }
}