using System;
using System.Linq;

namespace _01_ReverseString
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(string.Join("",Console.ReadLine().ToCharArray().Reverse()));
        }
    }
}