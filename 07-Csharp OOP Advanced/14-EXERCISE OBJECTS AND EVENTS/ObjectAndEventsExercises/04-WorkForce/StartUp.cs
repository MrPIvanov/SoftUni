using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var allJobs = new List<IJob>();
        var allEmployees = new List<IEmployee>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();

            switch (tokens[0])
            {
                case "Status":
                    foreach (var job in allJobs)
                    {
                        Console.WriteLine(job);
                    }
                    break;

                case "Pass":
                    foreach (var job in allJobs)
                    {
                        job.UpdateHours();
                    }

                    allJobs = allJobs.Where(j => j.IsFinished == false).ToList();
                    break;

                case "Job":
                    var employee = allEmployees.FirstOrDefault(e => e.Name == tokens[3]);
                    var currentJob = new Job(tokens[1], int.Parse(tokens[2]), employee);
                    allJobs.Add(currentJob);
                    break;

                case "StandardEmployee":
                    var currentStandardEmployee = new StandardEmployee(tokens[1]);
                    allEmployees.Add(currentStandardEmployee);
                    break;

                case "PartTimeEmployee":
                    var currentPartTimeEmployee = new PartTimeEmployee(tokens[1]);
                    allEmployees.Add(currentPartTimeEmployee);
                    break;
            }
        }
    }
}