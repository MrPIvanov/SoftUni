using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_complexConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPhotos = double.Parse(Console.ReadLine());
            string photosType = Console.ReadLine().ToLower();
            string orderType = Console.ReadLine().ToLower();


            double priceForPicture = 0.0;

            double result = 0.0;
            double mnojitel = 1;

            if (photosType=="9x13")
            {

                priceForPicture = 0.16;

                if (numberOfPhotos>=50)
                {
                    mnojitel = 0.95;
                }



            }




            else if (photosType=="10x15")
            {
                priceForPicture =0.16;

                if (numberOfPhotos>=80)
                {
                    mnojitel =0.97;
                }
            }
            else if (photosType=="13x18")
            {
                priceForPicture = 0.38;

                if (numberOfPhotos>100)
                {
                    mnojitel = 0.95;
                }

                else if (numberOfPhotos>=50)
                {
                    mnojitel = 0.97;
                }


            }
            else if (photosType=="20x30")
            {
                priceForPicture = 2.9;

                if (numberOfPhotos>50)
                {
                    mnojitel =0.91;
                }

                else if (numberOfPhotos>=10)
                {
                    mnojitel =0.93;
                }
            }


            result = mnojitel * (numberOfPhotos*priceForPicture);

            if (orderType=="online")
            {
                result *= 0.98;
            }

            Console.WriteLine($"{result:f2}BGN");

        }
    }
}
