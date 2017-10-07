namespace _18_SequenceOf
{
    using System;
    using System.Linq;

    class StartUp
    {
        const char ArgumentsDelimiter = ' ';

        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

            string[] command = Console.ReadLine().ToLower().Split(ArgumentsDelimiter);

            while (command[0] != "stop")
            {


                if (command[0] == "add" || command[0] == "subtract" || command[0] == "multiply")
                {
                    int position = int.Parse(command[1]);
                    int valueToUse = int.Parse(command[2]);

                    PerformAction(array, command[0], position, valueToUse);
                }
                else if (command[0] == "rshift")
                {
                    ShiftElementsRight(array);
                    PrintArray(array);
                    Console.WriteLine();
                }

                else if (command[0] == "lshift")
                {
                    ShiftElementsLeft(array);
                    PrintArray(array);
                    Console.WriteLine();
                }

                command = Console.ReadLine().ToLower().Split(ArgumentsDelimiter);
            }
        }


        private static long[] ShiftElementsLeft(long[] array)
        {
            long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
            return array;
        }


        private static long[] ShiftElementsRight(long[] array)
        {
            long lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
            return array;
        }

        static void PerformAction(long[] array, string action, int position, int valueToUse)
        {

            switch (action)
            {
                case "multiply":
                    array[position - 1] *= valueToUse;
                    break;
                case "add":
                    array[position - 1] += valueToUse;
                    break;
                case "subtract":
                    array[position - 1] -= valueToUse;
                    break;
            }

            PrintArray(array);
            Console.WriteLine();
        }
        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}