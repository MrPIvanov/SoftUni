using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_numberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string znak = Console.ReadLine();

            if (znak =="+")
            {
                double result = firstNumber + secondNumber;
                string oddOrEven = "odd";
                if (result%2==0)
                {
                    oddOrEven = "even";
                }
                Console.WriteLine($"{firstNumber} {znak} {secondNumber} = {firstNumber+secondNumber} - {oddOrEven}");
            }
            else if (znak=="-")
            {
                double result = firstNumber - secondNumber;
                string oddOrEven = "odd";
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                Console.WriteLine($"{firstNumber} {znak} {secondNumber} = {firstNumber - secondNumber} - {oddOrEven}");
            }
            else if (znak == "*")
            {
                double result = firstNumber * secondNumber;
                string oddOrEven = "odd";
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                Console.WriteLine($"{firstNumber} {znak} {secondNumber} = {firstNumber * secondNumber} - {oddOrEven}");
            }
            else if (znak == "/")
            {
                if (secondNumber==0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {znak} {secondNumber} = {firstNumber/secondNumber:f2}");
                }
            }
            else if (znak == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} {znak} {secondNumber} = {firstNumber % secondNumber}");
                }
            }






        }
    }
}
