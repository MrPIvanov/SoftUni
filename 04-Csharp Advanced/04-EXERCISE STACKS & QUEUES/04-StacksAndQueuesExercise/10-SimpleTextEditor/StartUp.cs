namespace _10_SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var resultCollection = new Stack<string>();

            resultCollection.Push(result);

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        var strToAppend = command[1];

                        var currentResult = resultCollection.Peek();
                        currentResult += strToAppend;
                        resultCollection.Push(currentResult);
                        break;

                    case "2":
                        var numberOfElementsToDelete = int.Parse(command[1]);

                        var strToAdd = "";
                        var current = resultCollection.Peek();
                        strToAdd = current.Substring(0, current.Length - numberOfElementsToDelete);

                        resultCollection.Push(strToAdd);
                       

                        break;

                    case "3":
                        var indexToPrint = int.Parse(command[1]);
                        Console.WriteLine(resultCollection.Peek()[indexToPrint-1]);
                        break;

                    case "4":
                        resultCollection.Pop();
                        break;
                }

            }

        }
    }
}
