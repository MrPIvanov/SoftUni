using System;

namespace _01_blanckRec
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintTheHeader();
            PrintTheBody();
            PrintTheFooter();





        }

        static void PrintTheFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{"\u00A9"} SoftUni");


        }

        static void PrintTheBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");

        }

        static void PrintTheHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");



        }
    }
}