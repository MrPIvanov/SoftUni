using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_magicLette
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char noComb = char.Parse(Console.ReadLine());


            for (int i = begin; i <= end; i++)
            {

                for (int y = begin; y <= end; y++)
                {





                    for (int z = begin; z <= end; z++)
                    {

                        if (i==noComb||y==noComb||z==noComb)
                        {
                            continue;
                        }


                        Console.Write($"{(char)i}{(char)y}{(char)z} ");
                    }
                }
            }




        }
    }
}
