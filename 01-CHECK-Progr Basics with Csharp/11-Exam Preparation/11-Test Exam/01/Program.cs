using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceYiski = double.Parse(Console.ReadLine());
            double beerLitre = double.Parse(Console.ReadLine());
            double wineLitre = double.Parse(Console.ReadLine());
            double rakiaLitre = double.Parse(Console.ReadLine());
            double yiskiLitre = double.Parse(Console.ReadLine());


            double priceRakia = 0.5 * priceYiski;
            double priceWine = 0.6 * priceRakia;
            double priceBeer = 0.2 * priceRakia;

            double result = (beerLitre * priceBeer) + (wineLitre*priceWine) + (rakiaLitre*priceRakia) + (yiskiLitre*priceYiski);

            Console.WriteLine($"{result:f2}");


        }
    }
}
