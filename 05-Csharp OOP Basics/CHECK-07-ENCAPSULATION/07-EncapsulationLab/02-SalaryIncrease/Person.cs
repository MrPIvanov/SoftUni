using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public Person(string first, string last, int years, decimal salary)
    {
        FirstName = first;
        LastName = last;
        Age = years;
        Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (age>30)
        {
            salary = ((percentage + 100) / 100) * salary;
        }
        else
        {
            percentage /= 2;
            salary = ((percentage + 100) / 100) * salary;
        }

    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary:f2} leva.";
    }

}
