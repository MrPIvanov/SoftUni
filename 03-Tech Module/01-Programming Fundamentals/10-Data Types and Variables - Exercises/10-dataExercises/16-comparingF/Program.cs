using System;

namespace _16_comparingF
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());


            double difrence = 0.000001;

            if (Math.Abs(firstNumber - secondNumber) == difrence)
            {
                Console.WriteLine($"False");
            }


            else if (Math.Abs(firstNumber - secondNumber) < difrence)
            {

                Console.WriteLine($"True");

            }

            else
            {
                Console.WriteLine($"False");
            }



        }
    }
}