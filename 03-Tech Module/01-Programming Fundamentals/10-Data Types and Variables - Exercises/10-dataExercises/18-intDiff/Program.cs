using System;

namespace _18_intDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();



            try
            {
                long try1 = long.Parse(number);
                Console.WriteLine($"{number} can fit in:");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

            try
            {
                sbyte try1 = sbyte.Parse(number);
                Console.WriteLine("* sbyte");
            }
            catch (OverflowException)
            {
            }

            try
            {
                byte try1 = byte.Parse(number);
                Console.WriteLine("* byte");

            }
            catch (OverflowException)
            {
            }

            try
            {
                short try1 = short.Parse(number);
                Console.WriteLine("* short");

            }
            catch (OverflowException)
            {
            }

            try
            {
                ushort try1 = ushort.Parse(number);
                Console.WriteLine("* ushort");

            }
            catch (OverflowException)
            {
            }

            try
            {
                int try1 = int.Parse(number);
                Console.WriteLine("* int");

            }
            catch (OverflowException)
            {
            }

            try
            {
                uint try1 = uint.Parse(number);
                Console.WriteLine("* uint");

            }
            catch (OverflowException)
            {
            }
            try
            {
                long try1 = long.Parse(number);
                Console.WriteLine("* long");

            }
            catch (OverflowException)
            {
            }



        }
    }
}