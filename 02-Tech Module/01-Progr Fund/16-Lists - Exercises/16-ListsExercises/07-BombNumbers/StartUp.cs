namespace _07_BombNumbers
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

            int[] token = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = token[0];
            int radiusOfBlast = token[1];
            int indexSpecialNumber = numbers.IndexOf(specialNumber);
            int beginToBomb = 0;
            int endToBomb = 2*radiusOfBlast+1;

            while (indexSpecialNumber != -1)
            {
                if (indexSpecialNumber - radiusOfBlast>0)
                {
                    beginToBomb = indexSpecialNumber - radiusOfBlast;
                }
                if (endToBomb+beginToBomb>numbers.Count)
                {
                    endToBomb = (numbers.Count) - beginToBomb;
                }


                numbers.RemoveRange(beginToBomb, endToBomb);

                indexSpecialNumber = numbers.IndexOf(specialNumber);
            }




            Console.WriteLine(numbers.Sum());
        }
    }
}