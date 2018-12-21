using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var items = Console.ReadLine().Split();

        var listIterator = new ListyIterator(items.Skip(1).ToArray());

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(listIterator.Move());
                    break;

                case "Print":
                    try
                    {
                        listIterator.Print();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "HasNext":
                    Console.WriteLine(listIterator.HasNext());
                    break;

                case "PrintAll":
                    Console.WriteLine(string.Join(" ", listIterator));
                    break;

            }
        }
    }
}