using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_neightWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());

            int peshoHP = 100;
            int goshoHP = 100;


            for (int i = 1; i < int.MaxValue; i++)
            {


                if (i%2!=0)
                {

                    //pesho atack
                    if (goshoHP-peshoDMG<=0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP-peshoDMG} health.");
                    goshoHP -= peshoDMG;

                }
                else
                {
                    //gosho atack

                    if (peshoHP-goshoDMG<=0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP-goshoDMG} health.");
                    peshoHP -= goshoDMG;
                }


                if (i%3==0)
                {
                    peshoHP += 10;
                    goshoHP += 10;
                    //heal

                }

            }




        }
    }
}
