namespace _06_SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> reversedNumbers = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                string number = numbers[i];

                string reversedStr = ReverseTheString(number);

                int num = int.Parse(reversedStr);
                reversedNumbers.Add(num);
            }
            Console.WriteLine(reversedNumbers.Sum());
        }

        private static string ReverseTheString(string number)
        {
            char[] arr = number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
}