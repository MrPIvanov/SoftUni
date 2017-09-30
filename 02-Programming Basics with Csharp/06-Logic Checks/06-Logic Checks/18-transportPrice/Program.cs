using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();

            double taxiDay = 0.70 + 0.79 * km;
            double taxiNight = 0.70 + 0.90 * km;
            double bus = 0.09 * km;
            double train = 0.06 * km;

            if (time=="day")
            {
                if (km<20)
                {
                    Console.WriteLine(taxiDay);
                }
                else if (km<100)
                {
                    Console.WriteLine(bus);
                }
                else
                {
                    Console.WriteLine(train);
                }


            }
            else if (time=="night")
            {
                if (km < 20)
                {
                    Console.WriteLine(taxiNight);
                }
                else if (km < 100)
                {
                    Console.WriteLine(bus);
                }
                else
                {
                    Console.WriteLine(train);
                }
            }
            else
            {
                Console.WriteLine("Wrong Input !!!");
            }




        }
    }
}
