namespace _06_ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');


            Console.WriteLine(string.Join(" ", array.Reverse()));


        }
    }
}