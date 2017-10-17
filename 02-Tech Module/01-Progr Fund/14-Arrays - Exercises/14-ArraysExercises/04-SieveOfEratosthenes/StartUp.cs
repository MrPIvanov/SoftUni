namespace _04_SieveOfEratosthenes
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            bool[] array = new bool[input+1];

            for (int i = 0; i <= input; i++)
            {
                array[i] = true;
            }
            array[0] = false;
            array[1] = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.Write($"{i} ");

                    for (int y = 0; y < array.Length; y+=i)
                    {
                        array[y] = false;

                    }
                }
            }
        }
    }
}
