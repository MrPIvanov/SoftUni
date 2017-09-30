using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_cakeIngrea
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string currentIngreadient = Console.ReadLine();

                if (currentIngreadient=="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
                counter++;


                Console.WriteLine($"Adding ingredient {currentIngreadient}.");
            }




        }
    }
}
