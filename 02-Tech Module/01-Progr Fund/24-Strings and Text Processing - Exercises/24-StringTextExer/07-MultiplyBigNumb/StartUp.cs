using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_MultiplyBigNumb
{
    public class StartUp
    {
        public static void Main()
        {
            List<char> firstNumber = Console.ReadLine().ToList();
            int secondNumber = int.Parse(Console.ReadLine());

            int reminder = 0;
            string result = "";
            

            for (int i = firstNumber.Count - 1; i >= 0; i--)
            {
                string currentFirstNumber = firstNumber[i].ToString();

                int temp = int.Parse(currentFirstNumber)*secondNumber;


                int newTemp = (temp +reminder)%10;

                result = result.Insert(0, newTemp.ToString());

                reminder = (temp+reminder) / 10;

            }
            if (reminder>0)
            {
                result = result.Insert(0, reminder.ToString());
            }
            result = result.TrimStart('0');
            Console.WriteLine(result);

            if (secondNumber==0)
            {
                Console.WriteLine("0");
            }
        }
    }
}