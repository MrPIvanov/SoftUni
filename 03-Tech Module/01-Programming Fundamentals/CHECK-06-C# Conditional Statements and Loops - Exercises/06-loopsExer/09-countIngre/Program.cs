using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_countIngre
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                string current = Console.ReadLine();
                int result = 1;
                bool currentNumber = int.TryParse(current, out result);

                if (!currentNumber)
                {
                    break;
                }
                counter++;
            }


            Console.WriteLine(counter);

        }
    }
}
