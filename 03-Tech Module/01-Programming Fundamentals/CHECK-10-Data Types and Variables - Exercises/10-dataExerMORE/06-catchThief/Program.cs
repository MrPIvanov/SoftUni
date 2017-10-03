using System;

namespace _06_catchThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int numberOfLoops = int.Parse(Console.ReadLine());

            long result = long.MinValue;

            switch (type)
            {
                case "sbyte":
                    for (int i = 0; i < numberOfLoops; i++)
                    {
                        try
                        {
                            sbyte curentNumber = sbyte.Parse(Console.ReadLine());

                            if (curentNumber > result && curentNumber <= sbyte.MaxValue)
                            {
                                result = curentNumber;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    break;


                case "int":
                    for (int i = 0; i < numberOfLoops; i++)
                    {
                        try
                        {
                            int curentNumber = int.Parse(Console.ReadLine());

                            if (curentNumber > result && curentNumber <= int.MaxValue)
                            {
                                result = curentNumber;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    break;


                case "long":
                    for (int i = 0; i < numberOfLoops; i++)
                    {
                        try
                        {
                            long curentNumber = long.Parse(Console.ReadLine());

                            if (curentNumber > result && curentNumber <= long.MaxValue)
                            {
                                result = curentNumber;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    break;
            }
            Console.WriteLine(result);

            
        }
    }
}