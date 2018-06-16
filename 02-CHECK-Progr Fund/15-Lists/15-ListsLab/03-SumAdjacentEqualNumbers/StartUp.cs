namespace _03_SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {

           List<double> numbers = Console.ReadLine().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            int counter = 0;

            while (true)
            {
                if (counter+1==numbers.Count)
                {
                    break;
                }

                if (numbers[counter]==numbers[counter+1])
                {
                    numbers[counter + 1] += numbers[counter];
                    numbers.RemoveAt(counter);
                    counter = 0;

                }
                else
                {
                    counter++;
                }

            }

            Console.WriteLine($"{string.Join(" ", numbers)}");


        }
    }
}