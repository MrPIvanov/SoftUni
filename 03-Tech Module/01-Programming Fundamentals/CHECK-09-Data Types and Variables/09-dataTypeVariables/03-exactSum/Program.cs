using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_exactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int n = 0; n < numbers; n++)
            {
                decimal curentNumber = decimal.Parse(Console.ReadLine());

                result += curentNumber;
            }

            Console.WriteLine(result);


        }
    }
}
