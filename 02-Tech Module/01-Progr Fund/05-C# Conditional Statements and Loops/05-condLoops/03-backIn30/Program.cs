using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_backIn30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;

            if (min>=60)
            {
                hours++;
                min -= 60;
            }
            if (hours==24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{min:d2}");
        }
    }
}
