namespace _02_PhoneUpgr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            var command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            while (command[0] != "END")
            {

                if (command[0] == "A")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Remove(command[1]);
                    }

                    phonebook.Add(command[1], command[2]);

                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }

                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }

                }
                else if (command[0]=="ListAll")
                {

                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }


                }

                command = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();
            }

        }
    }
}