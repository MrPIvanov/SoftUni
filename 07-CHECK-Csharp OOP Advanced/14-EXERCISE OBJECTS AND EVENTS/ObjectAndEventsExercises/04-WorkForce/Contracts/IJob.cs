public interface IJob
{
    string Name { get; }

    int HourWorkRequired { get; }

    IEmployee Employee { get; }

    void UpdateHours();

    bool IsFinished { get; }
}