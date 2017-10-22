namespace _09_JumpAround
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = numbers[0];
            int positionsToMove = 0;
            int currentIndex = 0;

            while (true)
            {
                positionsToMove = numbers[currentIndex];


                if (positionsToMove+currentIndex<=numbers.Length-1)
                {
                    currentIndex += positionsToMove;
                    sum += numbers[currentIndex];

                    continue;
                }
                else if (currentIndex-positionsToMove>=0)
                {
                    currentIndex -= positionsToMove;
                    sum += numbers[currentIndex];

                    continue;
                }

                break;
            }

            Console.WriteLine(sum);
        }
    }
}