using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_even2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i <= number/2; i++)
            {
                Console.WriteLine(result);
                result *= 4;
            }



        }
    }
}
