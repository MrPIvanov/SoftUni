using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter the sum in USD dollars: ");
            double dolars = double.Parse(Console.ReadLine());
            double leva =dolars * 1.79549;
            Console.WriteLine($"The sum in BGN is: {Math.Round(leva, 2)}");
            Console.ReadLine();

        }
    }
}
