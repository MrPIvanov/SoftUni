using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_gameOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int test1 = 1;
            int test2 = 1;

            int counter = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {

                for (int y = firstNumber; y <= secondNumber; y++)
                {
                    test1 = i;
                    test2 = y;
                    if (i+y==magicNumber)
                    {
                        Console.WriteLine($"Number found! {y} + {i} = {i+y}");

                        break;

                    }

                    counter++;

                }

                if (i + test2 == magicNumber)
                {
                    //Console.WriteLine($"Number found! {i} + {y} = {i + y}");

                    break;

                }

            }

            if (test2+test1!=magicNumber)
            {
                Console.Write($"{counter} combinations - ");
                Console.WriteLine($"neither equals {magicNumber}");
            }
        }
    }
}
