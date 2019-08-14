namespace _03_EqualSums
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var leftSum = 0;
            var rightSum = 0;
            var result = "no";

            for (int i = 0; i < input.Count; i++)
            {
                if (input.Take(i).Sum()==input.Skip(i+1).Sum())
                {
                    result = i.ToString();
                }

            }

            Console.WriteLine(result);
        }
    }
}