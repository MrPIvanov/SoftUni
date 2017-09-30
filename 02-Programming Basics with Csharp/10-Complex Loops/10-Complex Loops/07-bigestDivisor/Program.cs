using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_bigestDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int bigNumber = 1;
            int smallNumber = 1;
            int result = 1; 

            if (a>b)
            {
                bigNumber = a;
                smallNumber = b;
            }
            else
            {
                bigNumber = b;
                smallNumber = a;
            }

            while (bigNumber%smallNumber!=0)
            {
                result = bigNumber % smallNumber;
                bigNumber = smallNumber;
                smallNumber = result;
            }

            Console.WriteLine(smallNumber);

        }
    }
}
