using System;

namespace _03_waterOver
{
    class Program
    {
        static void Main(string[] args)
        {
            double turns = double.Parse(Console.ReadLine());
            double litres = 0;

            for (int i = 0; i < turns; i++)
            {
                double curentLitre = double.Parse(Console.ReadLine());

                if (litres+curentLitre>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litres += curentLitre;
                }

            }

            Console.WriteLine(litres);





        }
    }
}