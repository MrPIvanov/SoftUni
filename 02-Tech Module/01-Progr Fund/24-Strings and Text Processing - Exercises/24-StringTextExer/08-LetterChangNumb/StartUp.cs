using System;
using System.Linq;

namespace _08_LetterChangNumb
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                char[] currentInput = input[i].ToCharArray();
                char firstLetter = currentInput[0];
                char lastLetter = currentInput.Last();

                char[] currentNumberChar = currentInput.Skip(1).Take(currentInput.Length - 2).ToArray();
                string currentNumberString = "";

                foreach (var number in currentNumberChar)
                {
                    currentNumberString += number;
                }

                double currentNumber = double.Parse(currentNumberString);

                if (firstLetter.ToString() == firstLetter.ToString().ToUpper())
                {
                    currentNumber /=firstLetter - 64.0;
                }
                else
                {
                    currentNumber *=firstLetter - 96.0;

                }

                if (lastLetter.ToString() == lastLetter.ToString().ToUpper())
                {
                    currentNumber -=lastLetter - 64.0;
                }
                else
                {
                    currentNumber +=lastLetter - 96.0;

                }

                sum += currentNumber;


            }

            Console.WriteLine($"{sum:f2}");

        }
    }
}