using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_sleepyCatTom
{
    class Program
    {
        static void Main(string[] args)
        {

            int restDays = int.Parse(Console.ReadLine());

            int playMin = ((365 - restDays) * 63) + (restDays * 127);

            if (playMin<30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000-playMin)/60} hours and {(30000 - playMin) % 60} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(playMin-30000)/60} hours and {(playMin - 30000) % 60} minutes more for play");
            }


        }
    }
}
