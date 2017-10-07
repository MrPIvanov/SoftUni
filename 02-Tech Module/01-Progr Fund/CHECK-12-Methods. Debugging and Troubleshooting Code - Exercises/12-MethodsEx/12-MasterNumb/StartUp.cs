namespace _12_MasterNumb
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                if (ContainsEvenDigit(i))
                {

                    if (SumOfDigits(i))
                    {
                        if (IsPalindrome(i))
                        {

                            Console.WriteLine(i);
                        }
                    }



                }


            }


        }

        static bool ContainsEvenDigit(int i)
        {
            while (i != 0)
            {
                if ((i % 10) % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }


            return false;
        }

        static bool SumOfDigits(int i)
        {
            int result = 0;
            while (i != 0)
            {
                result += i % 10;

                i /= 10;
            }

            if (result % 7 == 0)
            {
                return true;
            }


            return false;
        }

        static bool IsPalindrome(int i)
        {
            bool result = false;

            string workingString = i.ToString();

            int numbersCount = workingString.Length;

            for (int y = 0; y < numbersCount / 2; y++)
            {
                string firstChar = "";
                string secondChar = "";

                firstChar = workingString.Remove(1, workingString.Length - 1);
                secondChar = workingString.Remove(0, workingString.Length - 1);

                if (firstChar == secondChar)
                {
                    workingString = workingString.Remove(0, 1);
                    workingString = workingString.Remove(workingString.Length - 1, 1);

                    result = true;
                    continue;
                }
                else
                {
                    result = false;
                    break;

                }
            }
            return result;
        }
    }
}