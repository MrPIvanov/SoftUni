using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_numCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            bool result = int.TryParse(input, out number);

            if (result)
            {
                Console.WriteLine("It is a number.");
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }


        }
    }
}
