public class StreamProgressInfo
{
    public IStreamProgress Item { get; set; }

    // If we want to stream a music file, we can't
    public StreamProgressInfo(IStreamProgress item)
    {
        this.Item = item;
    }

    public int CalculateCurrentPercent()
    {
        return (this.Item.BytesSent * 100) / this.Item.Length;
    }
}