namespace _04_MaxSeqOfEqual
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var currentSeq = 1;
            var longestSeq = 1;
            var index = 0;


            for (int i = 0; i < input.Count; i++)
            {
                for (int t = i + 1; t < input.Count; t++)
                {
                    if (input[i] == input[t])
                    {
                        if (currentSeq + 1 > longestSeq)
                        {
                            currentSeq++;
                            longestSeq++;
                            index = i;
                            continue;
                        }
                        currentSeq++;

                    }
                    else
                    {
                        currentSeq = 1;
                        break;
                    }

                }
            }

           
            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write($"{input[index]} ");
            }


        }
    }
}