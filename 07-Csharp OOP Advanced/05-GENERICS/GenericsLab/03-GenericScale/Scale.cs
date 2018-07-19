using System;

public class Scale<T>
  where T : IComparable<T>
{
    public T LeftItem { get; set; }
    public T RightItem { get; set; }

    public Scale(T leftItem, T rightItem)
    {
        this.LeftItem = leftItem;
        this.RightItem = rightItem;
    }

    public T GetHeavier()
    {
        var result = this.LeftItem.CompareTo(this.RightItem);

        if (result>0)
        {
            return LeftItem;
        }
        if (result<0)
        {
            return RightItem;
        }

        return default(T);
    }
}