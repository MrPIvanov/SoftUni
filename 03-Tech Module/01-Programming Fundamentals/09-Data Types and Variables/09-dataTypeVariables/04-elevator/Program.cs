using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                result++;

                if (numberOfPeople<=capacity)
                {
                    Console.WriteLine($"{result}");
                    break;
                }

                else
                {
                    numberOfPeople -= capacity;
                }
            }



        }
    }
}
