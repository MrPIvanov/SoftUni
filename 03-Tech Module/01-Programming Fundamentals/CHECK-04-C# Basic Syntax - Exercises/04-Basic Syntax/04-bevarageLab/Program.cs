using System;

namespace _04_bevarageLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100 = double.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());

            double energy = energyPer100 * (volume/100);
            double sugar = sugarPer100 * (volume/100);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");


        }
    }
}