using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allNumbers = Console.ReadLine().Split().ToList();
        var allSites = Console.ReadLine().Split().ToList();
        var phone = new Phone();

        foreach (var number in allNumbers)
        {
            Console.WriteLine(phone.Call(number));
        }
        foreach (var site in allSites)
        {
            Console.WriteLine(phone.BrowseWeb(site));
        }

    }
}