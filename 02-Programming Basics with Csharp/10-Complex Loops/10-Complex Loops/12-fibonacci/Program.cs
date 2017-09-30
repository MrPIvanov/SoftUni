using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            int result = 0;
            if (number<2)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 1; i < number; i++)
                {
                    result = f1 + f2;
                    f1 = f2;
                    f2 = result;


                }

                Console.WriteLine(result);



            }
        }
    }
}
