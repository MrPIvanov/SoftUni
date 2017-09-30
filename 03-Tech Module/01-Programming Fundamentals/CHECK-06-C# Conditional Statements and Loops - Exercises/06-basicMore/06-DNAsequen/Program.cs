using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DNAsequen
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string xo = "X";


            


            for (int i = 0; i <= 3; i++)
            {

                for (int y = 0; y <= 3; y++)
                {

                    for (int z = 0; z <= 3; z++)
                    {
                        string[] curentSymbol = { "A","C","G","T"};

                        if (3+i+y+z>=number)
                        {
                            xo = "O";
                        }
                        else
                        {
                            xo = "X";
                        }
                            Console.Write($"{xo}{curentSymbol[i]}{curentSymbol[y]}{curentSymbol[z]}{xo} ");

                    }
                    Console.WriteLine();


                }
            }

        }
    }
}
