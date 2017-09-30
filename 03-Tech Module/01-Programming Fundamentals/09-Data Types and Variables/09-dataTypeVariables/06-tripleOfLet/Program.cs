using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_tripleOfLet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int z = 0; z < n; z++)
                    {
                        Console.WriteLine($"{(char)(97+i)}{(char)(97 + y)}{(char)(97 + z)}");
                    }
                }
            }





        }
    }
}
