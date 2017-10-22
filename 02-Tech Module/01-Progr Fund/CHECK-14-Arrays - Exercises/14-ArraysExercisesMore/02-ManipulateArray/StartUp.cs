namespace _02_ManipulateArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
          var result = Console.ReadLine().Split().ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0]== "Reverse")
                {
                    result.Reverse();
                }
                else if (command[0]== "Distinct")
                {
                    var temp = new List<string>();
                   temp.AddRange(result.Distinct());
                    result.Clear();
                    result.AddRange(temp);
                }
                else if (command[0]== "Replace")
                {
                    result[int.Parse(command[1])]=command[2];
                }

            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}