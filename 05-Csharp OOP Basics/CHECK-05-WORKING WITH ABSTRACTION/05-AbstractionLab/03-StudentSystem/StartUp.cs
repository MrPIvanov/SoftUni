using System;

public class StartUp
{
    static void Main()
    {
        StudentSystem studentSystem = new StudentSystem();

        string input;
        while ((input=Console.ReadLine()) != "Exit")
        {
            var tokens = input.Split();

            if (tokens[0]=="Create")
            {
                studentSystem.Create(tokens);
            }
            else
            {
                studentSystem.Show(tokens);
            }
        }
    }
}