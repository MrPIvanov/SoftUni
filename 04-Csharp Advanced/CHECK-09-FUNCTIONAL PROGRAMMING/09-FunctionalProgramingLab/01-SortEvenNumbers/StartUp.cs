namespace _01_SortEvenNumbers
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .Where(x => x % 2 == 0)
               .ToList()
               .OrderBy(x=>x);

            Console.Write(string.Join(", ", numbers));


                


        }
    }
}