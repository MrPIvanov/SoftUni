using System;
using System.Collections.Generic;

public class BinaryHeap<T> where T : IComparable<T>
{
    private List<T> heap;

    public BinaryHeap()
    {
        this.heap = new List<T>();
    }

    public int Count
    {
        get
        {
            return this.heap.Count;
        }
    }

    public void Insert(T item)
    {
        this.heap.Add(item);
        this.HeapifyUp(this.heap.Count - 1);
    }

    private void HeapifyUp(int ItemIndex)
    {
        var parrentIndex = (ItemIndex - 1) / 2;

        var compare = this.heap[parrentIndex].CompareTo(this.heap[ItemIndex]);

        if (compare < 0)
        {
            Swap(parrentIndex, ItemIndex);
            ItemIndex = parrentIndex;
            this.HeapifyUp(ItemIndex);
        }
    }

    private void Swap(int parrentIndex, int itemIndex)
    {
        var temp = this.heap[parrentIndex];
        this.heap[parrentIndex] = this.heap[itemIndex];
        this.heap[itemIndex] = temp;
    }

    public T Peek()
    {
        return this.heap[0];
    }

    public T Pull()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        var element = this.heap[0];

        Swap(0, this.Count - 1);

        this.heap.RemoveAt(this.Count - 1);

        this.HeapifyDown(0);

        return element;
    }

    private void HeapifyDown(int itemIndex)
    {
        if (this.Count / 2 > itemIndex)
        {
            var childIndex = (2 * itemIndex) + 1;

            if ((childIndex + 1) < this.Count - 1 &&
                this.heap[childIndex].CompareTo(this.heap[childIndex + 1]) < 0)
            {
                childIndex++;
            }

            var compare = this.heap[itemIndex].CompareTo(this.heap[childIndex]);

            if (compare < 0)
            {
                Swap(itemIndex, childIndex);

                itemIndex = childIndex;

                this.HeapifyDown(itemIndex);
            }
        }
    }
}
