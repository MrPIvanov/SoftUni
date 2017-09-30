using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IntOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = 1;
            int minNumber = 1;

            if (firstNumber>secondNumber)
            {
                maxNumber = firstNumber;
                minNumber = secondNumber;
            }
            else
            {
                maxNumber = secondNumber;
                minNumber = firstNumber;
            }


            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
