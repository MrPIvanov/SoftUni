namespace _08_RecursiveFibonacci
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var data = new Dictionary<int,long>();
            data[1] = 1;
            data[2] = 1;

            long result = CalculateFibonachi(inputNumber,data);

            Console.WriteLine(result);


        }

        private static long CalculateFibonachi(int inputNumber, Dictionary<int, long> data)
        {
            if (data.ContainsKey(inputNumber))
            {
                return data[inputNumber];
            }
            else
            {
                var currentNumber = CalculateFibonachi(inputNumber - 1, data) + CalculateFibonachi(inputNumber - 2, data);
                data[inputNumber] = currentNumber;
                return currentNumber;
            }
        }
    }
}
