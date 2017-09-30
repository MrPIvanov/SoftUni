using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_minNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int result = int.MaxValue;

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num<result)
                {
                    result = num;
                }
            }


            Console.WriteLine(result);

        }
    }
}
