namespace _07_TakeSkipRo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            //var numbers = new List<int>();
            var letters = new List<char>();

            var skipNumbers = new List<int>();
            var takeNumbers = new List<int>();

            int oddCounter = 1;
            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    var numberToAdd = int.Parse(symbol.ToString());
                    if (oddCounter%2==1)
                    {
                        takeNumbers.Add(numberToAdd);
                    }
                    else
                    {
                        skipNumbers.Add(numberToAdd);
                    }
                    oddCounter++;

                }
                else
                {
                    letters.Add(symbol);
                }

            }


            var totalAmountToSkip = 0;
            List<char> result = new List<char>();

            for (int i = 0; i < takeNumbers.Count; i++)
            {
                var temp = letters.Skip(totalAmountToSkip).Take(takeNumbers[i]);

                totalAmountToSkip += skipNumbers[i] + takeNumbers[i];
                result.AddRange(temp);
            }

            Console.WriteLine(string.Join("",result));


        }
    }
}