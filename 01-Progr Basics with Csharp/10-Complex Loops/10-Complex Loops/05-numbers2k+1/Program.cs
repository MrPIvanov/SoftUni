using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_numbers2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(result);

                result = result * 2 + 1;

                if (result>number)
                {
                    break;
                }

            }




        }
    }
}
