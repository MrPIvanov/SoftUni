namespace _01_ActionPoint
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            input.ForEach(x => Console.WriteLine(x));
        }
    }
}