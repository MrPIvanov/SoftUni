namespace _02_ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine().ToLower();

            while (command!="odd"&&command!="even")
            {
                List<string> currentInput = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (currentInput[0]=="delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(currentInput[1]));

                }

                else if (currentInput[0]=="insert")
                {

                    numbers.Insert(int.Parse(currentInput[2]), int.Parse(currentInput[1]));

                }

                command = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]%2==0&&command=="even")
                {
                    Console.Write($"{numbers[i]} ");
                }
                else if (numbers[i]%2!=0&&command=="odd")
                {
                    Console.Write($"{numbers[i]} ");

                }
            }

        }
    }
}