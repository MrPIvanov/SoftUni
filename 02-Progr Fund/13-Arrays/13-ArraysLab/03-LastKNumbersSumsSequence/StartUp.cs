namespace _03_LastKNumbersSumsSequence
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int elementsToCalculate = int.Parse(Console.ReadLine());

            long[] numbersArray = new long[numberOfElements];

            numbersArray[0] = 1;
           

            for (int i = 1; i < numbersArray.Length; i++)
            {
                long sum = 0;

                for (int y =i-elementsToCalculate; y <=i-1 ; y++)
                {
                    if (y>=0)
                    {
                        sum += numbersArray[y];
                    }

                    numbersArray[i] = sum;

                }
            }

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}