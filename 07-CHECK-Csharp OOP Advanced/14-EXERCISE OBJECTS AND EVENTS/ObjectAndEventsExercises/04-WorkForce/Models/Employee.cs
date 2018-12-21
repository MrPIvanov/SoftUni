public abstract class Employee : IEmployee
{
    public string Name { get; private set; }

    public int WorkHoursPerWeek { get; }

    public Employee(string name, int workHours)
    {
        this.Name = name;
        this.WorkHoursPerWeek = workHours;
    }
}