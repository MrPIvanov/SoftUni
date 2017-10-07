namespace _01_HelloName
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();

            PrintName(name);

        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}