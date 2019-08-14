using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_dailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {

            double workDays = double.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double dolarMargin = double.Parse(Console.ReadLine());

            double result = ((((workDays * dailyProfit) * 14.5) * 0.75) * dolarMargin) / 365;
            Console.WriteLine(Math.Round(result,2));
            Console.ReadLine();






        }
    }
}
