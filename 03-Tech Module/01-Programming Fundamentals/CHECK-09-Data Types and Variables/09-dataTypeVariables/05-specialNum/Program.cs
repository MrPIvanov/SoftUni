using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_specialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                int curentNumber = i;
                int curent = 0;

                for (int y = 0; y < int.MaxValue; y++)
                {
                    curent += curentNumber % 10;

                    curentNumber /= 10;

                    if (curentNumber == 0)
                    {
                        break;
                    }
                }


                if (curent==7||curent==5||curent==11)
                {
                    Console.WriteLine($"{i} -> True");
                }

                else
                {
                    Console.WriteLine($"{i} -> False");

                }







            }





        }
    }
}
