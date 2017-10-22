namespace _03_SafeManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine().Split().ToArray();

            while (command[0]!="END")
            {
                if (command[0]== "Distinct")
                {
                    var temp = new List<string>();
                    temp.AddRange(input.Distinct());
                    input.Clear();
                    input.AddRange(temp);
                }

                else if (command[0]== "Reverse")
                {
                    input.Reverse();
                }
                else if (command[0]== "Replace")
                {
                    if (int.Parse(command[1])<=input.Count-1 && int.Parse(command[1])>=0)
                    {
                        input[int.Parse(command[1])] = command[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");

                    }


                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"{string.Join(", ", input)}");
        }
    }
}