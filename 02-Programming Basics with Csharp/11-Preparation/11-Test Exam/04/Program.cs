using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumSeats = double.Parse(Console.ReadLine());
            double fensNumber = double.Parse(Console.ReadLine());

            double Afens = 0;
            double Bfens = 0;
            double Vfens = 0;
            double Gfens = 0;

            for (int i = 0; i < fensNumber; i++)
            {
                string sector = Console.ReadLine().ToUpper();

                if (sector=="A")
                {
                    Afens++;
                }
                else if (sector=="B")
                {
                    Bfens++;
                }

                else if (sector=="V")
                {
                    Vfens++;

                }
                else if (sector=="G")
                {
                    Gfens++;
                }

            }


            double A =100*(Afens/fensNumber);
            double B = 100 * (Bfens / fensNumber);
            double V = 100 * (Vfens / fensNumber);
            double G = 100 * (Gfens / fensNumber);
            double All = 100 * (fensNumber/stadiumSeats);


            Console.WriteLine($"{A:f2}%");
            Console.WriteLine($"{B:f2}%");
            Console.WriteLine($"{V:f2}%");
            Console.WriteLine($"{G:f2}%");
            Console.WriteLine($"{All:f2}%");







        }
    }
}
