using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());

            if (movie=="premiere")
            {
                double result = row * colum * 12;
                Console.WriteLine($"{result:f2}");
            }
            else if (movie=="normal")
            {
                double result = row * colum * 7.5;
                Console.WriteLine($"{result:f2}");
            }
            else if (movie=="discount")
            {
                double result = row * colum * 5;
                Console.WriteLine($"{result:f2}");
            }




        }
    }
}
