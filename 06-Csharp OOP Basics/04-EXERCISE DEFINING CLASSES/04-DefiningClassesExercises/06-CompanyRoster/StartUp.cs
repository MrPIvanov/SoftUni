using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var allEmployees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var name = input[0];
            var salary = decimal.Parse(input[1]);
            var position = input[2];
            var department = input[3];

            var email = "n/a";
            var age = -1;
            if (input.Length == 5)
            {
                try
                {
                    age = int.Parse(input[4]);
                }
                catch (Exception)
                {
                    email = input[4];
                }

            }
            else if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);
            }

            var currentEmployee = new Employee(name, salary, position, department, email, age);

            allEmployees.Add(currentEmployee);
        }

        var highSalaryDepartment = allEmployees.GroupBy(x => x.Department)
            .OrderByDescending(x => x.Select(y => y.Salary).Average())
            .FirstOrDefault();


        Console.WriteLine($"Highest Average Salary: {highSalaryDepartment.FirstOrDefault().Department}");

        foreach (var e in highSalaryDepartment.OrderByDescending(x=>x.Salary))
        {
            Console.WriteLine($"{e.Name} {e.Salary:f2} {e.Email} {e.Age}");
        }
    }
}