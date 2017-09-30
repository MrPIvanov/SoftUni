using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_currencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter the sum you wont to convert: ");
            double sum = double.Parse(Console.ReadLine());
            Console.Write("Now enter what currency you sell: ");
            string vhod = Console.ReadLine();
            Console.Write("Now enter what currency you buy: ");
            string izhod = Console.ReadLine();
            string BGN = "BGN";
            string USD = "USD";
            string EUR = "EUR";
            string GBP = "GBP";

            if (vhod == BGN && izhod == USD)
            {
                double result = Math.Round(sum / 1.79549, 2);
                Console.WriteLine($"The result is: {result} USD");
            }
            else if (vhod == BGN && izhod == EUR)
            {
                double result = Math.Round(sum / 1.95583, 2);
                Console.WriteLine($"The result is: {result} EUR");
            }
            else if (vhod == BGN && izhod == GBP)
            {
                double result = Math.Round(sum / 2.53405, 2);
                Console.WriteLine($"The result is: {result} GBP");
            }
            else if (vhod == USD && izhod == BGN)
            {
                double result = Math.Round(sum*1.79549, 2);
                Console.WriteLine($"The result is: {result} BGN");

            }
            else if (vhod == USD && izhod == EUR)
            {
                double result = Math.Round(sum*1.79549/1.95583, 2);
                Console.WriteLine($"The result is: {result} EUR");

            }
            else if (vhod == USD && izhod == GBP)
            {
                double result = Math.Round(sum * 1.79549/2.53405, 2);
                Console.WriteLine($"The result is: {result} GBP");

            }
            else if (vhod == EUR && izhod == BGN)
            {
                double result = Math.Round(sum*1.95583, 2);
                Console.WriteLine($"The result is: {result} BGN");

            }
            else if (vhod == EUR && izhod == USD)
            {
                double result = Math.Round(sum * 1.95583/1.79549, 2);
                Console.WriteLine($"The result is: {result} USD");

            }
            else if (vhod == EUR && izhod == GBP)
            {
                double result = Math.Round(sum * 1.95583/2.53405, 2);
                Console.WriteLine($"The result is: {result} GBP");

            }
            else if (vhod == GBP && izhod == BGN)
            {
                double result = Math.Round(sum * 2.53405, 2);
                Console.WriteLine($"The result is: {result} BGN");

            }
            else if (vhod == GBP && izhod == USD)
            {
                double result = Math.Round(sum * 2.53405/1.79549, 2);
                Console.WriteLine($"The result is: {result} USD");

            }
            else if (vhod == GBP && izhod == EUR)
            {
                double result = Math.Round(sum * 2.53405/1.95583, 2);
                Console.WriteLine($"The result is: {result} EUR");

            }
            else
            {
                Console.WriteLine("You enter a wrong currency type. Pls start again. We work only with BGN,USD,EUR,GBP.");
            }
            Console.ReadLine();

        }
    }
}
