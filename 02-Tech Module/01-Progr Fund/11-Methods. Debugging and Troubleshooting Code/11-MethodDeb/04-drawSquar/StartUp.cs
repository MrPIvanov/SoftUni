using System;

namespace _04_drawSquar
{
    class StartUp

    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopAndBottomRows(number);
            for (int i = 0; i < number-2; i++)
            {
                PrintMidlePart(number);

            }



            PrintTopAndBottomRows(number);



        }

        static void PrintMidlePart(int countOfMidleSymbols)
        {
            Console.Write("-");
            for (int i = 0; i < countOfMidleSymbols-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }

        static void PrintTopAndBottomRows(int symbolCount)
        {

            Console.WriteLine(new string('-', 2* symbolCount));


        }
    }
}