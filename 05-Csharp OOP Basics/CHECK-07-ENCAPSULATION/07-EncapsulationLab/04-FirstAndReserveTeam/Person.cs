using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    const decimal MIN_SALARY = 460;
    const int MIN_LENGHT = 3;

    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value?.Length<MIN_LENGHT)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value?.Length < MIN_LENGHT)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value<MIN_SALARY)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            salary = value;

        }
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
        if (age > 30)
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
