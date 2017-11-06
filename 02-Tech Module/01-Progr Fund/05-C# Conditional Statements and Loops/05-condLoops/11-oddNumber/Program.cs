using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_oddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.MaxValue; i++)
            {
                if (number%2==0)
                {
                    Console.WriteLine("Please write an odd number.");
                    number = int.Parse(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }

            }


        }
    }
}
