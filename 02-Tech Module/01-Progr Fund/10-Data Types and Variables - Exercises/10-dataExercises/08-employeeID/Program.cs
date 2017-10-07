using System;

namespace _08_employeeID
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long idNumber = long.Parse(Console.ReadLine());
            long number = long.Parse(Console.ReadLine());


            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {idNumber}");
            Console.WriteLine($"Unique Employee number: {number}");






        }
    }
}