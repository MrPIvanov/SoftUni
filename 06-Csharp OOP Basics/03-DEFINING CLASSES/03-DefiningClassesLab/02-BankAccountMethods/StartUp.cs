using System;

public class StartUp
{
    static void Main()
    {
        var bankAcc = new BankAccount();

        bankAcc.Id = 1;
        bankAcc.Deposit(15);
        bankAcc.Withdraw(10);

        Console.WriteLine(bankAcc);


    }
}