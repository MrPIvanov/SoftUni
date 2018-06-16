using System;

namespace _07_Hideout
{
    public class StartUp
    {
        public static void Main()
        {
            var map = Console.ReadLine();
            var startingIndex = 0;
            var counter = 0;

            while (true)
            {
                var input = Console.ReadLine().Split();

                var targetStr = new string(Convert.ToChar(input[0]),int.Parse(input[1]));

                if (map.Contains(targetStr))
                {
                    startingIndex = map.IndexOf(targetStr);
                    for (int i = startingIndex; i < map.Length-1; i++)
                    {
                        if (map[i]==map[i+1])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    counter++;
                    break;
                }

            }
            Console.WriteLine($"Hideout found at index {startingIndex} and it is with size {counter}!");


        }
    }
}
