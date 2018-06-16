using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SumBigNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            List<char> firstNumber = Console.ReadLine().ToList();
            List<char> secondNumber = Console.ReadLine().ToList();

            int reminder = 0;
            string result = "";

            if (firstNumber.Count > secondNumber.Count)
            {
                int numberOfZeros = firstNumber.Count - secondNumber.Count;
                string partToAdd = new string('0',numberOfZeros);
                char[] charToAdd = partToAdd.ToCharArray();
                secondNumber.InsertRange(0, charToAdd);

            }
            else
            {
                int numberOfZeros = secondNumber.Count - firstNumber.Count;
                string partToAdd = new string('0', numberOfZeros);
                char[] charToAdd = partToAdd.ToCharArray();
                firstNumber.InsertRange(0, charToAdd);

            }


            for (int i = firstNumber.Count - 1; i >= 0; i--)
            {
                string currentFirstNumber = firstNumber[i].ToString();
                string currentSecondNumber = secondNumber[i].ToString();

                int temp = int.Parse(currentFirstNumber) + int.Parse(currentSecondNumber) + reminder;
                int newTemp =temp % 10;
              result =  result.Insert(0,newTemp.ToString());

                if (temp>=10)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }

            }
            if (reminder==1)
            {
                result = result.Insert(0, "1");
            }
            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}