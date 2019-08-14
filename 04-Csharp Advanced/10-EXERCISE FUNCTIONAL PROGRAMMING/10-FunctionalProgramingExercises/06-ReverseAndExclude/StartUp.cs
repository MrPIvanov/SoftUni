namespace _06_ReverseAndExclude
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            var numberToDivide = int.Parse(Console.ReadLine());

            Func<decimal, bool> dividerCheck = x => x / numberToDivide != (int)x / numberToDivide;

            numbers.Reverse();
            numbers = numbers.Where(dividerCheck).ToList();

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}