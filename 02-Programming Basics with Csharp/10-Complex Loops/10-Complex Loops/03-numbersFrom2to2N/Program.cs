using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_numbersFrom2to2N
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 1;


            for (int i = 0; i <= number; i++)
            {
                
                Console.WriteLine(result);
                result *= 2;

            }



        }
    }
}
