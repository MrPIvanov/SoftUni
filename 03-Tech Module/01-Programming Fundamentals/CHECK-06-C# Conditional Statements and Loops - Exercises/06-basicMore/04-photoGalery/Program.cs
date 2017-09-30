using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_photoGalery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            double size = double.Parse(Console.ReadLine());

            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());






            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{min:d2}");
            if (size<1000)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size<1000000)
            {
                Console.WriteLine($"Size: {size/1000}KB");
            }
            else
            {
                size = size / 1000000;
                Console.WriteLine($"Size: {size}MB");
            }
            string picture = "portrait";

            if (sideA>sideB)
            {
                picture = "landscape";
            }
            else if (sideA==sideB)
            {
                picture = "square";
            }

            Console.WriteLine($"Resolution: {sideA}x{sideB} ({picture})");

        }
    }
}
