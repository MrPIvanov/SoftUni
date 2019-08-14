using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("$");
                for (int y = 1; y < i; y++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }



        }
    }
}
