using System;

namespace _02_EmailMe
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var leftSum = 0;
            var rightSum = 0;

            bool isReached = false;
            foreach (var letter in text)
            {
                if (letter=='@')
                {
                    isReached = true;
                }
                if (isReached)
                {
                    rightSum += letter;
                }
                else
                {
                    leftSum += letter;
                }

            }

            var result = "She is not the one.";

            if (rightSum-leftSum-64<=0)
            {
                result = "Call her!";
            }

            Console.WriteLine(result);
        }
    }
}