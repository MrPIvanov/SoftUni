using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_complexLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneti1lv = int.Parse(Console.ReadLine());
            int moneti2lv = int.Parse(Console.ReadLine());
            int moneti5lv = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());



            for (int i = 0; i <= moneti1lv; i++)
            {
                for (int y = 0; y <= moneti2lv; y++)
                {

                    for (int z = 0; z <= moneti5lv; z++)
                    {
                        if (i*1+y*2+z*5==money)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {y} * 2 lv. + {z} * 5 lv. = {money} lv.");
                        }


                    }

                }

            }




        }
    }
}
