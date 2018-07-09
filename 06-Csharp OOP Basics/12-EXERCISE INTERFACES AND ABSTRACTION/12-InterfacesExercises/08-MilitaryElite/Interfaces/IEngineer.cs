using System.Collections.Generic;

public interface IEngineer
{
    List<Repair> RepairList { get; }
    void AddRepair(Repair currentRepair);
}