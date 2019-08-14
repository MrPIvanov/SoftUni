using System;

public static class Heap<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        var n = arr.Length;

        for (int i = n / 2; i >= 0; i--)
        {
            MoveElementDown(arr, i, n);
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(arr, 0, i);
            MoveElementDown(arr, 0, i);
        }
    }

    public static void MoveElementDown(T[] arr, int itemIndex, int LastIndex)
    {
        if (LastIndex / 2 > itemIndex)
        {
            var childIndex = (2 * itemIndex) + 1;

            if ((childIndex + 1) < LastIndex  &&
                arr[childIndex].CompareTo(arr[childIndex + 1]) < 0)
            {
                childIndex++;
            }

            var compare = arr[itemIndex].CompareTo(arr[childIndex]);

            if (compare < 0)
            {
                Swap(arr, itemIndex, childIndex);

                itemIndex = childIndex;

                MoveElementDown(arr, itemIndex, LastIndex);
            }
        }
    }

    private static void Swap(T[] arr, int currentItemIndex, int childIndex)
    {
        var temp = arr[currentItemIndex];
        arr[currentItemIndex] = arr[childIndex];
        arr[childIndex] = temp;
    }
}
