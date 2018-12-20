using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workingHoursPerDay;
    private decimal salaryPerHour;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value<10.0m)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public decimal WorkingHoursPerDay
    {
        get { return workingHoursPerDay; }
        set
        {
            if (value<1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHoursPerDay = value;
        }
    }

    public decimal SalaryPerHour
    {
        get { return salaryPerHour; }
        set { salaryPerHour = value; }
    }


    public Worker(string workerFirstName, string workerLastName,decimal workerWeekSalary,decimal workerWorkingHoursPerDay)
        : base(workerFirstName,workerLastName)
    {
        WeekSalary = workerWeekSalary;
        WorkingHoursPerDay = workerWorkingHoursPerDay;
        SalaryPerHour = WeekSalary / (WorkingHoursPerDay * 5.0m);
    }





    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {FirstName}");
        sb.AppendLine($"Last Name: {LastName}");
        sb.AppendLine($"Week Salary: {WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {WorkingHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {SalaryPerHour:f2}");



        var result = sb.ToString().TrimEnd();
        return result;
    }
}