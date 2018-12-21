public class Job : IJob
{
    public string Name { get; }

    public int HourWorkRequired { get; private set; }

    public IEmployee Employee { get; }

    public bool IsFinished { get; set; }

    public Job(string name, int hoursRequired, IEmployee employee)
    {
        this.Name = name;
        this.HourWorkRequired = hoursRequired;
        this.Employee = employee;
        this.IsFinished = false;
    }

    public void UpdateHours()
    {
        this.HourWorkRequired -= this.Employee.WorkHoursPerWeek;

        if (this.HourWorkRequired<=0 )
        {
            this.ReactToFinishJob();
        }
    }

    public override string ToString()
    {
        return $"Job: {this.Name} Hours Remaining: {this.HourWorkRequired}";
    }

    private void ReactToFinishJob()
    {
        System.Console.WriteLine($"Job {this.Name} done!");
        this.IsFinished = true;
    }
}