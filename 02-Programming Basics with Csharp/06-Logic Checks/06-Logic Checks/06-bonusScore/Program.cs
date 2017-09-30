using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_bonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            double bonusPoints = 0;


            if (number <= 100)

            {
                bonusPoints += 5;
            }

            if (number % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (number % 10 == 5)
            {
                bonusPoints += 2;
            }

            if (number > 1000)
            {
                bonusPoints = (number * 0.1) + bonusPoints;
            }
            else if (number > 100)
            {
                bonusPoints = (number * 0.2) + bonusPoints;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + number);



        }
    }
}
