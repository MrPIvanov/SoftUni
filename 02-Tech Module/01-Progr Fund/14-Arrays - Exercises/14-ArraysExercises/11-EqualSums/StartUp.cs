namespace _11_EqualSums
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long leftSum = 0;
            long rightSum = 0;
            bool printNo = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (i<y)
                    {
                        leftSum += numbers[y];
                    }

                    else if (i>y)
                    {
                        rightSum += numbers[y];
                    }

                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    printNo = false;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (printNo)
            {
                Console.WriteLine("no");
            }

        }
    }
}