using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int bigestNumber = int.MinValue;

            int totalNumbers = 0;

            for (int i = 0; i < numbers; i++)
            {
                int localNumber = int.Parse(Console.ReadLine());

                if (localNumber>bigestNumber)
                {
                    bigestNumber = localNumber;
                }

                totalNumbers += localNumber;
            }

            if (bigestNumber==totalNumbers-bigestNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {bigestNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(totalNumbers-bigestNumber-bigestNumber)}");
            }


        }
    }
}
