using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double holidays = double.Parse(Console.ReadLine());
            double roadWeekends = double.Parse(Console.ReadLine());

            double playTime = ((48 - roadWeekends) * 0.75) +roadWeekends+((holidays*2)/3);

            if (year == "leap")
            {
                playTime *= 1.15;
            }

            Console.WriteLine($"{Math.Floor(playTime)}");

        }
    }
}
