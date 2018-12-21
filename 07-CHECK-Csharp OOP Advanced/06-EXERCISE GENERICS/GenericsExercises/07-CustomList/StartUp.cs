using System;

public class StartUp
{
    static void Main()
    {
        var myList = new CustomList<string>();

        ExecuteCommands(myList);
    }

    private static void ExecuteCommands(CustomList<string> myList)
    {
        string input;
        while ((input=Console.ReadLine()) != "END")
        {
            var tokens = input.Split();
            var command = tokens[0];
            string element;
            int index;
            int firstIndex;
            int secondIndex;

            switch (command)
            {
                case "Add":
                    element = tokens[1];
                    myList.Add(element);
                    break;

                case "Remove":
                    index = int.Parse(tokens[1]);
                    var removedItem = myList.Remove(index);
                    //Console.WriteLine(removedItem);   //Dont know if i need to print it.
                    break;

                case "Contains":
                    element = tokens[1];
                    bool contains = myList.Contains(element);
                    Console.WriteLine(contains);
                    break;

                case "Swap":
                    firstIndex = int.Parse(tokens[1]);
                    secondIndex = int.Parse(tokens[2]);
                    myList.Swap(firstIndex, secondIndex);                    
                    break;

                case "Greater":
                    element = tokens[1];
                    int greaterElements = myList.CountGreaterThan(element);
                    Console.WriteLine(greaterElements);
                    break;

                case "Max":
                    var maxElement = myList.Max();
                    Console.WriteLine(maxElement);
                    break;

                case "Min":
                    var minElement = myList.Min();
                    Console.WriteLine(minElement);
                    break;

                case "Print":
                    myList.Print();
                    break;
            }
        }
    }
}