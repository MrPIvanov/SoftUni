using System;
using System.Linq;

namespace _04_CharacterMultip
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();
            long sum = 0;


            int loops = 0;
            if (firstWord.Length >= secondWord.Length)
            {
                loops = firstWord.Length;
            }
            else
            {
                loops = secondWord.Length;
            }

            for (int i = 0; i < loops; i++)
            {
                int n1 = 0;
                int n2 = 0;
                n1 = firstWord.ElementAtOrDefault(i);
                n2 = secondWord.ElementAtOrDefault(i);
                if (n1==0)
                {
                    n1 = 1;
                }
                if (n2 == 0)
                {
                    n2 = 1;
                }

                long temp = n1 * n2;
                sum += temp;

            }

            Console.WriteLine(sum);

        }


    }

}

