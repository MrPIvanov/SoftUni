using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine($"Hello, {first} {last}. You are {age} years old.");




        }
    }
}
