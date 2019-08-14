using System;
using System.Linq;

namespace _02_CountSubstringOccur
{
    public class StartUp
    {
        public static void Main()
        {
            var allText = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var result = 0;

            while (allText.Length>0)
            {
                if (allText.StartsWith(pattern))
                {
                    result++;
                }

                allText = allText.Substring(1);
            }

            Console.WriteLine(result);


        }
    }
}