using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_squareRam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < number-2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();



            for (int i = 0; i < number-2; i++)
            {

                Console.Write("|");
                for (int y = 0; y < number-2; y++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();

            }




            Console.Write("+");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
