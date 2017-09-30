using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_numberBetween1to100
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= int.MaxValue; i++)
            {
                int number = int.Parse(Console.ReadLine());


                if (number>=1 && number<=100)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
                
            }




        }
    }
}
