using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var clients = new Dictionary<int, BankAccount>();

        string input;
        while ((input=Console.ReadLine())!="End")
        {
            var commandArg = input.Split();
            var clientId = int.Parse(commandArg[1]);

            switch (commandArg[0])
            {
                case "Create":
                    if (CheckIfExist(clientId, clients))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        clients[clientId] = new BankAccount();
                        clients[clientId].Id = clientId;
                        clients[clientId].Balance = 0;
                    }
                    break;

                case "Deposit":
                    if (CheckIfExist(clientId, clients))
                    {
                        clients[clientId].Deposit(int.Parse(commandArg[2]));
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;

                case "Withdraw":
                    if (CheckIfExist(clientId, clients))
                    {
                        clients[clientId].Withdraw(int.Parse(commandArg[2]));
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;

                case "Print":
                    if (CheckIfExist(clientId, clients))
                    {
                        Console.WriteLine(clients[clientId]);

                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
            }



        }


    }

    private static bool CheckIfExist(int clientId, Dictionary<int, BankAccount> clients)
    {
        if (clients.ContainsKey(clientId))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}