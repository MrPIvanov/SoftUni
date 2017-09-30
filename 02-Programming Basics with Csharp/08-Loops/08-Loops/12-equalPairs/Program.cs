using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_equalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int couples = int.Parse(Console.ReadLine());

            int coupleValue = 0;
            int oldCoupleValue = 0;
            int difrence = 0;
            int bigestDifrence = 0;

            for (int i = 0; i < couples; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                coupleValue = firstNumber + secondNumber;


                if (i!=0)
                {
                    difrence = Math.Abs(oldCoupleValue - coupleValue);
                    if (difrence>bigestDifrence)
                    {
                        bigestDifrence = difrence;
                    }
                }

                oldCoupleValue = coupleValue;

            }

            if (bigestDifrence==0)
            {
                Console.WriteLine($"Yes, value={oldCoupleValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={bigestDifrence}");
            }

        }
    }
}
