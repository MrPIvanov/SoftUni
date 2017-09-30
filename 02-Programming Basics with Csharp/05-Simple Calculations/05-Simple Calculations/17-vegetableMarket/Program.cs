using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_vegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price of the vegetables?: ");
            double vegetablePrice = double.Parse(Console.ReadLine());
            Console.Write("Enter the price of the fruits?: ");
            double fruitsPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter how many weight are the vegetables?: ");
            double vegetableWeight = double.Parse(Console.ReadLine());
            Console.Write("Enter how many weight are the fruits?: ");
            double fruitsWeight = double.Parse(Console.ReadLine());

            double vegetableProfit = (vegetablePrice * vegetableWeight)/1.94;
            double fruitProfit = (fruitsWeight*fruitsPrice) / 1.94;
            Console.WriteLine($"Your total profit in EUR will be { Math.Round(vegetableProfit + fruitProfit, 2)}!!!");
            Console.ReadLine();

        }
    }
}
