using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double result = 0.0;
            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                result += num;
            }

            Console.WriteLine(result);

        }
    }
}
