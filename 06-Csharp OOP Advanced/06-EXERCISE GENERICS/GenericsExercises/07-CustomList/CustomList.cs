﻿using System;

public class CustomList<T> where T : IComparable<T>
{
    public T[] Items { get; private set; }

    public CustomList()
    {
        this.Items = new T[2];
    }

    public void Add(T element)
    {
        bool itemAdd = false;
        for (int i = 0; i < this.Items.Length; i++)
        {
            if (this.Items[i] == null)
            {
                this.Items[i] = element;
                itemAdd = true;
            }
            if (itemAdd)
            {
                break;
            }
        }

        if (!itemAdd)
        {
            var temp = new T[this.Items.Length * 2];

            for (int i = 0; i < this.Items.Length; i++)
            {
                temp[i] = this.Items[i];
            }

            temp[temp.Length / 2] = element;

            this.Items = new T[temp.Length];
            for (int i = 0; i < this.Items.Length; i++)
            {
                this.Items[i] = temp[i];
            }
        }
    }

    public T Remove(int index)
    {
        var result = this.Items[index];

        for (int i = index; i < this.Items.Length; i++)
        {
            this.Items[i] = this.Items[Math.Min(i + 1, this.Items.Length - 1)];
            this.Items[Math.Min(i + 1, this.Items.Length - 1)] = default(T);
        }

        return result;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < this.Items.Length; i++)
        {
            if (this.Items[i].CompareTo(element) == 0)
            {
                return true;
            }
        }
        return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        var temp = this.Items[firstIndex];
        this.Items[firstIndex] = this.Items[secondIndex];
        this.Items[secondIndex] = temp;
    }

    public T Max()
    {
        var maxElement = this.Items[0];

        for (int i = 0; i < this.Items.Length; i++)
        {
            if (maxElement.CompareTo(this.Items[i]) == -1)
            {
                maxElement = this.Items[i];
            }
        }
        return maxElement;
    }

    public int CountGreaterThan(T element)
    {
        var result = 0;

        for (int i = 0; i < this.Items.Length; i++)
        {
            if (this.Items[i] == null)
            {
                break;
            }
            if (this.Items[i].CompareTo(element) == 1)
            {
                result++;
            }
        }
        return result;
    }

    public void Print()
    {
        for (int i = 0; i < this.Items.Length; i++)
        {
            if (this.Items[i]==null)
            {
                break;
            }
            Console.WriteLine(this.Items[i]);
        }
    }

    public T Min()
    {
        var minElement = this.Items[0];

        for (int i = 0; i < this.Items.Length; i++)
        {
            if (this.Items[i] == null)
            {
                break;
            }
            if (minElement.CompareTo(this.Items[i]) == 1)
            {
                minElement = this.Items[i];
            }
        }
        return minElement;
    }
}