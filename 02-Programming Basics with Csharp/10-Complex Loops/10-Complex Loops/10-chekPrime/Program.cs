using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_chekPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = "Prime";

            if (number<2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        result = "Not Prime";
                        break;
                    }

                }
            }

            Console.WriteLine(result);
        }
    }
}
