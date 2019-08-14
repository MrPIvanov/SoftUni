namespace _01_MostFrequentNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var currentCounter = 1;
            var finalCounter = 1;
            var endResult = "";

            for (int i = 0; i < input.Count; i++)
            {
                for (int t = i + 1; t < input.Count; t++)
                {
                    if (input[i] == input[t])
                    {
                        currentCounter++;
                        if (currentCounter>finalCounter)
                        {
                            endResult = input[i];
                            finalCounter = currentCounter;
                        }

                    }
                    currentCounter = 1;

                }

            }
            Console.WriteLine(endResult);



        }
    }
}