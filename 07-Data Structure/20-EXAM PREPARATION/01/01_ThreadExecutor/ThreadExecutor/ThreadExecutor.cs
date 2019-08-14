using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

/// <summary>
/// The ThreadExecutor is the concrete implementation of the IScheduler.
/// You can send any class to the judge system as long as it implements
/// the IScheduler interface. The Tests do not contain any <e>Reflection</e>!
/// </summary>
public class ThreadExecutor : IScheduler
{
    private int cycleTotal;
    private Dictionary<int, Task> byId;
  
    public ThreadExecutor()
    {
        this.byId = new Dictionary<int, Task>();
        this.cycleTotal = 0;
    }

    public int Count => this.byId.Keys.Count;


    public void ChangePriority(int id, Priority newPriority)
    {
        if (!this.byId.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        this.byId[id].TaskPriority = newPriority;       
    }

    public bool Contains(Task task)
    {
        return this.byId.ContainsKey(task.Id);
    }

    public int Cycle(int cycles)
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        this.cycleTotal += cycles;
        var currentCount = this.Count;

        this.byId = this.byId.Where(x => x.Value.Consumption > this.cycleTotal).ToDictionary(x => x.Key, y => y.Value);

        return currentCount - this.Count;
    }

    public void Execute(Task task)
    {
        if (this.byId.ContainsKey(task.Id))
        {
            throw new ArgumentException();
        }

        this.byId[task.Id] = task;
    }

    public IEnumerable<Task> GetByConsumptionRange(int lo, int hi, bool inclusive)
    {
        if (inclusive)
        {
            return this.byId.Values.Where(x => x.Consumption - this.cycleTotal >= lo && x.Consumption - this.cycleTotal <= hi).OrderBy(x => x);
        }
        else
        {
            return this.byId.Values.Where(x => x.Consumption - this.cycleTotal > lo && x.Consumption - this.cycleTotal < hi).OrderBy(x => x);
        }
    }

    public Task GetById(int id)
    {
        if (!this.byId.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        return this.byId[id];
    }

    public Task GetByIndex(int index)
    {
        if (index < 0 && index > this.Count - 1)
        {
            throw new ArgumentOutOfRangeException();
        }
        return this.byId.Values.ElementAt(index);
    }

    public IEnumerable<Task> GetByPriority(Priority type)
    {
        return this.byId.Values.Where(x => x.TaskPriority == type).OrderByDescending(x => x.Id);
    }

    public IEnumerable<Task> GetByPriorityAndMinimumConsumption(Priority priority, int lo)
    {
       return this.byId.Values.Where(x => x.TaskPriority == priority && x.Consumption >= lo).OrderByDescending(x => x.Id);
    }


    public IEnumerator<Task> GetEnumerator()
    {
        foreach (var item in this.byId.Values)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
