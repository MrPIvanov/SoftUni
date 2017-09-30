using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int i = M; i >= 1; i--)
            {

                for (int y = N; y >= 1; y--)
                {

                    for (int z = L; z >=1 ; z--)
                    {

                        int currentNumber = i * 100 + y * 10 + z;



                        if (currentNumber % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (currentNumber % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (currentNumber % 2 == 0)
                        {
                            specialNumber *= 2;
                        }


                        if (specialNumber >= controlNumber)
                        {
                            break;
                        }




                    }

                    if (specialNumber >= controlNumber)
                    {
                        break;
                    }
                }
                if (specialNumber >= controlNumber)
                {
                    break;
                }

            }

            if (specialNumber>=controlNumber)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }
        }
    }
}



