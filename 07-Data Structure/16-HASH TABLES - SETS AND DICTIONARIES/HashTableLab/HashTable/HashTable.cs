using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class HashTable<TKey, TValue> : IEnumerable<KeyValue<TKey, TValue>>
{
    private const int DefaultCapacity = 17;
    private const double FillFactor = 0.71;
    private LinkedList<KeyValue<TKey, TValue>>[] data;

    public int Count { get; private set; }

    public int Capacity
    {
        get => this.data.Length;
    }

    public HashTable(int capacity = DefaultCapacity)
    {
        this.data = new LinkedList<KeyValue<TKey, TValue>>[capacity];
        this.Count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        GrowIfNeeded();

        var index = Math.Abs(key.GetHashCode()) % this.Capacity;

        if (this.data[index] == null)
        {
            this.data[index] = new LinkedList<KeyValue<TKey, TValue>>();
        }

        foreach (var item in this.data[index])
        {
            if (item.Key.Equals(key))
            {
                throw new ArgumentException("Keyalready exists: " + key);
            }
        }

        this.data[index].AddLast(new KeyValue<TKey, TValue>(key, value));
        this.Count++;        
    }

    private void GrowIfNeeded()
    {
        var currentFill = (double)(this.Count + 1) / this.Capacity;
        if (currentFill > FillFactor)
        {
            Grow();
        }
    }

    private void Grow()
    {
        var newData = new HashTable<TKey, TValue>(this.Capacity * 2);

        foreach (var linkedList in this.data.Where(x => x != null))
        {
            foreach (var item in linkedList)
            {
                newData.Add(item.Key, item.Value);
            }
        }

        this.data = newData.data;
    }

    public bool AddOrReplace(TKey key, TValue value)
    {
        GrowIfNeeded();

        var index = Math.Abs(key.GetHashCode()) % this.Capacity;

        if (this.data[index] == null)
        {
            this.data[index] = new LinkedList<KeyValue<TKey, TValue>>();
        }

        foreach (var item in this.data[index])
        {
            if (item.Key.Equals(key))
            {
                item.Value = value;
                return false;
            }
        }

        this.data[index].AddLast(new KeyValue<TKey, TValue>(key, value));
        this.Count++;
        return true;
    }

    public TValue Get(TKey key)
    {
        var element = this.Find(key);

        if (element == null)
        {
            throw new KeyNotFoundException();
        }

        return element.Value;
    }

    public TValue this[TKey key]
    {
        get => this.Get(key);
        set => this.AddOrReplace(key, value);
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        var element = this.Find(key);
        if (element == null)
        {
            value = default(TValue);
            return false;
        }
        value = element.Value;
        return true;
    }

    public KeyValue<TKey, TValue> Find(TKey key)
    {
        var index = Math.Abs(key.GetHashCode()) % this.Capacity;

        if (this.data[index] == null)
        {
            return null;
        }

        foreach (var item in this.data[index])
        {
            if (key.Equals(item.Key))
            {
                return item;
            }
        }

        return null;
    }

    public bool ContainsKey(TKey key)
    {
        var element = this.Find(key);
        return element != null;
    }

    public bool Remove(TKey key)
    {
        var index = Math.Abs(key.GetHashCode()) % this.Capacity;

        if (this.data[index] != null)
        {
            var currentElement = this.data[index].First;
            while (currentElement != null)
            {
                if (currentElement.Value.Key.Equals(key))
                {
                    this.data[index].Remove(currentElement);
                    this.Count--;
                    return true;
                }

                currentElement = currentElement.Next;
            }
        }

        return false;
    }

    public void Clear()
    {
        this.data = new LinkedList<KeyValue<TKey, TValue>>[DefaultCapacity];
        this.Count = 0;
    }

    public IEnumerable<TKey> Keys
    {
        get => this.Select(x => x.Key);
    }

    public IEnumerable<TValue> Values
    {
        get => this.Select(x => x.Value);
    }

    public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
    {
        foreach (var linkedList in this.data.Where(x => x != null))
        {
            foreach (var item in linkedList)
            {
                yield return item;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
