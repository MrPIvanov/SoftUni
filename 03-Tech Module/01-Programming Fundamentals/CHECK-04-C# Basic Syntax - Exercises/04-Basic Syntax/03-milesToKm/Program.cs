using System;

namespace _03_milesToKm
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(number* 1.60934):f2}");



        }
    }
}