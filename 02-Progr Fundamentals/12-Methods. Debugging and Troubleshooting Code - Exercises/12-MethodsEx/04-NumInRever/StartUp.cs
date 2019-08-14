namespace _04_NumInRever
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string number = Console.ReadLine();

           string result =  GetTheNumberInReverse(number);

            Console.WriteLine(result);
        }

        static string GetTheNumberInReverse(string number)
        {
            string currentResult = "";

            int loops = number.Length;

            for (int i = 0; i < loops; i++)
            {
               currentResult+= number.Substring(number.Length-1,1);
               number= number.Remove(number.Length-1,1);
            }

            return currentResult;
        }
    }
}