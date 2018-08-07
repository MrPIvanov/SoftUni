using System;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var king = new King(Console.ReadLine());

        var royalGuards = Console.ReadLine().Split();
        foreach (var guard in royalGuards)
        {
            ISubordinate subordinate = new RoyalGuard(guard);
            king.AddSubordinate(subordinate);
        }

        var footmens = Console.ReadLine().Split();
        foreach (var footmen in footmens)
        {
            ISubordinate subordinate = new Footmen(footmen);
            king.AddSubordinate(subordinate);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split();
            if (tokens[0] == "Kill")
            {
                var currentSubordinate = king.Subordinates.FirstOrDefault(s => s.Name == tokens[1]);

                currentSubordinate.TakeDamage();

                if (currentSubordinate.LifePoints <= 0)
                {
                    king.RemoveSubordinate(currentSubordinate);
                }
            }
            else
            {
                king.TakeAtack();
            }
        }
    }
}