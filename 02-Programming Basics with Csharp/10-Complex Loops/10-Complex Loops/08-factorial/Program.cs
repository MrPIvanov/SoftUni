using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);

        }
    }
}
