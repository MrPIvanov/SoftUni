using System.Collections.Generic;

public interface ICommando
{
    List<Mission> MissionList { get; }
    void AddMission(Mission currentMission);
}