public class StartUp
{
    static void Main()
    {
        var scale = new Scale<int>(21, 45);

        System.Console.WriteLine(scale.GetHeavier());
    }
}