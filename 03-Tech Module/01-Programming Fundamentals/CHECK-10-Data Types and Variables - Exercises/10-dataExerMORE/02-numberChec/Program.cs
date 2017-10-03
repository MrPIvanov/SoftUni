using System;

namespace _02_numberChec
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            if (Math.Ceiling(number)-number==0)
            {
                Console.WriteLine("integer");
            }

            else
            {
                Console.WriteLine("floating-point");
            }






        }
    }
}