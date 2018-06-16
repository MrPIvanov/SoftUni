using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PlayCatch
{
    public class StartUp
    {
        public static void Main()
        {
            var allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var exeptionTimer = 0;

            while (exeptionTimer < 3)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                switch (command)
                {
                    case "Replace":
                        
                        try
                        {
                            var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);

                            try
                            {
                                allNumbers[index] = element;

                            }
                            catch (Exception)
                            {
                                exeptionTimer++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        catch (Exception)
                        {
                            exeptionTimer++;
                            Console.WriteLine("The variable is not in the correct format!");
                        }

                        break;

                    case "Print":

                        try
                        {
                            var startIndex = int.Parse(input[1]);
                            var endIndex = int.Parse(input[2]);

                            try
                            {
                                var tempNumbers = allNumbers.GetRange(startIndex,endIndex-startIndex+1);
                                Console.WriteLine(string.Join(", ", tempNumbers));

                            }
                            catch (Exception)
                            {
                                exeptionTimer++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        catch (Exception)
                        {
                            exeptionTimer++;
                            Console.WriteLine("The variable is not in the correct format!");
                        }

                        break;

                    case "Show":

                        try
                        {
                            var index = int.Parse(input[1]);

                            try
                            {
                                Console.WriteLine(allNumbers[index]);

                            }
                            catch (Exception)
                            {
                                exeptionTimer++;
                                Console.WriteLine("The index does not exist!");
                            }
                        }
                        catch (Exception)
                        {
                            exeptionTimer++;
                            Console.WriteLine("The variable is not in the correct format!");
                        }

                        break;
                }

            }

            Console.WriteLine(string.Join(", ",allNumbers));

        }
    }
}