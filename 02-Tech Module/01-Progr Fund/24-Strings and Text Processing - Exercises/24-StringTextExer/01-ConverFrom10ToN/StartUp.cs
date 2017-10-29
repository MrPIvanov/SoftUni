using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01_ConverFrom10ToN
{
    public class StartUp
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            BigInteger system = input[0];
            BigInteger  number = input[1];
            BigInteger currentNumber = 0;
            List<BigInteger> temp = new List<BigInteger>();

            while (number>0)
            {
                currentNumber= number % system;

                number /= system;
                temp.Insert(0,currentNumber);

            }

           
            Console.WriteLine(string.Join("", temp));
       
        }
    }
}