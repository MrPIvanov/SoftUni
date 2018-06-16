using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_maxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int result = int.MinValue;

            for (int i = 0; i < numbers; i++)
            {
                int localNumber = int.Parse(Console.ReadLine());

                if (localNumber>result)
                {
                    result = localNumber;
                }
            }


            Console.WriteLine(result);

        }
    }
}
