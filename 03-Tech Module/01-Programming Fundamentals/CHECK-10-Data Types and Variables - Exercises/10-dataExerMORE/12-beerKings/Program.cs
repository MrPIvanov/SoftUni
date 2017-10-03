using System;

namespace _12_beerKings
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfKegs = int.Parse(Console.ReadLine());

            string endString = "";
            double maxVolume = 0.0;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string name = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                if (Math.PI*radius*radius*height>maxVolume)
                {
                    maxVolume = Math.PI * radius * radius * height;
                    endString = name;


                }


            }




            Console.WriteLine(endString);




        }
    }
}