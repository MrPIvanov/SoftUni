using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_tableOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int stoper = 0;

            for (int numberOfRows = 1; numberOfRows <= number; numberOfRows++)
            {


              


                for (int numberOfFirstColums = 1; numberOfFirstColums <= number-stoper; numberOfFirstColums++)
                {

                    
                    Console.Write($"{numberOfFirstColums+numberOfRows-1} ");



                }


                for (int numberOfSecondColums = 1; numberOfSecondColums <=stoper; numberOfSecondColums++)
                {

                    Console.Write($"{number-numberOfSecondColums} ");

                }


                stoper++;

                Console.WriteLine();



            }




        }
    }
}
