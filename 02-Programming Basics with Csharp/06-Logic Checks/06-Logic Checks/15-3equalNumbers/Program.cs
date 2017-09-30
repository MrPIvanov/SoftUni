using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3equalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if ((first==second)&&(first==third))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");

            }



        }
    }
}
