using System;

namespace _08_houseBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());


            if (price1>price2)
            {
                Console.WriteLine($"{((4*price2)+(10*price1))}");
            }

            else
            {
                Console.WriteLine($"{((4*price1)+(10*price2))}");
            }



        }
    }
}