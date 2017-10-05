using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_logicChecks
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInBGN = double.Parse(Console.ReadLine());
            double averageSucseed = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double social = 0;
            double highSucseed = 0;

            if (averageSucseed>4.5&&moneyInBGN<minSalary)
            {
                social = Math.Floor(0.35 * minSalary);
            }

            if (averageSucseed>=5.5)
            {
                highSucseed = Math.Floor(averageSucseed * 25);
            }

            if (social==0&&highSucseed==0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (social>highSucseed)
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {highSucseed} BGN");
            }


        }
    }
}
