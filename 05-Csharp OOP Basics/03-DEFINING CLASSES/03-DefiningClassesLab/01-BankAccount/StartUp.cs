using System;

public class StartUp
{
    static void Main()
    {
        var bankAcc = new BankAccount();

        bankAcc.Id = 1;
        bankAcc.Balance = 15;

        Console.WriteLine($"Account {bankAcc.Id}, balance {bankAcc.Balance}");


    }
}