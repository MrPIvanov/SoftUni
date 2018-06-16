using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_oddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 1;
            for (int i = 0; i < number; i++)
            {
                sum += counter;
                Console.WriteLine(counter);
                counter += 2;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
