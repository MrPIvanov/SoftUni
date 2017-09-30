using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_backToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double allMoney = double.Parse(Console.ReadLine());
            double yearToLive = double.Parse(Console.ReadLine());

            int yearTimer = 17;

            for (int i = 1800; i <= yearToLive; i++)
            {
                yearTimer++;

                if (i%2==0)
                {
                    allMoney -= 12000;
                }
                else
                {
                    allMoney = allMoney - (12000+(yearTimer*50));
                }


            }

            if (allMoney>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {allMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(allMoney):f2} dollars to survive.");
            }

        }
    }
}
