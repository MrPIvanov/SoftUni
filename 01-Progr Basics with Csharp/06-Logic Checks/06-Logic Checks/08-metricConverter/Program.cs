using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_metricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine().ToLower();
            string outputMetric = Console.ReadLine().ToLower();

            double mtomm = 1000;
            double mtocm = 100;
            double mtomi = 0.000621371192;
            double mtoin = 39.3700787;
            double mtokm = 0.001;
            double mtoft = 3.2808399;
            double mtoyd = 1.0936133;
            double mtom = 1;
            double mnojitel=1;
            double mnojitel2=1;

            switch (inputMetric)
            {
                case "mm":
                    mnojitel = 1 /mtomm;
                    break;
                case "cm":
                    mnojitel = 1 / mtocm;
                    break;
                case "mi":
                    mnojitel = 1 / mtomi;
                    break;
                case "in":
                    mnojitel = 1 / mtoin;
                    break;
                case "km":
                    mnojitel = 1 / mtokm;
                    break;
                case "ft":
                    mnojitel = 1 / mtoft;
                    break;
                case "yd":
                    mnojitel = 1 / mtoyd;
                    break;
                case "m":
                    mnojitel = 1 / mtom;
                    break;
            }

            switch (outputMetric)
            {
                case "mm":
                    mnojitel2 = mtomm;
                    break;
                case "cm":
                    mnojitel2 = mtocm;
                    break;
                case "mi":
                    mnojitel2 = mtomi;
                    break;
                case "in":
                    mnojitel2 = mtoin;
                    break;
                case "km":
                    mnojitel2 = mtokm;
                    break;
                case "ft":
                    mnojitel2 = mtoft;
                    break;
                case "yd":
                    mnojitel2 = mtoyd;
                    break;
                case "m":
                    mnojitel2 = mtom;
                    break;

            }
            Console.WriteLine(Math.Round(input*mnojitel*mnojitel2, 8));



        }
    }
}
