using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_tradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            bool lessThan500 = sales >= 0 && sales <= 500;
            bool lessThan1000 = sales > 500 && sales <= 1000;
            bool lessThan10000 = sales > 1000 && sales <= 10000;
            bool moreThan10000 = sales > 10000;

            double comision = -1.0;

            bool sofiaTown = town == "sofia";
            bool varnaTown = town == "varna";
            bool plovdivTown = town == "plovdiv";

            if (sofiaTown)
            {
                if (lessThan500)
                {
                    comision = 0.05;
                }
                else if (lessThan1000)
                {
                    comision = 0.07;
                }
                else if (lessThan10000)
                {
                    comision = 0.08;
                }
                else if (moreThan10000)
                {
                    comision = 0.12;
                }
            }
            else if (varnaTown)
            {
                if (lessThan500)
                {
                    comision = 0.045;
                }
                else if (lessThan1000)
                {
                    comision = 0.075;
                }
                else if (lessThan10000)
                {
                    comision = 0.1;
                }
                else if (moreThan10000)
                {
                    comision = 0.13;
                }
            }
            else if (plovdivTown)
            {
                if (lessThan500)
                {
                    comision = 0.055;
                }
                else if (lessThan1000)
                {
                    comision = 0.08;
                }
                else if (lessThan10000)
                {
                    comision = 0.12;
                }
                else if (moreThan10000)
                {
                    comision = 0.145;
                }
            }

            if (comision < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comision * sales:f2}");
            }


        }
    }
}
