using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_piraminOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i < int.MaxValue; i++)
            {

                for (int y = 1; y <= i; y++)
                {
                    count += 1;
                    Console.Write($"{count} ");

                    if (count==number)
                    {
                        break;

                    }
                   
                    
                }
                Console.WriteLine();
                if (count==number)
                {
                    break;
                }


            }


        }
    }
}
